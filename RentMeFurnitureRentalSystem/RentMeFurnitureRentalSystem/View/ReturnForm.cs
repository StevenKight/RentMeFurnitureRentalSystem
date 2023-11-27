using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.View;

/// <summary>
///     Returns the furniture to the store
/// </summary>
public partial class ReturnForm : Form
{
    #region Data members

    private List<RentalItem> rentals;

    private List<Furniture> furniture;
    private List<Furniture> display;

    private readonly Employee employee;
    private readonly Customer customer;

    #endregion

    #region Constructors

    /// <summary>
    ///     instantiates the return form with the employee and customer
    /// </summary>
    /// <param name="employee"></param>
    /// <param name="customer"></param>
    public ReturnForm(Employee employee, Customer customer)
    {
        this.employee = employee;
        this.customer = customer;

        this.InitializeComponent();
        
        this.titleTextBox.Text = "Return from " + this.customer.Fullname;

        this.loadData();
    }

    #endregion

    #region Methods

    private void loadData()
    {
        this.rentals = RentalDal.GetRentalsByCustomer(this.customer);
        this.display = new List<Furniture>();
        this.furniture = new List<Furniture>();

        this.rentalsDataGridView.DataSource = this.rentals;
        this.furnitureDataGridView.DataSource = this.display;

        this.rentalsDataGridView.ClearSelection();
        this.furnitureDataGridView.ClearSelection();
    }

    private void furnitureDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        var gridView = (DataGridView)sender;
        if (gridView.CurrentCell.ColumnIndex != 8)
        {
            return;
        }

        var currentObject = (Furniture)gridView.CurrentRow?.DataBoundItem;
        if (currentObject.DisplayQuantity < currentObject.Quantity)
        {
            this.errorProvider.SetError(gridView, "Cannot set quantity to more than rented.");
            currentObject.Quantity = currentObject.DisplayQuantity;
        }
    }

    private void rentalsDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected)
        {
            return;
        }

        var selectedRental = (RentalItem)e.Row.DataBoundItem;
        if (selectedRental != null)
        {
            this.display.ForEach(x =>
            {
                if (x.Quantity == 0)
                {
                    return;
                }

                x.RentalId = selectedRental.Rental_id;
                if (!this.furniture.Contains(x))
                {
                    this.furniture.Add(x);
                }
                else
                {
                    var index = this.furniture.IndexOf(x);
                    this.furniture[index].Quantity = x.Quantity;
                }
            });

            var rentalFurniture = FurnitureDal.GetFurnitureByRental(selectedRental);
            rentalFurniture.ForEach(x =>
            {
                x.DisplayQuantity = x.Quantity;
                x.Quantity = 0;

                if (this.furniture.Contains(x))
                {
                    var displayed = this.furniture.FirstOrDefault(y => y.Furniture_id == x.Furniture_id);
                    x.Quantity = displayed.Quantity;
                }
            });

            this.display = rentalFurniture;

            this.furnitureDataGridView.DataSource = this.display;
        }
    }

    private void ReturnForm_Shown(object sender, EventArgs e)
    {
        if (this.rentals.Count <= 0)
        {
            MessageBox.Show("No rentals found for the selected user.", "No Rentals", MessageBoxButtons.OK);
            Close();
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        this.display.ForEach(x =>
        {
            if (x.Quantity == 0)
            {
                return;
            }

            var selectedRental = (RentalItem)this.rentalsDataGridView.SelectedRows[0].DataBoundItem;
            x.RentalId = selectedRental.Rental_id;
            if (!this.furniture.Contains(x))
            {
                this.furniture.Add(x);
            }
            else
            {
                var index = this.furniture.IndexOf(x);
                this.furniture[index].Quantity = x.Quantity;
            }
        });

        var selectedFurniture = this.furniture.Where(x => x.Quantity > 0).ToList();

        if (selectedFurniture.Count <= 0)
        {
            this.errorProvider.SetError(this.furnitureDataGridView,
                "Please select at least one piece of furniture for the rental.");
        }

        var newReturn = new RentalItem
        {
            Member_id = this.customer.Member_id,
            Employee_num = this.employee.Employee_num,
            Start_date = DateTime.Now.Date
        };

        var confirmation = MessageBox.Show("Are you sure you want to return the selected furniture?", "Confirm Return",
            MessageBoxButtons.YesNo);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        var newReturnId = RentalDal.ReturnFurniture(newReturn, selectedFurniture);
        if (newReturnId == -1)
        {
            MessageBox.Show("Error creating return for user.");
            return;
        }

        MessageBox.Show("Successfully returned furniture");

        var receipt = new ReturnReceiptForm(newReturnId);
        receipt.StartPosition = FormStartPosition.Manual;
        receipt.Left = Left + (Width - receipt.Width) / 2;
        receipt.Top = Top + (Height - receipt.Height) / 2;

        receipt.ShowDialog();

        Close();
    }

    #endregion
}