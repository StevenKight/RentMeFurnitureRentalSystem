using System.Diagnostics;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;
using RentMeFurnitureRentalSystem.view;

namespace RentMeFurnitureRentalSystem;

public partial class MainScreenForm : Form
{
    #region Properties

    #region Data Members

    public Employee LoggedInEmployee { get; set; }

    public List<Employee> Employees { get; set; }
    public List<Customer> Customers { get; set; }

    public Employee SelectedEmployee { get; set; }
    public Customer SelectedCustomer { get; set; }

    #endregion

    #endregion

    #region Constructors

    public MainScreenForm(Employee employee)
    {

        this.InitializeComponent();

        var screenWidth = Screen.PrimaryScreen.Bounds.Width;
        var screenHeight = Screen.PrimaryScreen.Bounds.Height;

        StartPosition = FormStartPosition.Manual;
        var x = (screenWidth - Width) / 2;
        var y = (screenHeight - Height) / 2;
        Location = new Point(x, y);

        this.LoggedInEmployee = employee;
        this.employeeDisplay.Text = employee.EmployeeNum + " " + employee.Username + @": " + 
                                    employee.Firstname + " " + employee.Lastname;
        this.checkIfAdmin();

        this.getData();

        this.setupGridViews();
    }

    #endregion

    #region Methods

    private void getData()
    {
        this.Employees = EmployeeDal.GetAllEmployees();
        this.Customers = CustomerDal.GetAllCustomers();

        this.populateGridViews();
    }

    private void setupGridViews()
    {
        this.customerGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.customerGridView.Columns[0].HeaderText = "Name";
        this.customerGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.customerGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        if (this.employeeGridView.Columns.Count <= 0)
        {
            return;
        }

        this.employeeGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.employeeGridView.Columns[0].HeaderText = "Name";
        this.employeeGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.employeeGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private void populateGridViews()
    {
        this.customerGridView.DataSource = this.Customers.Select(customer =>
        {
            var FullName = customer.Firstname + " " + customer.Lastname;
            return new { FullName, customer.Phone, customer.Email };
        }).ToList();

        this.employeeGridView.DataSource = this.Employees.Select(employee =>
        {
            var FullName = employee.Firstname + " " + employee.Lastname;
            return new { FullName, employee.Phone, employee.Email };
        }).ToList();
    }

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        var addEmployeeForm = new addUserForm(true);
        addEmployeeForm.StartPosition = FormStartPosition.Manual;
        addEmployeeForm.Left = Left + (Width - addEmployeeForm.Width) / 2;
        addEmployeeForm.Top = Top + (Height - addEmployeeForm.Height) / 2;

        addEmployeeForm.ShowDialog();
        this.getData();
    }

    private void addCustomerButton_Click(object sender, EventArgs e)
    {
        var addCustomerForm = new addUserForm(false);
        addCustomerForm.StartPosition = FormStartPosition.Manual;
        addCustomerForm.Left = Left + (Width - addCustomerForm.Width) / 2;
        addCustomerForm.Top = Top + (Height - addCustomerForm.Height) / 2;

        addCustomerForm.ShowDialog();
        this.getData();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        this.LoggedInEmployee = null;
        DialogResult = DialogResult.Continue;
        Close();
    }

    private void checkIfAdmin()
    {
        if (this.LoggedInEmployee.Role.Equals("administrator"))
        {
            return;
        }

        this.dashboardTabs.TabPages.Remove(this.employeesTab);
    }

    private void customerGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected) return;

        var selectedRows = this.customerGridView.SelectedRows;
        if (selectedRows.Count > 0)
        {
            var selectedObject = selectedRows[0].DataBoundItem;
            var nameProperty = selectedObject.GetType().GetProperty("FullName");
            var fullName = (string)nameProperty?.GetValue(selectedObject, null);
            var phoneProperty = selectedObject.GetType().GetProperty("Phone");
            var phone = (string)phoneProperty?.GetValue(selectedObject, null);
            var emailProperty = selectedObject?.GetType().GetProperty("Email");
            var email = (string)emailProperty?.GetValue(selectedObject, null);

            var customer = this.Customers.Find(x =>
            {
                var fullname = x.Firstname + " " + x.Lastname;
                return fullname.Equals(fullName) && x.Phone.Equals(phone) && x.Email.Equals(email);
            });

            this.SelectedCustomer = customer;
        }
    }

    private void employeeGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected) return;

        var selectedRows = this.employeeGridView.SelectedRows;
        if (selectedRows.Count > 0)
        {
            var selectedObject = selectedRows[0].DataBoundItem;
            var nameProperty = selectedObject.GetType().GetProperty("FullName");
            var fullName = (string)nameProperty?.GetValue(selectedObject, null);
            var phoneProperty = selectedObject.GetType().GetProperty("Phone");
            var phone = (string)phoneProperty?.GetValue(selectedObject, null);
            var emailProperty = selectedObject?.GetType().GetProperty("Email");
            var email = (string)emailProperty?.GetValue(selectedObject, null);

            var employee = this.Employees.Find(x =>
            {
                var fullname = x.Firstname + " " + x.Lastname;
                return fullname.Equals(fullName) && x.Phone.Equals(phone) && x.Email.Equals(email);
            });

            this.SelectedEmployee = employee;
        }
    }

    private void customerGridView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var customerDisplayForm = new addUserForm(this.SelectedCustomer);
        customerDisplayForm.StartPosition = FormStartPosition.Manual;
        customerDisplayForm.Left = Left + (Width - customerDisplayForm.Width) / 2;
        customerDisplayForm.Top = Top + (Height - customerDisplayForm.Height) / 2;

        customerDisplayForm.ShowDialog();
    }

    private void employeeGridView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var employeeDisplayForm = new addUserForm(this.SelectedEmployee);
        employeeDisplayForm.StartPosition = FormStartPosition.Manual;
        employeeDisplayForm.Left = Left + (Width - employeeDisplayForm.Width) / 2;
        employeeDisplayForm.Top = Top + (Height - employeeDisplayForm.Height) / 2;

        employeeDisplayForm.ShowDialog();
    }

    #endregion

}