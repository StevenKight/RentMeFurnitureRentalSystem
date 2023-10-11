using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentMeFurnitureRentalSystem;

public partial class Form1 : Form
{

    #region Constructors

    public Form1()
    {
        this.InitializeComponent();

        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        this.StartPosition = FormStartPosition.Manual;
        int x = (screenWidth - this.Width) / 2;
        int y = (screenHeight - this.Height) / 2;
        this.Location = new Point(x, y);
    }

    #endregion

    #region Methods

    private void loginButton_Click(object sender, EventArgs e)
    {
        var username = this.usernameInput.Text;
        var password = this.passwordInput.Text;
        
        if (this.checkCredentials(username, password))
        {
            this.displayDashboard();
        }
        else
        {
            MessageBox.Show("Invalid Credentials");
        }
    }
    
    private void displayDashboard()
    {
        var mainWindow = new MainScreenForm();

        this.usernameInput.Text = "";
        this.passwordInput.Text = "";
        this.Hide();
        
        DialogResult result = mainWindow.ShowDialog();

        if (result == DialogResult.Continue) this.Show();
        else this.Close();
    }

    private bool checkCredentials(string username, string password)
    {
        //TODO swap this with a check to the DB for a employee
        var tempUsername = "username";
        var tempPassword = "password";
        return username.Equals(tempUsername) && password.Equals(tempPassword);
    }
    #endregion
}