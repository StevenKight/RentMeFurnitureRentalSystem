using System.Text.RegularExpressions;
using Google.Protobuf.WellKnownTypes;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;
using RentMeFurnitureRentalSystem.view;

namespace RentMeFurnitureRentalSystem;
/// <summary>
/// Main screen form that displays all the data for the user to see
/// </summary>
public partial class MainScreenForm : Form
{

    #region Data Members
    /// <summary>
    /// Logged in employee
    /// </summary>
    public Employee LoggedInEmployee { get; set; }
    /// <summary>
    /// list of employees
    /// </summary>
    public List<Employee> Employees { get; set; }
    /// <summary>
    /// list of customers
    /// </summary>
    public List<Customer> Customers { get; set; }
    /// <summary>
    /// list of furniture
    /// </summary>
    public List<Furniture> Furniture { get; set; }
    /// <summary>
    /// selected employee
    /// </summary>
    public Employee SelectedEmployee { get; set; }
    /// <summary>
    /// selected customer
    /// </summary>
    public Customer SelectedCustomer { get; set; }
    /// <summary>
    /// selected furniture
    /// </summary>
    public Furniture SelectedFurniture { get; set; }
    /// <summary>
    /// regex for phone number
    /// </summary>
    public const string PHONEREGEXNODASH = @"^[0-9]{3}[0-9]{3}[0-9]{4}$";

    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="MainScreenForm"/> class.
    /// </summary>
    /// <param name="employee"></param>
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
        this.employeeDisplay.Text = employee.Employee_num + " " + employee.Username + @": " +
                                    employee.Fname + " " + employee.Lname;
        this.checkIfAdmin();

