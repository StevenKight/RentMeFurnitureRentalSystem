using Microsoft.AspNetCore.Identity;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.Model;
using RentMeFurnitureRentalSystem.Utils;

namespace RentMeFurnitureRentalSystem.View;

/// <summary>
///     Form for the login screen
/// </summary>
public partial class Form1 : Form
{
    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="Form1" /> class.
    /// </summary>
    public Form1()
    {
        this.InitializeComponent();

        var screenWidth = Screen.PrimaryScreen.Bounds.Width;
        var screenHeight = Screen.PrimaryScreen.Bounds.Height;

        StartPosition = FormStartPosition.Manual;
        var x = (screenWidth - Width) / 2;
        var y = (screenHeight - Height) / 2;
        Location = new Point(x, y);

        this.errorTextBox.Hide();
    }

    #endregion

    #region Methods

    private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        this.passwordInput.UseSystemPasswordChar = !this.showPasswordCheckBox.Checked;
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        var username = this.usernameInput.Text;
        var password = this.passwordInput.Text;

        if (!this.checkCredentials(username, password))
        {
            this.errorTextBox.Show();
        }
        else
        {
            this.loginErrorProvider.Clear();
            this.errorTextBox.Hide();

            var loggedInEmployee = EmployeeDal.GetEmployeeFromUsername(username);

            this.displayDashboard(loggedInEmployee);
        }
    }

    private void displayDashboard(Employee employee)
    {
        var mainWindow = new MainScreenForm(employee);
        mainWindow.StartPosition = FormStartPosition.Manual;
        mainWindow.Left = Left + (Width - mainWindow.Width) / 2;
        mainWindow.Top = Top + (Height - mainWindow.Height) / 2;

        this.usernameInput.Text = "";
        this.passwordInput.Text = "";
        Hide();

        var result = mainWindow.ShowDialog();

        if (result == DialogResult.Continue)
        {
            Show();
        }
        else
        {
            Close();
        }
    }

    private bool checkCredentials(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            this.loginErrorProvider.SetError(this.usernameInput, "Username and Password cannot be empty");
            this.loginErrorProvider.SetError(this.passwordInput, "Username and Password cannot be empty");
            return false;
        }

        var loginInfo = LoginDal.CheckLogin(username);

        if (username.Equals(loginInfo.Username) && PasswordHasher.CheckHashedPassword(loginInfo.Password, password) ==
            PasswordVerificationResult.Success)
        {
            return true;
        }

        this.loginErrorProvider.SetError(this.usernameInput, "Username and/or Password is incorrect.");
        this.loginErrorProvider.SetError(this.passwordInput, "Username and/or Password is incorrect.");
        return false;
    }

    private void forgotPasswordButton_Click(object sender, EventArgs e)
    {
        var changepasswordForm = new ChangePasswordForm();
        changepasswordForm.ShowDialog();
    }

    #endregion
}