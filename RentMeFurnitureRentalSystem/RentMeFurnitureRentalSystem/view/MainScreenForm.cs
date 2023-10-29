using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;
using RentMeFurnitureRentalSystem.view;

namespace RentMeFurnitureRentalSystem;

public partial class MainScreenForm : Form
{

    #region Data Members

    public Employee LoggedInEmployee { get; set; }

    public List<Employee> Employees { get; set; }
    public List<Customer> Customers { get; set; }

    public List<Furniture> Furniture { get; set; }

    public Employee SelectedEmployee { get; set; }
    public Customer SelectedCustomer { get; set; }

    public Furniture SelectedFurniture { get; set; }

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
        this.employeeDisplay.Text = employee.Employee_num + " " + employee.Username + @": " +
                                    employee.Fname + " " + employee.Lname;
        this.checkIfAdmin();

        this.getData();

        this.setupGridViews();
    }

    #endregion

    #region Methods

    private void getData()
    {
        Employees = EmployeeDal.GetAllEmployees();
        Customers = CustomerDal.GetAllCustomers();
        Furniture = FurnitureDAL.GetFurniture().ToList();

        populateGridViews();
    }

    private void setupGridViews()
    {
        this.customerGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.customerGridView.Columns[0].HeaderText = "Name";
        this.customerGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.customerGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.customerGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.customerGridView.Columns[3].HeaderText = "Register Date";

        if (this.employeeGridView.Columns.Count <= 0)
        {
            return;
        }

        this.employeeGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.employeeGridView.Columns[0].HeaderText = "Name";
        this.employeeGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.employeeGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.employeeGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.employeeGridView.Columns[3].HeaderText = "Role";

        furnitureGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        furnitureGridView.Columns[0].HeaderText = "ID";
        furnitureGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        furnitureGridView.Columns[1].HeaderText = "Name";
        furnitureGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        furnitureGridView.Columns[2].HeaderText = "Description";
        furnitureGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        furnitureGridView.Columns[3].HeaderText = "Quantity";
        furnitureGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        furnitureGridView.Columns[4].HeaderText = "Style";
        furnitureGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        furnitureGridView.Columns[5].HeaderText = "Category";
    }

    private void populateGridViews()
    {
        customerGridView.DataSource = Customers.Select(customer =>
        {
            var FullName = customer.Fname + " " + customer.Lname;
            return new { FullName, customer.Phone, customer.Email, customer.Register_date };
        }).ToList();

        employeeGridView.DataSource = Employees.Select(employee =>
        {
            var FullName = employee.Fname + " " + employee.Lname;
            return new { FullName, employee.Phone, employee.Email, employee.Role_name };
        }).ToList();
        furnitureGridView.DataSource = Furniture.Select(furniture => new
        { Id = furniture.Furniture_id, furniture.Name, furniture.Description, furniture.Quantity, furniture.Style_name, furniture.Category_name }).ToList();
    }

    private void checkIfAdmin()
    {
        if (this.LoggedInEmployee.Role_name.Equals("administrator"))
        {
            return;
        }

        this.dashboardTabs.TabPages.Remove(this.employeesTab);
    }

    private void populateStyleAndCategoryComboBoxes()
    {
        this.categoryComboBox.Items.Clear();
        this.styleComboBox.Items.Clear();

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
        addFurnitureForm.Left = Left + (Width - addFurnitureForm.Width) / 2;
        addFurnitureForm.Top = Top + (Height - addFurnitureForm.Height) / 2;

        addFurnitureForm.ShowDialog();
        getData();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        this.LoggedInEmployee = null;
        DialogResult = DialogResult.Continue;
        Close();
    }

    private void customerGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected)
        {
            this.deleteCustomerButton.Enabled = false;
            return;
        }

        this.deleteCustomerButton.Enabled = true;

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
                var fullname = x.Fname + " " + x.Lname;
                return fullname.Equals(fullName) && x.Phone.Equals(phone) && x.Email.Equals(email);
            });

            this.SelectedCustomer = customer;
        }
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
            var selectedObject = selectedRows[0].DataBoundItem;
            var nameProperty = selectedObject.GetType().GetProperty("FullName");
            var fullName = (string)nameProperty?.GetValue(selectedObject, null);
            var phoneProperty = selectedObject.GetType().GetProperty("Phone");
            var phone = (string)phoneProperty?.GetValue(selectedObject, null);
            var emailProperty = selectedObject?.GetType().GetProperty("Email");
            var email = (string)emailProperty?.GetValue(selectedObject, null);

            var employee = this.Employees.Find(x =>
            {
                var fullname = x.Fname + " " + x.Lname;
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


    private void furnitureGridView_RowStateChanged(Object sender, DataGridViewRowStateChangedEventArgs e)
    {
        if (e.StateChanged != DataGridViewElementStates.Selected) return;

        var selectedRows = this.furnitureGridView.SelectedRows;
        if (selectedRows.Count > 0)
        {
            var selectedObject = selectedRows[0].DataBoundItem;
            var idProperty = selectedObject.GetType().GetProperty("ID");
            var id = (string)idProperty?.GetValue(selectedObject, null);
            var nameProperty = selectedObject.GetType().GetProperty("Name");
            var name = (string)nameProperty?.GetValue(selectedObject, null);
            var descriptionProperty = selectedObject.GetType().GetProperty("Description");
            var description = (string)descriptionProperty?.GetValue(selectedObject, null);
            var quantityProperty = selectedObject.GetType().GetProperty("Quanity");
            var quantity = (string)quantityProperty?.GetValue(selectedObject, null);

            var furniture = Furniture.Find(x => id.Equals(x.Furniture_id));
            SelectedFurniture = furniture;
        }
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

    private void dashboardTabs_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedTab = this.dashboardTabs.SelectedTab;

        if (selectedTab == this.employeesTab)
        {
            this.customerGridView.ClearSelection();
        }
        else
        {
            this.employeeGridView.ClearSelection();
        }
    }

    #endregion
}