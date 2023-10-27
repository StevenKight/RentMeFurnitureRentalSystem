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

        setupGridViews();
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

    private void setupGridViews()
    {
        customerGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        customerGridView.Columns[0].HeaderText = "Name";
        customerGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        customerGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        if (employeeGridView.Columns.Count <= 0) return;

        employeeGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        employeeGridView.Columns[0].HeaderText = "Name";
        employeeGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        employeeGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private void populateGridViews()
    {
        customerGridView.DataSource = Customers.Select(customer =>
        {
            var FullName = customer.Fname + " " + customer.Lname;
            return new { FullName, customer.Phone, customer.Email };
        }).ToList();

        employeeGridView.DataSource = Employees.Select(employee =>
        {
            var FullName = employee.Fname + " " + employee.Lname;
            return new { FullName, employee.Phone, employee.Email };
        }).ToList();
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
            var selectedObject = selectedRows[0].DataBoundItem;
            var nameProperty = selectedObject.GetType().GetProperty("FullName");
            var fullName = (string)nameProperty?.GetValue(selectedObject, null);
            var phoneProperty = selectedObject.GetType().GetProperty("Phone");
            var phone = (string)phoneProperty?.GetValue(selectedObject, null);
            var emailProperty = selectedObject?.GetType().GetProperty("Email");
            var email = (string)emailProperty?.GetValue(selectedObject, null);

            var customer = Customers.Find(x =>
            {
                var fullname = x.Fname + " " + x.Lname;
                return fullname.Equals(fullName) && x.Phone.Equals(phone) && x.Email.Equals(email);
            });

            SelectedCustomer = customer;
        }
    }

    private void employeeGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected) return;

        var selectedRows = employeeGridView.SelectedRows;
        if (selectedRows.Count > 0)
        {
            var selectedObject = selectedRows[0].DataBoundItem;
            var nameProperty = selectedObject.GetType().GetProperty("FullName");
            var fullName = (string)nameProperty?.GetValue(selectedObject, null);
            var phoneProperty = selectedObject.GetType().GetProperty("Phone");
            var phone = (string)phoneProperty?.GetValue(selectedObject, null);
            var emailProperty = selectedObject?.GetType().GetProperty("Email");
            var email = (string)emailProperty?.GetValue(selectedObject, null);

            var employee = Employees.Find(x =>
            {
                var fullname = x.Fname + " " + x.Lname;
                return fullname.Equals(fullName) && x.Phone.Equals(phone) && x.Email.Equals(email);
            });

            SelectedEmployee = employee;
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

    #endregion

    private void addCustomerButton_Click_1(object sender, EventArgs e)
    {
        var addCustomerForm = new addUserForm(false);
        addCustomerForm.StartPosition = FormStartPosition.Manual;
        addCustomerForm.Left = Left + (Width - addCustomerForm.Width) / 2;
        addCustomerForm.Top = Top + (Height - addCustomerForm.Height) / 2;

        addCustomerForm.ShowDialog();
        getData();
    }

    private void logoutButton_Click_1(object sender, EventArgs e)
    {
        LoggedInEmployee = null;
        DialogResult = DialogResult.Continue;
        Close();
    }

    private void addEmployeeButton_Click_1(object sender, EventArgs e)
    {
        var addEmployeeForm = new addUserForm(true);
        addEmployeeForm.StartPosition = FormStartPosition.Manual;
        addEmployeeForm.Left = Left + (Width - addEmployeeForm.Width) / 2;
        addEmployeeForm.Top = Top + (Height - addEmployeeForm.Height) / 2;

        addEmployeeForm.ShowDialog();
        getData();
    }

    private void addFurnitureButton_Click(object sender, EventArgs e)
    {
        var addFurnitureForm = new addFurnitureForm();
        addFurnitureForm.Left = Left + (Width - addFurnitureForm.Width) / 2;
        addFurnitureForm.Top = Top + (Height - addFurnitureForm.Height) / 2;

        addFurnitureForm.ShowDialog();

    }
}