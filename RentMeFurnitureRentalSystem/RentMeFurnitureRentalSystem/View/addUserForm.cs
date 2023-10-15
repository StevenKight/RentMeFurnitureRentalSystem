using System.ComponentModel;
using System.Text.RegularExpressions;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.view;

public partial class addUserForm : Form
{
    #region Data members

    public const string EMAILREGEX = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
    public const string PHONEREGEXNODASH = @"^[0-9]{3}[0-9]{3}[0-9]{4}$";

    #endregion

    #region Constructors

    public addUserForm(bool employee)
    {
        this.initializeDisplay();

        if (employee)
        {
            this.displayEmployeeData();
        }
        else
        {
            this.displayCustomerData();
        }
    }

    public addUserForm(Customer customer)
    {
        this.initializeDisplay();
        this.displayCustomerData();

        this.addButton.Enabled = false;
        this.addButton.Hide();

        this.fillDialog(customer);

        this.cancelButton.Text = "Close";
    }

    public addUserForm(Employee employee)
    {
        this.initializeDisplay();
        this.displayEmployeeData();

        this.addButton.Enabled = false;
        this.addButton.Hide();

        this.fillDialog(employee);

        this.cancelButton.Text = "Close";
    }

    #endregion

    #region Methods

    private void fillDialog(Customer customer)
    {
        this.firstnameInput.Text = customer.Firstname;
        this.lastnameInput.Text = customer.Lastname;
        this.emailInput.Text = customer.Email;
        this.phoneInput.Text = customer.Phone;
        this.genderComboBox.Text = customer.Gender;
        this.dobTimePicker.Value = customer.Birthday;
        this.streetAdressInput.Text = customer.StreetAddress;
        this.zipcodeInput.Text = customer.Zipcode;
        this.cityInput.Text = customer.City;
        this.stateComboBox.Text = customer.State;
    }

