using System.Diagnostics;

namespace RentMeFurnitureRentalSystem.view;

public partial class addEmployeeForm : Form
{
    #region Constructors

    public addEmployeeForm()
    {
        this.InitializeComponent();
        this.populateGenderComboBox();
        this.populateStateComboBox();
    }

    #endregion

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