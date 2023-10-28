using System.ComponentModel;
using System.Text.RegularExpressions;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.view;

public partial class addUserForm : Form
{
    private void zipcodeInput_Validating(object sender, CancelEventArgs e)
    {
        var zip = zipcodeInput.Text;

        if (!Regex.IsMatch(zip, ZIPREGEX))
        {
            e.Cancel = true;
            addUserError.SetError(zipcodeInput,
                "Given zipcode is invalid.");
        }
        else
        {
            e.Cancel = false;
            addUserError.SetError(zipcodeInput, "");
        }
    }

    #region Data members

    public const string EMAILREGEX = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
    public const string PHONEREGEXNODASH = @"^[0-9]{3}[0-9]{3}[0-9]{4}$";
    public const string ZIPREGEX = @"^[0-9]{5}(?:-[0-9]{4})?$";

    #endregion

    #region Constructors

    public addUserForm(bool employee)
    {
        initializeDisplay();

        if (employee)
            displayEmployeeData();
        else
            displayCustomerData();
    }

    public addUserForm(Customer customer)
    {
        initializeDisplay();
        displayCustomerData();

        addButton.Enabled = false;
        addButton.Hide();

        fillDialog(customer);

        cancelButton.Text = "Close";
    }

    public addUserForm(Employee employee)
    {
        initializeDisplay();
        displayEmployeeData();

        addButton.Enabled = false;
        addButton.Hide();

        fillDialog(employee);

        cancelButton.Text = "Close";
    }

    #endregion

    #region Methods

    private void fillDialog(Customer customer)
    {
        firstnameInput.Text = customer.Fname;
        lastnameInput.Text = customer.Lname;
        emailInput.Text = customer.Email;
        phoneInput.Text = customer.Phone;
        genderComboBox.Text = customer.Gender;
        dobTimePicker.Value = customer.Dob;
        streetAdressInput.Text = customer.Address;
        zipcodeInput.Text = customer.Zip;
        cityInput.Text = customer.City;
        stateComboBox.Text = customer.State;
    }

    private void fillDialog(Employee employee)
    {
        usernameInput.Text = employee.Username;
        passwordInput.Text = employee.Password;
        firstnameInput.Text = employee.Fname;
        lastnameInput.Text = employee.Lname;
        emailInput.Text = employee.Email;
        phoneInput.Text = employee.Phone;
        genderComboBox.Text = employee.Gender;
        dobTimePicker.Value = employee.Dob;
        streetAdressInput.Text = employee.Address;
        zipcodeInput.Text = employee.Zip;
        cityInput.Text = employee.City;
        stateComboBox.Text = employee.State;
        roleComboBox.Text = employee.Role_name;
    }

