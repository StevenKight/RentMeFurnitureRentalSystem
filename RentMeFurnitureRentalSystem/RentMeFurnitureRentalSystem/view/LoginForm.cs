using System.Diagnostics;

namespace RentMeFurnitureRentalSystem;

public partial class Form1 : Form
{

    #region Constructors

    public Form1()
    {
        this.InitializeComponent();
    }

    #endregion

    #region Methods

    private void loginButton_Click(object sender, EventArgs e)
    {
        var username = this.usernameInput.Text;
        var password = this.passwordInput.Text;
        Debug.WriteLine(username);
        Debug.WriteLine(password);
        var mainWindow = new MainScreenForm();
        Hide();
        mainWindow.ShowDialog();
        
        
    }

    private bool checkCredentials(string username, string password)
    {
        //TODO swap this with a check to the DB for a employee
        var tempUsername = "username";
        var tempPassword = "password";
        if (username.Equals(tempUsername) && password.Equals(tempPassword))
        {
            return true;
        }
        return false;
    }
    #endregion
}