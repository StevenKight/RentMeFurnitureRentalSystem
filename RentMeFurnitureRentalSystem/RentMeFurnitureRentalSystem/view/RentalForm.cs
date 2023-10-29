using System.ComponentModel;
using System.IO.Pipelines;
using System.Text.RegularExpressions;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.view;

public partial class RentalForm : Form
{
    private List<Customer> Customers;
    private List<Furniture> Furniture;

    #region Constructors

    public RentalForm(Employee employee)
    {
        this.InitializeComponent();

        this.loadData();
    }

    #endregion

    private void loadData()
    {
        this.Customers = CustomerDal.GetAllCustomers();

        this.userDataGridView.DataSource = this.Customers;

        this.Furniture = FurnitureDAL.GetAllFurniture().Where(piece => piece.Quantity > 0).ToList();
        this.Furniture.ForEach(x => x.Quantity = 0);

        this.furnitureGridView.DataSource = this.Furniture; ;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        var selectedCustomer = this.getSelectedCustomer();
        var selectedFurniture = this.Furniture.Where(x => x.Quantity > 0).ToList();

        // TODO: Write out to db
    }

    private Customer getSelectedCustomer()
    {
        if (userDataGridView.SelectedRows.Count == 0)
        {
            this.errorProvider.SetError(this.userDataGridView, "Please select a user.");
        }

        return userDataGridView.SelectedRows[0].DataBoundItem as Customer;
    }

    private void furnitureGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (this.furnitureGridView.CurrentCell.ColumnIndex == 4)
        {
            var currentCell = this.furnitureGridView.CurrentCell;
        }
    }
}