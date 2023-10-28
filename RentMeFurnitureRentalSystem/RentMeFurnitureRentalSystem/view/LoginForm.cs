using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem;

public partial class Form1 : Form
{
    #region Constructors

    public Form1()
    {
        InitializeComponent();

        var screenWidth = Screen.PrimaryScreen.Bounds.Width;
        var screenHeight = Screen.PrimaryScreen.Bounds.Height;

        StartPosition = FormStartPosition.Manual;
        var x = (screenWidth - Width) / 2;
        var y = (screenHeight - Height) / 2;
        Location = new Point(x, y);

        errorTextBox.Hide();
    }

    #endregion

    private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        passwordInput.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
    }

    #region Methods

    private void loginButton_Click(object sender, EventArgs e)
    {
        var username = usernameInput.Text;
        var password = passwordInput.Text;

        if (!checkCredentials(username, password))
        {
            errorTextBox.Show();
        }
        else
        {
            loginErrorProvider.Clear();
            errorTextBox.Hide();

            var loggedInEmployee = EmployeeDal.GetEmployeeFromUsername(username);

            displayDashboard(loggedInEmployee);
        }
    }

    private void displayDashboard(Employee employee)
    {
        var mainWindow = new MainScreenForm(employee);

        usernameInput.Text = "";
        passwordInput.Text = "";
        Hide();

        var result = mainWindow.ShowDialog();

        if (result == DialogResult.Continue)
            Show();
        else
            Close();
    }

    private bool checkCredentials(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            loginErrorProvider.SetError(usernameInput, "Username and Password cannot be empty");
            loginErrorProvider.SetError(passwordInput, "Username and Password cannot be empty");
            return false;
        }

        var loginInfo = LoginDal.CheckLogin(username);

        if (username.Equals(loginInfo.Username) && password.Equals(loginInfo.Password)) return true;

        loginErrorProvider.SetError(usernameInput, "Username and/or Password is incorrect.");
        loginErrorProvider.SetError(passwordInput, "Username and/or Password is incorrect.");
        return false;
    }

    #endregion
}