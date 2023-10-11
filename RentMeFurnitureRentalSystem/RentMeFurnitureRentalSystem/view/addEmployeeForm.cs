namespace RentMeFurnitureRentalSystem.view;

public partial class addEmployeeForm : Form
{
    #region Constructors

    public addEmployeeForm()
    {
        this.InitializeComponent();
    }

    #endregion

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {

    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        var mainWindowForm = new MainScreenForm();
        mainWindowForm.ShowDialog();
        this.Close();
    }
}