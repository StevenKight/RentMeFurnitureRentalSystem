using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.Utils;

namespace RentMeFurnitureRentalSystem.View;

/// <summary>
///     ChangePasswordForm class
/// </summary>
public partial class ChangePasswordForm : Form
{
    #region Constructors

    /// <summary>
    ///     The constructor for ChangePasswordForm
    /// </summary>
    public ChangePasswordForm()
    {
        this.InitializeComponent();
    }

    #endregion

    #region Methods

    private void submitButton_Click(object sender, EventArgs e)
    {
        var username = this.usernameTextBox.Text;

        var id = this.EmployeeIdTextBox.Text;

        var newPassword = this.NewPasswordTextBox.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(id) ||
            string.IsNullOrWhiteSpace(newPassword))
        {
            MessageBox.Show("Please fill in all fields");
        }
        else
        {
            if (!int.TryParse(id, out _))
            {
                MessageBox.Show("Employee ID must be a valid number");
            }
            else
            {
                var result = LoginDal.ChangeLogin(username, int.Parse(id), PasswordHasher.HashPassword(newPassword));
                if (result)
                {
                    MessageBox.Show("Changed Password");
                    Close();
                }
            }
        }
    }

    #endregion
}