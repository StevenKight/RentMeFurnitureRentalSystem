using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.view;
/// <summary>
/// Returns the furniture to the store
/// </summary>
public partial class ReturnForm : Form
{
    #region Data members

    private List<RentalItem> Rentals;

    private List<Furniture> Furniture;
    private List<Furniture> Display;

    private readonly Employee employee;
    private readonly Customer customer;

    #endregion

    #region Constructors
    /// <summary>
    /// instantiates the return form with the employee and customer
    /// </summary>
    /// <param name="employee"></param>
    /// <param name="customer"></param>
    public ReturnForm(Employee employee, Customer customer)
    {
        this.employee = employee;
        this.customer = customer;

        this.InitializeComponent();
        
        this.titleTextBox.Text = "Rent to " + this.customer.Fullname;

        this.loadData();
    }

    #endregion

    #region Methods

    private void loadData()
    {
        this.Rentals = RentalDAL.GetRentalsByCustomer(this.customer);
        this.Display = new List<Furniture>();
        this.Furniture = new List<Furniture>();

        this.rentalsDataGridView.DataSource = this.Rentals;
        this.furnitureDataGridView.DataSource = this.Display;

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
            this.Display.ForEach((x) =>
            {
                if (x.Quantity == 0)
                {
                    return;
                }

                x.Rental_id = selectedRental.Rental_id;
                if (!this.Furniture.Contains(x))
                {
                    this.Furniture.Add(x);
                }
                else
                {
                    var index = this.Furniture.IndexOf(x);
                    this.Furniture[index].Quantity = x.Quantity;
                }
            });

            var rentalFurniture = FurnitureDAL.GetFurnitureByRental(selectedRental);
            rentalFurniture.ForEach(x =>
            {
                x.DisplayQuantity = x.Quantity;
                x.Quantity = 0;

                if (this.Furniture.Contains(x))
                {
                    var displayed = this.Furniture.FirstOrDefault(y => y.Furniture_id == x.Furniture_id);
                    x.Quantity = displayed.Quantity;
                }
            });

            this.Display = rentalFurniture;

            this.furnitureDataGridView.DataSource = this.Display;
        }
    }

    private void ReturnForm_Shown(object sender, EventArgs e)
    {
        if (this.Rentals.Count <= 0)
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
        this.Display.ForEach((x) =>
        {
            if (x.Quantity == 0)
            {
                return;
            }

            var selectedRental = (RentalItem)this.rentalsDataGridView.SelectedRows[0].DataBoundItem;
            x.Rental_id = selectedRental.Rental_id;
            if (!this.Furniture.Contains(x))
            {
                this.Furniture.Add(x);
            }
            else
            {
                var index = this.Furniture.IndexOf(x);
                this.Furniture[index].Quantity = x.Quantity;
            }
        });

        var selectedFurniture = this.Furniture.Where(x => x.Quantity > 0).ToList();

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

        var newReturnId = RentalDAL.CreateReturn(newReturn);
        if (newReturnId <= 0)
        {
            MessageBox.Show("Error creating return transaction.");
            return;
        }

        foreach (var furniture in selectedFurniture)
        {
            var item = new RentalItem
            {
                Return_id = newReturnId,
                Rental_id = furniture.Rental_id,
                Member_id = newReturn.Member_id,
                Employee_num = newReturn.Employee_num,
                Start_date = newReturn.Start_date,
                Furniture_id = furniture.Furniture_id,
                Quantity = furniture.Quantity
            };

            if (!RentalDAL.CreateReturnItem(item))
            {
                MessageBox.Show("Error adding " + furniture.Name + " to the transaction.");
                return;
            }
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