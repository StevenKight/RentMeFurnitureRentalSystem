using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.view;
/// <summary>
/// The form that handles the rental of furniture
/// </summary>
public partial class RentalForm : Form
{
    #region Data members

    private List<Furniture> Furniture;
    private List<Furniture> Display;

    private readonly Employee employee;
    private readonly Customer customer;

    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="RentalForm"/> class.
    /// </summary>
    /// <param name="employee"></param>
    /// <param name="customer"></param>
    public RentalForm(Employee employee, Customer customer)
    {
        this.employee = employee;
        this.customer = customer;

        this.InitializeComponent();

        this.populateStyleAndCategoryComboBoxes();
        this.titleTextBox.Text = "Rent to " + this.customer.Fullname;

        this.loadData();
    }

    #endregion

    #region Methods

    private void populateStyleAndCategoryComboBoxes()
    {
        var categories = CategoryDAL.GetCategories();
        var styles = StyleDAL.GetStyles();

        this.categoryComboBox.DataSource = categories.ToList();
        this.styleComboBox.DataSource = styles.ToList();
    }

    private void loadData()
    {
        this.Furniture = FurnitureDAL.GetRentableFurniture().ToList();
        this.Furniture.ForEach(x =>
        {
            x.DisplayQuantity = x.Quantity;
            x.Quantity = 0;
        });

        this.Display = this.Furniture;

        this.displayData(this.Display);
    }

    private void displayData(List<Furniture> furniture)
    {
        this.Furniture.ForEach(x =>
        {
            if (this.Display.Contains(x))
            {
                var displayed = this.Display.FirstOrDefault(y => y.Furniture_id == x.Furniture_id);
                x.Quantity = displayed.Quantity;
            }
        });

        furniture.ForEach(x =>
        {
            if (this.Furniture.Contains(x))
            {
                var displayed = this.Furniture.FirstOrDefault(y => y.Furniture_id == x.Furniture_id);
                x.Quantity = displayed.Quantity;
            }
        });

        this.Display = furniture;

        this.furnitureGridView.DataSource = this.Display;
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
            this.errorProvider.SetError(gridView, "Cannot set quantity to more than in stock.");
            currentObject.Quantity = currentObject.DisplayQuantity;
        }
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        var filteredFurniture = this.Furniture;
        if (this.IdRadioButton.Checked)
        {
            try
            {
                var id = int.Parse(this.furnitureSearchTextBox.Text);
                filteredFurniture = FurnitureDAL.GetRentableFurnitureById(id).ToList();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a postive number");
            }
        }
        else if (this.categoryRadioButton.Checked)
        {
            var category = this.categoryComboBox.Text;
            filteredFurniture = FurnitureDAL.GetRentableFurnitureByCategory(category).ToList();
        }
        else
        {
            var style = this.styleComboBox.Text;
            filteredFurniture = FurnitureDAL.GetRentableFurnitureByStyle(style).ToList();
        }

        filteredFurniture.ForEach(x => x.DisplayQuantity = x.Quantity);
        this.displayData(filteredFurniture);
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        this.displayData(this.Furniture);
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        var selectedFurniture = this.Furniture.Where(x => x.Quantity > 0).ToList();

        if (selectedFurniture.Count <= 0)
        {
            this.errorProvider.SetError(this.furnitureGridView,
                "Please select at least one piece of furniture for the rental.");
        }

        var rental = new RentalItem
        {
            Member_id = this.customer.Member_id,
            Employee_num = this.employee.Employee_num,
            Start_date = DateTime.Now.Date,
            Due_date = this.dueDateDateTimePicker.Value.Date
        };

        var confirmation = MessageBox.Show("Are you sure you want to rent the selected furniture?", "Confirm Rental",
            MessageBoxButtons.YesNo);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        var newRentalId = RentalDAL.RentFurniture(rental, selectedFurniture);
        if (newRentalId == -1)
        {
            MessageBox.Show("Error creating rental for user.");
            return;
        }

        MessageBox.Show("Successfully rented to user");

        var receipt = new RentalReceiptForm(newRentalId);
        receipt.StartPosition = FormStartPosition.Manual;
        receipt.Left = Left + (Width - receipt.Width) / 2;
        receipt.Top = Top + (Height - receipt.Height) / 2;

        receipt.ShowDialog();

        Close();
    }

    #endregion
}