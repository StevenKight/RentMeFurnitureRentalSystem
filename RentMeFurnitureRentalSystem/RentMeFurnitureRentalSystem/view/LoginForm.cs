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
        var mainWindow = new MainScreenForm();
        Hide();
        mainWindow.ShowDialog();
    }

    #endregion
}