    private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        passwordInput.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
    }

    private void initializeDisplay()
    {
        InitializeComponent();
        AutoValidate = AutoValidate.EnableAllowFocusChange;
        populateGenderComboBox();
        populateStateComboBox();
    }

    private void displayEmployeeData()
    {
        usernameLabel.Show();
        usernameInput.Show();
        usernameInput.Validating += textInput_Validating;

        passwordLabel.Show();
        passwordInput.Show();
        passwordInput.Validating += textInput_Validating;

        roleLabel.Show();
        roleComboBox.Show();
        roleComboBox.Validating += roleComboBox_Validating;
        var roles = RolesDal.GetRoles();
        roleComboBox.DataSource = roles;

        addDialogHeading.Text = "Add Employee";
        addButton.Click += addEmployeeButton_Click;
        addButton.Text = "Add Employee";
    }

    private void displayCustomerData()
    {
        usernameLabel.Hide();
        usernameInput.Hide();
        usernameInput.Enabled = false;
        usernameInput.Validating -= textInput_Validating;

        passwordLabel.Hide();
        passwordInput.Hide();
        passwordInput.Enabled = false;
        passwordInput.Validating -= textInput_Validating;
        showPasswordCheckBox.Hide();

        roleLabel.Hide();
        roleComboBox.Hide();
        roleComboBox.Enabled = false;
        roleComboBox.Validating -= roleComboBox_Validating;

        addDialogHeading.Text = "Add Customer";
        addButton.Click += addCustomerButton_Click;
        addButton.Text = "Add Customer";
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
            Fname = firstnameInput.Text,
            Lname = lastnameInput.Text,
            Gender = genderComboBox.Text,
            Email = emailInput.Text,
            Dob = dobTimePicker.Value.Date,
            Phone = phoneInput.Text,
            Address = streetAdressInput.Text,
            City = cityInput.Text,
            State = stateComboBox.Text,
            Zip = zipcodeInput.Text
        };


        if (!CustomerDal.CreateCustomer(customer))
        {
            MessageBox.Show("Error Adding Customer");
            return;
        }

        MessageBox.Show("Customer Added");
        Close();
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
            Username = usernameInput.Text,
            Password = passwordInput.Text
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
            Fname = firstnameInput.Text,
            Lname = lastnameInput.Text,
            Gender = genderComboBox.Text,
            Email = emailInput.Text,
            Dob = dobTimePicker.Value.Date,
            Phone = phoneInput.Text,
            Address = streetAdressInput.Text,
            City = cityInput.Text,
            State = stateComboBox.Text,
            Zip = zipcodeInput.Text,
            Role_name = roleComboBox.Text
        };
        if (!EmployeeDal.CreateEmployee(employee))
        {
            MessageBox.Show("Error Creating employee");
            return;
        }

        MessageBox.Show("Employee created sucessfully");
        Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        AutoValidate = AutoValidate.Disable;
        Close();
    }

    private void populateGenderComboBox()
    {
        genderComboBox.Items.Clear();
        genderComboBox.DataSource = genderOptions;
    }

    private void populateStateComboBox()
    {
        stateComboBox.Items.Clear();
        stateComboBox.DataSource = stateOptions;
    }

    private void textInput_Validating(object sender, CancelEventArgs e)
    {
        var inputBox = sender as TextBox;

        if (string.IsNullOrEmpty(inputBox.Text))
        {
            e.Cancel = true;
            addUserError.SetError(inputBox, "Field should not be left blank!");
        }
        else
        {
            e.Cancel = false;
            addUserError.SetError(inputBox, "");
        }
    }

    private void emailInput_Validating(object sender, CancelEventArgs e)
    {
        var value = emailInput.Text;

        if (!Regex.IsMatch(value, EMAILREGEX))
        {
            e.Cancel = true;
            addUserError.SetError(emailInput, "Email should match format of 'test@example.com'.");
        }
        else
        {
            e.Cancel = false;
            addUserError.SetError(emailInput, "");
        }
    }

    private void phoneInput_Validating(object sender, CancelEventArgs e)
    {
        var value = phoneInput.Text;
        value = value.Replace("-", "");

        if (!Regex.IsMatch(value, PHONEREGEXNODASH))
        {
            e.Cancel = true;
            addUserError.SetError(phoneInput,
                "Phone number should have 10 digits and no other characters other than '-'.");
        }
        else
        {
            e.Cancel = false;
            addUserError.SetError(phoneInput, "");

            var areaCode = value.Substring(0, 3);
            var next = value.Substring(3, 3);
            var last = value.Substring(6, 4);

            phoneInput.Text = areaCode + "-" + next + "-" + last;
        }
    }

    private void genderComboBox_Validating(object sender, CancelEventArgs e)
    {
        if (!genderOptions.Contains(genderComboBox.Text))
        {
            e.Cancel = true;
            addUserError.SetError(genderComboBox, "Gender must match one of the given options.");
        }
        else
        {
            e.Cancel = false;
            addUserError.SetError(genderComboBox, "");
        }
    }

    private void stateComboBox_Validating(object sender, CancelEventArgs e)
    {
        if (!stateOptions.Contains(stateComboBox.Text))
        {
            e.Cancel = true;
            addUserError.SetError(stateComboBox, "State must match one of the given options.");
        }
        else
        {
            e.Cancel = false;
            addUserError.SetError(stateComboBox, "");
        }
    }

    private void roleComboBox_Validating(object sender, CancelEventArgs e)
    {
        if (!roleOptions.Contains(roleComboBox.Text))
        {
            e.Cancel = true;
            addUserError.SetError(roleComboBox, "Role_name must match one of the given options.");
        }
        else
        {
            e.Cancel = false;
            addUserError.SetError(roleComboBox, "");
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
    private static readonly string[] roleOptions = { "administrator", "employee" };

    #endregion
}