        getData();
    }

    #endregion

    #region Methods

    private void getData()
    {
        Employees = EmployeeDal.GetAllEmployees();
        Customers = CustomerDal.GetAllCustomers();
        Furniture = FurnitureDAL.GetFurniture().ToList();

        populateGridViews();
        this.populateStyleAndCategoryComboBoxes();
    }

    private void populateGridViews()
    {
        customerGridView.DataSource = this.Customers;
        employeeGridView.DataSource = this.Employees;
        this.furnitureGridView.DataSource = this.Furniture;
    }

    private void checkIfAdmin()
    {
        if (this.LoggedInEmployee.Role_name.Equals("administrator"))
        {
            return;
        }
        this.adminTableButton.Enabled = false;
        this.adminTableButton.Visible = false;
        this.dashboardTabs.TabPages.Remove(this.employeesTab);
    }

    private void populateStyleAndCategoryComboBoxes()
    {
        var categories = CategoryDAL.GetCategories();
        var styles = StyleDAL.GetStyles();

        this.categoryComboBox.DataSource = categories.ToList();
        this.styleComboBox.DataSource = styles.ToList();
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

    private void deleteEmployeeButton_Click(object sender, EventArgs e)
    {
        if (this.SelectedEmployee == null)
        {
            MessageBox.Show(@"Please select a employee to delete");
            return;
        }

        var employeeName = this.SelectedEmployee.Fname + " " + this.SelectedEmployee.Lname;
        var result = MessageBox.Show($"Are you sure you want to delete {employeeName}?", @"Delete employee",
            MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            MessageBox.Show(EmployeeDal.DeleteEmployee(this.SelectedEmployee)
                ? @"Employee deleted"
                : @"Employee could not be deleted");
            this.getData();
        }
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

    private void deleteCustomerButton_Click(object sender, EventArgs e)
    {
        if (this.SelectedCustomer == null)
        {
            MessageBox.Show(@"Please select a customer to delete");
            return;
        }

        var customerName = this.SelectedCustomer.Fname + " " + this.SelectedCustomer.Lname;
        var result = MessageBox.Show($"Are you sure you want to delete {customerName}?", @"Delete Customer",
            MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            MessageBox.Show(CustomerDal.DeleteCustomer(this.SelectedCustomer)
                ? @"Customer deleted"
                : @"Customer could not be deleted");

            this.getData();
        }
    }

    private void addFurnitureButton_Click(object sender, EventArgs e)
    {
        var addFurnitureForm = new addFurnitureForm();
        addFurnitureForm.StartPosition = FormStartPosition.Manual;
        addFurnitureForm.Left = Left + (Width - addFurnitureForm.Width) / 2;
        addFurnitureForm.Top = Top + (Height - addFurnitureForm.Height) / 2;

        addFurnitureForm.ShowDialog();
        getData();
    }

    private void deleteFurnitureButton_Click(object sender, EventArgs e)
    {
        if (this.SelectedFurniture == null)
        {
            MessageBox.Show(@"Please select a piece of furniture to delete");
            return;
        }


        var result = MessageBox.Show($"Are you sure you want to delete all ({this.SelectedFurniture.Quantity}) {this.SelectedFurniture.Name}?", @"Delete Furniture",
            MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            MessageBox.Show(FurnitureDAL.DeleteFurniture(this.SelectedFurniture)
                ? @"Furniture deleted"
                : @"Furniture could not be deleted");

            this.getData();
        }
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        this.LoggedInEmployee = null;
        DialogResult = DialogResult.Continue;
        Close();
    }

    private void employeeGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected)
        {
            this.deleteEmployeeButton.Enabled = false;
            return;
        }

        this.deleteEmployeeButton.Enabled = true;

        var selectedRows = this.employeeGridView.SelectedRows;
        if (selectedRows.Count > 0)
        {
            this.SelectedEmployee = selectedRows[0].DataBoundItem as Employee;
        }
    }

    private void customerGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected)
        {
            this.deleteCustomerButton.Enabled = false;
            this.rentButton.Enabled = false;
            this.returnButton.Enabled = false;
            return;
        }

        this.deleteCustomerButton.Enabled = true;
        this.rentButton.Enabled = true;
        this.returnButton.Enabled = true;

        var selectedRows = this.customerGridView.SelectedRows;
        if (selectedRows.Count > 0)
        {
            this.SelectedCustomer = selectedRows[0].DataBoundItem as Customer;
        }
    }

    private void furnitureGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected)
        {
            this.deleteFurnitureButton.Enabled = false;
            return;
        }

        this.deleteFurnitureButton.Enabled = true;

        var selectedRows = this.furnitureGridView.SelectedRows;
        if (selectedRows.Count > 0)
        {
            this.SelectedFurniture = selectedRows[0].DataBoundItem as Furniture;
        }
    }

    private void customerGridView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var customerDisplayForm = new addUserForm(this.SelectedCustomer);
        customerDisplayForm.StartPosition = FormStartPosition.Manual;
        customerDisplayForm.Left = Left + (Width - customerDisplayForm.Width) / 2;
        customerDisplayForm.Top = Top + (Height - customerDisplayForm.Height) / 2;

        customerDisplayForm.ShowDialog();
        this.getData();
    }

    private void employeeGridView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var employeeDisplayForm = new addUserForm(this.SelectedEmployee);
        employeeDisplayForm.StartPosition = FormStartPosition.Manual;
        employeeDisplayForm.Left = Left + (Width - employeeDisplayForm.Width) / 2;
        employeeDisplayForm.Top = Top + (Height - employeeDisplayForm.Height) / 2;

        employeeDisplayForm.ShowDialog();
        this.getData();
    }

    private void furnitureGridView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var furnitureDisplayForm = new addFurnitureForm(this.SelectedFurniture);
        furnitureDisplayForm.StartPosition = FormStartPosition.Manual;
        furnitureDisplayForm.Left = Left + (Width - furnitureDisplayForm.Width) / 2;
        furnitureDisplayForm.Top = Top + (Height - furnitureDisplayForm.Height) / 2;

        furnitureDisplayForm.ShowDialog();
        this.getData();
    }

    private void furnitureSearchButton_Click(object sender, EventArgs e)
    {
        if (this.IdRadioButton.Checked)
        {
            try
            {
                var id = int.Parse(this.furnitureSearchTextBox.Text);
                var furniture = FurnitureDAL.GetFurnitureById(id);

                this.Furniture.Clear();

                this.Furniture = furniture.ToList();
                this.populateGridViews();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a postive number");
            }

        }
        else if (this.categoryRadioButton.Checked)
        {
            var category = this.categoryComboBox.Text;
            var furniture = FurnitureDAL.GetFurnitureByCategory(category);
            this.Furniture.Clear();
            this.Furniture = furniture.ToList();
            this.populateGridViews();

        }
        else
        {
            var style = this.styleComboBox.Text;
            var furniture = FurnitureDAL.GetFurnitureByStyle(style);
            this.Furniture.Clear();
            this.Furniture = furniture.ToList();
            this.populateGridViews();
        }
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        this.Furniture.Clear();
        this.Furniture = FurnitureDAL.GetFurniture().ToList();
        this.populateGridViews();
    }

    private void customerSearchButton_Click(object sender, EventArgs e)
    {
        if (this.memberIDRadioButton.Checked)
        {
            try
            {
                var memberId = int.Parse(this.memberIdTextBox.Text);
                var customers = CustomerDal.GetCustomerByMemberID(memberId);
                this.Customers.Clear();
                this.Customers = customers.ToList();
                this.populateGridViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a postive number");
            }

        }
        else if (this.phoneNumberRadioButton.Checked)
        {
            var phoneValue = this.phoneNumberTextBox.Text;
            var value = phoneValue.Replace("-", "");
            try
            {
                var areaCode = value.Substring(0, 3);
                var next = value.Substring(3, 3);
                var last = value.Substring(6, 4);
                var validPhone = areaCode + "-" + next + "-" + last;
                var customer = CustomerDal.GetCustomerByPhone(validPhone);
                this.Customers.Clear();
                this.Customers = customer.ToList();
                this.populateGridViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid number without - ");
            }
        }
        else
        {
            var firstName = this.firstNameSearchTextBox.Text;
            var lastName = this.lastNameSearchTextBox.Text;

            var customer = CustomerDal.GetCustomerByName(firstName, lastName);

            this.Customers.Clear();
            this.Customers = customer.ToList();
            this.populateGridViews();

        }
    }
    private void resetCustomerButton_Click(object sender, EventArgs e)
    {
        this.Customers.Clear();
        this.Customers = CustomerDal.GetAllCustomers();
        this.populateGridViews();
    }

    private void employeeSearchButton_Click(object sender, EventArgs e)
    {
        if (this.employeeNumRadioButton.Checked)
        {
            try
            {
                var employeeNum = int.Parse(this.employeeNumTextBox.Text);
                var employees = EmployeeDal.GetEmployeeByEmployeeNum(employeeNum);
                this.Employees.Clear();
                this.Employees = employees.ToList();
                this.populateGridViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a postive number");
            }

        }
        else if (this.employeePhoneRadioButton.Checked)
        {
            var phoneValue = this.employeePhoneTextBox.Text;
            var value = phoneValue.Replace("-", "");
            try
            {
                var areaCode = value.Substring(0, 3);
                var next = value.Substring(3, 3);
                var last = value.Substring(6, 4);
                var validPhone = areaCode + "-" + next + "-" + last;
                var employee = EmployeeDal.GetEmployeeByPhone(validPhone);
                this.Employees.Clear();
                this.Employees = employee.ToList();
                this.populateGridViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid number without - ");
            }
        }
        else
        {
            var firstName = this.employeeFnameTextBox.Text;
            var lastName = this.employeeLnameTextBox.Text;

            var employee = EmployeeDal.GetEmployeeByName(firstName, lastName);

            this.Employees.Clear();
            this.Employees = employee.ToList();
            this.populateGridViews();

        }
    }
    private void resetEmployeeButton_Click(object sender, EventArgs e)
    {
        this.Employees.Clear();
        this.Employees = EmployeeDal.GetAllEmployees();
        this.populateGridViews();
    }

    private void dashboardTabs_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedTab = this.dashboardTabs.SelectedTab;

        if (selectedTab == this.employeesTab)
        {
            this.furnitureGridView.ClearSelection();
            this.customerGridView.ClearSelection();
        }
        else if (selectedTab == this.customersTab)
        {
            this.furnitureGridView.ClearSelection();
            this.employeeGridView.ClearSelection();
        }
        else
        {
            this.customerGridView.ClearSelection();
            this.employeeGridView.ClearSelection();
        }
    }

    private void rentButton_Click(object sender, EventArgs e)
    {
        var rentalForm = new RentalForm(this.LoggedInEmployee, this.SelectedCustomer);
        rentalForm.StartPosition = FormStartPosition.Manual;
        rentalForm.Left = Left + (Width - rentalForm.Width) / 2;
        rentalForm.Top = Top + (Height - rentalForm.Height) / 2;
        rentalForm.ShowDialog();
    }

    private void returnButton_Click(object sender, EventArgs e)
    {
        var returnForm = new ReturnForm(this.LoggedInEmployee, this.SelectedCustomer);
        returnForm.StartPosition = FormStartPosition.Manual;
        returnForm.Left = Left + (Width - returnForm.Width) / 2;
        returnForm.Top = Top + (Height - returnForm.Height) / 2;

        try
        {
            returnForm.ShowDialog();
        }
        catch (ObjectDisposedException ex)
        {
            // This helps catch if there was any rentals for the user selected.
        }
    }

    private void adminTableButton_Click(object sender, EventArgs e)
    {
        var toolSelectorForm = new AdminToolSelectorForm();
        toolSelectorForm.StartPosition = FormStartPosition.Manual;
        toolSelectorForm.Left = Left + (Width - toolSelectorForm.Width) / 2;
        toolSelectorForm.Top = Top + (Height - toolSelectorForm.Height) / 2;
        toolSelectorForm.ShowDialog();
    }
    #endregion

}