    private void fillDialog(Employee employee)
    {
        this.usernameInput.Text = employee.Username;
        this.passwordInput.Text = employee.Password;
        this.firstnameInput.Text = employee.Firstname;
        this.lastnameInput.Text = employee.Lastname;
        this.emailInput.Text = employee.Email;
        this.phoneInput.Text = employee.Phone;
        this.genderComboBox.Text = employee.Gender;
        this.dobTimePicker.Value = employee.Dob;
        this.streetAdressInput.Text = employee.Address;
        this.zipcodeInput.Text = employee.Zipcode;
        this.cityInput.Text = employee.City;
        this.stateComboBox.Text = employee.State;
        this.roleComboBox.Text = employee.Role;
    }
    private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        this.passwordInput.UseSystemPasswordChar = !this.showPasswordCheckBox.Checked;
    }

    private void initializeDisplay()
    {
        this.InitializeComponent();
        AutoValidate = AutoValidate.EnableAllowFocusChange;
        this.populateGenderComboBox();
        this.populateStateComboBox();
    }

    private void displayEmployeeData()
    {
        this.usernameLabel.Show();
        this.usernameInput.Show();
        this.usernameInput.Validating += this.textInput_Validating;

        this.passwordLabel.Show();
        this.passwordInput.Show();
        this.passwordInput.Validating += this.textInput_Validating;

        this.roleLabel.Show();
        this.roleComboBox.Show();
        this.roleComboBox.Validating += this.roleComboBox_Validating;
        var roles = RolesDal.GetRoles();
        this.roleComboBox.DataSource = roles;

        this.addDialogHeading.Text = "Add Employee";
        this.addButton.Click += this.addEmployeeButton_Click;
        this.addButton.Text = "Add Employee";
    }

    private void displayCustomerData()
    {
        this.usernameLabel.Hide();
        this.usernameInput.Hide();
        this.usernameInput.Enabled = false;
        this.usernameInput.Validating -= this.textInput_Validating;

        this.passwordLabel.Hide();
        this.passwordInput.Hide();
        this.passwordInput.Enabled = false;
        this.passwordInput.Validating -= this.textInput_Validating;

        this.roleLabel.Hide();
        this.roleComboBox.Hide();
        this.roleComboBox.Enabled = false;
        this.roleComboBox.Validating -= this.roleComboBox_Validating;

        this.addDialogHeading.Text = "Add Customer";
        this.addButton.Click += this.addCustomerButton_Click;
        this.addButton.Text = "Add Customer";
    }

    private void addCustomerButton_Click(object sender, EventArgs e)
    {
        if (!ValidateChildren(ValidationConstraints.Enabled))
        {
            MessageBox.Show("Please fix errors before submitting");
            return;
        }

        var customer = new Customer
        {
            Firstname = this.firstnameInput.Text,
            Lastname = this.lastnameInput.Text,
            Gender = this.genderComboBox.Text,
            Email = this.emailInput.Text,
            Birthday = this.dobTimePicker.Value.Date,
            Phone = this.phoneInput.Text,
            StreetAddress = this.streetAdressInput.Text,
            City = this.cityInput.Text,
            State = this.stateComboBox.Text,
            Zipcode = this.zipcodeInput.Text
        };

        // TODO: Add Customer
        try
        {
            var added = CustomerDal.CreateCustomer(customer);

            if (!added)
            {
                throw new Exception("User not added");
            }

            MessageBox.Show("Customer Added");
            Close();
        }
        catch
        {
            MessageBox.Show("Error Adding Customer");
        }
    }

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        if (!ValidateChildren(ValidationConstraints.Enabled))
        {
            MessageBox.Show("Please fix errors before submitting");
            return;
        }

        var login = new Login
        {
            Username = this.usernameInput.Text,
            Password = this.passwordInput.Text
        };
        if (!LoginDal.CreateLogin(login))
        {
            MessageBox.Show("Error Creating Login");
            return;
        }

        var employee = new Employee
        {
            Username = login.Username,
            Password = login.Password,
            Firstname = this.firstnameInput.Text,
            Lastname = this.lastnameInput.Text,
            Gender = this.genderComboBox.Text,
            Email = this.emailInput.Text,
            Dob = this.dobTimePicker.Value.Date,
            Phone = this.phoneInput.Text,
            Address = this.streetAdressInput.Text,
            City = this.cityInput.Text,
            State = this.stateComboBox.Text,
            Zipcode = this.zipcodeInput.Text,
            Role = this.roleComboBox.Text
        };
        if (!EmployeeDal.CreateEmployee(employee))
        {
            MessageBox.Show("Error Creating employee");
            return;
        }

        MessageBox.Show("Employee created sucessfully");
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        AutoValidate = AutoValidate.Disable;
        Close();
    }

    private void populateGenderComboBox()
    {
        this.genderComboBox.Items.Clear();
        this.genderComboBox.DataSource = genderOptions;
    }

    private void populateStateComboBox()
    {
        this.stateComboBox.Items.Clear();
        this.stateComboBox.DataSource = stateOptions;
    }

    private void textInput_Validating(object sender, CancelEventArgs e)
    {
        var inputBox = sender as TextBox;

        if (string.IsNullOrEmpty(inputBox.Text))
        {
            e.Cancel = true;
            this.addUserError.SetError(inputBox, "Field should not be left blank!");
        }
        else
        {
            e.Cancel = false;
            this.addUserError.SetError(inputBox, "");
        }
    }

    private void emailInput_Validating(object sender, CancelEventArgs e)
    {
        var value = this.emailInput.Text;

        if (!Regex.IsMatch(value, EMAILREGEX))
        {
            e.Cancel = true;
            this.addUserError.SetError(this.emailInput, "Email should match format of 'test@example.com'.");
        }
        else
        {
            e.Cancel = false;
            this.addUserError.SetError(this.emailInput, "");
        }
    }

    private void phoneInput_Validating(object sender, CancelEventArgs e)
    {
        var value = this.phoneInput.Text;
        value = value.Replace("-", "");

        if (!Regex.IsMatch(value, PHONEREGEXNODASH))
        {
            e.Cancel = true;
            this.addUserError.SetError(this.phoneInput,
                "Phone number should have 10 digits and no other characters other than '-'.");
        }
        else
        {
            e.Cancel = false;
            this.addUserError.SetError(this.phoneInput, "");

            var areaCode = value.Substring(0, 3);
            var next = value.Substring(3, 3);
            var last = value.Substring(6, 4);

            this.phoneInput.Text = areaCode + "-" + next + "-" + last;
        }
    }

    private void genderComboBox_Validating(object sender, CancelEventArgs e)
    {
        if (!genderOptions.Contains(this.genderComboBox.Text))
        {
            e.Cancel = true;
            this.addUserError.SetError(this.genderComboBox, "Gender must match one of the given options.");
        }
        else
        {
            e.Cancel = false;
            this.addUserError.SetError(this.genderComboBox, "");
        }
    }

    private void stateComboBox_Validating(object sender, CancelEventArgs e)
    {
        if (!stateOptions.Contains(this.stateComboBox.Text))
        {
            e.Cancel = true;
            this.addUserError.SetError(this.stateComboBox, "State must match one of the given options.");
        }
        else
        {
            e.Cancel = false;
            this.addUserError.SetError(this.stateComboBox, "");
        }
    }

    private void roleComboBox_Validating(object sender, CancelEventArgs e)
    {
        if (!roleOptions.Contains(this.roleComboBox.Text))
        {
            e.Cancel = true;
            this.addUserError.SetError(this.roleComboBox, "Role must match one of the given options.");
        }
        else
        {
            e.Cancel = false;
            this.addUserError.SetError(this.roleComboBox, "");
        }
    }

    #endregion

    #region Data Members

    private static readonly string[] stateOptions =
    {
        "Alabama", "Alaska", "Arizona", "Arkansas", "California",
        "Colorado", "Connecticut", "Delaware", "Florida", "Georgia",
        "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa",
        "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland",
        "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri",
        "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey",
        "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio",
        "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
        "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
        "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"
    };

    private static readonly string[] genderOptions = { "O", "M", "F" };

    // TODO: Make a request to db
    private static readonly string[] roleOptions = { "admin", "employee" };

    #endregion
}