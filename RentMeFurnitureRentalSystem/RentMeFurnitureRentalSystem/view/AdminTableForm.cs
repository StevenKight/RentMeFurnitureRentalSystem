using RentMeFurnitureRentalSystem.DAL;

namespace RentMeFurnitureRentalSystem.View;

/// <summary>
///     AdminTableForm class
/// </summary>
public partial class AdminTableForm : Form
{
    #region Constructors

    /// <summary>
    ///     AdminTableForm constructor
    /// </summary>
    public AdminTableForm()
    {
        this.InitializeComponent();
    }

    #endregion

    #region Methods

    private void submitButton_Click(object sender, EventArgs e)
    {
        var sql = this.sqlTextArea.Text;

        if (string.IsNullOrEmpty(sql))
        {
            MessageBox.Show("Please enter Text");
            return;
        }

        var result = AdminSqldal.ReadStatement(sql);

        if (result != null)
        {
            this.resultDataView.DataSource = result;
        }
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        this.sqlTextArea.Clear();
    }

    private void returnScreenButton_Click(object sender, EventArgs e)
    {
        var tableForm = new AdminToolSelectorForm();

        tableForm.StartPosition = FormStartPosition.Manual;
        tableForm.Left = Left + (Width - tableForm.Width) / 2;
        tableForm.Top = Top + (Height - tableForm.Height) / 2;
        tableForm.Show();
        Close();
    }

    #endregion
}