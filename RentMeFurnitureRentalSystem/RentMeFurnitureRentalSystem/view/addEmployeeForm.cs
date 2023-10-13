using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.view;

public partial class addEmployeeForm : Form
{
    #region Constructors

    public addEmployeeForm()
    {
        this.InitializeComponent();
        this.EmployeeDal = new EmployeeDAL();
        this.LoginDal = new LoginDAL();
        this.RolesDal = new RolesDal();
        this.populateGenderComboBox();
        this.populateStateComboBox();
        this.populateRolesComboBox();
    }

    #endregion

    #region Methods

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        var username = this.usernameInput.Text;
        var password = this.passwordInput.Text;
        var firstName = this.firstnameInput.Text;
        var lastName = this.lastnameInput.Text;
        var gender = this.genderComboBox.Text;
        var dob = this.dobTimePicker.Value.Date;
        var phone = this.phoneInput.Text;
        var email = this.emailInput.Text;
        var streetAddress = this.streetAdressInput.Text;
        var city = this.cityInput.Text;
        var state = this.stateComboBox.Text;
        var zipcode = this.zipcodeInput.Text;
        var role = this.roleComboBox.Text;
        var login = new Login
        {
            Username = username,
            Password = password
        };
        if (!this.LoginDal.CreateLogin(login))
        {
            MessageBox.Show("Error Creating Login");
            return;
        }

        var employee = new Employee
        {
            Username = login.Username,
            Password = login.Password,
            Address = streetAddress,
            City = city,
            State = state,
            Zipcode = zipcode,
            Phone = phone,
            email = email,
            Firstname = firstName,
            Lastname = lastName,
            Gender = gender,
            Dob = dob,
            Role = role
        };
        if (!this.EmployeeDal.CreateEmployee(employee))
        {
            MessageBox.Show("Error Creating employee");
            return;
        }

        MessageBox.Show("Employee created sucessfully");
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Hide();
        Close();
    }

    private void populateGenderComboBox()
    {
        this.genderComboBox.Items.Clear();
        string[] values =
        {
            "Male",
            "Female",
            "Other"
        };
        this.genderComboBox.Items.AddRange(values);
    }

    private void populateRolesComboBox()
    {
        this.roleComboBox.Items.Clear();
        var roles = this.RolesDal.GetRoles();

        this.roleComboBox.Items.AddRange(roles.ToArray());
    }

    private void populateStateComboBox()
    {
        this.stateComboBox.Items.Clear();
        string[] stateNames =
        {
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

    #endregion

    #region props

    public LoginDAL LoginDal;

    public EmployeeDAL EmployeeDal;

    public RolesDal RolesDal;

    #endregion
}