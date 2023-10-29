using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;
using RentMeFurnitureRentalSystem.view;

namespace RentMeFurnitureRentalSystem;

public partial class MainScreenForm : Form
{
    #region Constructors

    public MainScreenForm(Employee employee)
    {
        InitializeComponent();

        var screenWidth = Screen.PrimaryScreen.Bounds.Width;
        var screenHeight = Screen.PrimaryScreen.Bounds.Height;

        StartPosition = FormStartPosition.Manual;
        var x = (screenWidth - Width) / 2;
        var y = (screenHeight - Height) / 2;
        Location = new Point(x, y);

        LoggedInEmployee = employee;
        employeeDisplay.Text = employee.EmployeeNum + " " + employee.Username + @": " +
                               employee.Fname + " " + employee.Lname;
        checkIfAdmin();

        getData();
    }

    #endregion

    #region Properties

    #region Data Members

    public Employee LoggedInEmployee { get; set; }

    public List<Employee> Employees { get; set; }
    public List<Customer> Customers { get; set; }

    public Employee SelectedEmployee { get; set; }
    public Customer SelectedCustomer { get; set; }

    #endregion

    #endregion

    #region Methods

    private void getData()
    {
        Employees = EmployeeDal.GetAllEmployees();
        Customers = CustomerDal.GetAllCustomers();

        populateGridViews();
    }

    private void populateGridViews()
    {
        customerGridView.DataSource = this.Customers;
        employeeGridView.DataSource = this.Employees;
    }

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        var addEmployeeForm = new addUserForm(true);
        addEmployeeForm.StartPosition = FormStartPosition.Manual;
        addEmployeeForm.Left = Left + (Width - addEmployeeForm.Width) / 2;
        addEmployeeForm.Top = Top + (Height - addEmployeeForm.Height) / 2;

        addEmployeeForm.ShowDialog();
        getData();
    }

    private void addCustomerButton_Click(object sender, EventArgs e)
    {
        var addCustomerForm = new addUserForm(false);
        addCustomerForm.StartPosition = FormStartPosition.Manual;
        addCustomerForm.Left = Left + (Width - addCustomerForm.Width) / 2;
        addCustomerForm.Top = Top + (Height - addCustomerForm.Height) / 2;

        addCustomerForm.ShowDialog();
        getData();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        LoggedInEmployee = null;
        DialogResult = DialogResult.Continue;
        Close();
    }

    private void checkIfAdmin()
    {
        if (LoggedInEmployee.Role_name.Equals("administrator")) return;

        dashboardTabs.TabPages.Remove(employeesTab);
    }

    private void customerGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected) return;

        var selectedRows = customerGridView.SelectedRows;
        if (selectedRows.Count > 0)
        {
            this.SelectedCustomer = selectedRows[0].DataBoundItem as Customer;
        }
    }

    private void employeeGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected) return;

        var selectedRows = employeeGridView.SelectedRows;
        if (selectedRows.Count > 0)
        {
            this.SelectedEmployee = selectedRows[0].DataBoundItem as Employee;
        }
    }

    private void customerGridView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var customerDisplayForm = new addUserForm(SelectedCustomer);
        customerDisplayForm.StartPosition = FormStartPosition.Manual;
        customerDisplayForm.Left = Left + (Width - customerDisplayForm.Width) / 2;
        customerDisplayForm.Top = Top + (Height - customerDisplayForm.Height) / 2;

        customerDisplayForm.ShowDialog();
    }

    private void employeeGridView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var employeeDisplayForm = new addUserForm(SelectedEmployee);
        employeeDisplayForm.StartPosition = FormStartPosition.Manual;
        employeeDisplayForm.Left = Left + (Width - employeeDisplayForm.Width) / 2;
        employeeDisplayForm.Top = Top + (Height - employeeDisplayForm.Height) / 2;

        employeeDisplayForm.ShowDialog();
    }

    private void rentButton_Click(object sender, EventArgs e)
    {
        var rentalForm = new RentalForm(this.LoggedInEmployee);
        rentalForm.StartPosition = FormStartPosition.Manual;
        rentalForm.Left = Left + (Width - rentalForm.Width) / 2;
        rentalForm.Top = Top + (Height - rentalForm.Height) / 2;
        rentalForm.ShowDialog();
    }

    #endregion
}