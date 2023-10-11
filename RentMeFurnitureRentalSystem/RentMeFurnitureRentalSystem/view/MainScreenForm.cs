using RentMeFurnitureRentalSystem.view;

namespace RentMeFurnitureRentalSystem;

public partial class MainScreenForm : Form
{
    #region Constructors

    public MainScreenForm()
    {
        this.InitializeComponent();
    }

    #endregion

    #region Methods

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        var addEmployeeForm = new addEmployeeForm();
        addEmployeeForm.ShowDialog();
        this.Close();
    }

    private void addCustomerButton_Click(object sender, EventArgs e)
    {
    }
    private void logoutButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        var loginForm = new Form1();
        loginForm.ShowDialog();
        this.Close();
    }

    #endregion


}