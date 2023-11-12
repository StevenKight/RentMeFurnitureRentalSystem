using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.view;

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

        this.rentalsDataGridView.DataSource = this.Rentals;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("NOT IMPLEMENTED YET");
    }

    #endregion
}