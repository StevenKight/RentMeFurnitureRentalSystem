using RentMeFurnitureRentalSystem.Model;
using System.Diagnostics;

namespace RentMeFurnitureRentalSystem.view;

public partial class addUserForm : Form
{
    #region Constructors

    public addUserForm(bool employee)
    {
        this.InitializeComponent();
        this.populateGenderComboBox();
        this.populateStateComboBox();

        if (employee) this.displayEmployeeData();
        else this.displayCustomerData();
    }

    #endregion

    private void displayEmployeeData()
    {
        this.usernameLabel.Show();
        this.usernameInput.Show();
        this.passwordLabel.Show();
        this.passwordInput.Show();
        this.roleLabel.Show();
        this.roleComboBox.Show();

        this.addDialogHeading.Text = "Add Employee";
        this.addButton.Click += this.addEmployeeButton_Click;
        this.addButton.Text = "Add Employee";

    }

    private void displayCustomerData()
    {
        this.usernameLabel.Hide();
        this.usernameInput.Hide();
        this.passwordLabel.Hide();
        this.passwordInput.Hide();
        this.roleLabel.Hide();
        this.roleComboBox.Hide();
        
        this.addDialogHeading.Text = "Add Customer";
        this.addButton.Click += this.addCustomerButton_Click;
        this.addButton.Text = "Add Customer";
    }

    private void addCustomerButton_Click(object sender, EventArgs e)
    {
        var customer = new Customer() {
            FirstName = this.firstnameInput.Text,
            LastName = this.lastnameInput.Text,
            Gender = this.genderComboBox.Text,
            Birthday = this.dobTimePicker.Value.Date,
            Phone = this.phoneInput.Text,
            StreetAddress = this.streetAdressInput.Text,
            City = this.cityInput.Text,
            State = this.stateComboBox.Text,
            Zipcode = int.Parse(this.zipcodeInput.Text)
        };

        // TODO: Add Customer
    }

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        var username = this.usernameInput.Text;
        var password = this.passwordInput.Text;
        var firstName = this.firstnameInput;
        var lastName = this.lastnameInput;
        var gender = this.genderComboBox.Text;
        var dob = this.dobTimePicker.Text;
        var phone = this.phoneInput.Text;
        var streetAddress = this.streetAdressInput;
        var city = this.cityInput;
        var state = this.stateComboBox.Text;
        var zipcode = this.zipcodeInput.Text;
        var role = this.roleComboBox.Text;

        // TODO: Add Employee
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void populateGenderComboBox()
    {
        this.genderComboBox.Items.Clear();
        string[] values = {
            "Male",
            "Female",
            "Other"
        };
        this.genderComboBox.Items.AddRange(values);
        

    }

    private void populateStateComboBox()
    {

        this.stateComboBox.Items.Clear();
        string[] stateNames = {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"
        };

        this.stateComboBox.Items.AddRange(stateNames);
    }
}