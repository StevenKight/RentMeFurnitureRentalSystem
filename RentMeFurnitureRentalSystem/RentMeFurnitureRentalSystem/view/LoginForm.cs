using RentMeFurnitureRentalSystem.DAL;

namespace RentMeFurnitureRentalSystem;

public partial class Form1 : Form
{



    #region Constructors

    public Form1()
    {
        this.InitializeComponent();

        var screenWidth = Screen.PrimaryScreen.Bounds.Width;
        var screenHeight = Screen.PrimaryScreen.Bounds.Height;

        StartPosition = FormStartPosition.Manual;
        var x = (screenWidth - Width) / 2;
        var y = (screenHeight - Height) / 2;
        Location = new Point(x, y);
    }

    #endregion

    #region Methods

    private void loginButton_Click(object sender, EventArgs e)
    {
        this.errorMessageLabel.Text = string.Empty;
        var username = this.usernameInput.Text;
        var password = this.passwordInput.Text;

        if (!this.checkCredentials(username, password))
        {
            this.errorMessageLabel.Text = @"Username or Password is incorrect";
        }
        else
        {

            this.displayDashboard();
        }
    }

    private void displayDashboard()
    {
        var mainWindow = new MainScreenForm();

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
        var loginDal = new LoginDAL();
        var loginInfo = loginDal.CheckLogin(username);

        if (username.Equals(loginInfo.Username) && password.Equals(loginInfo.Password))
        {
            return true;
        }

        return false;
    }

    #endregion
}