namespace RentMeFurnitureRentalSystem.View;

/// <summary>
///     AdminToolSelectorForm form
/// </summary>
public partial class AdminToolSelectorForm : Form
{
    #region Constructors

    /// <summary>
    ///     AdminToolSelectorForm constructor
    /// </summary>
    public AdminToolSelectorForm()
    {
        this.InitializeComponent();
    }

    #endregion

    #region Methods

    private void adminSQLTableButton_Click(object sender, EventArgs e)
    {
        var tableForm = new AdminTableForm();
        tableForm.StartPosition = FormStartPosition.Manual;
        tableForm.Left = Left + (Width - tableForm.Width) / 2;
        tableForm.Top = Top + (Height - tableForm.Height) / 2;
        tableForm.ShowDialog();
        Close();
    }

    private void dateReportButton_Click(object sender, EventArgs e)
    {
        var reportForm = new DayToDayReportForm();
        reportForm.StartPosition = FormStartPosition.Manual;
        reportForm.Left = Left + (Width - reportForm.Width) / 2;
        reportForm.Top = Top + (Height - reportForm.Height) / 2;
        reportForm.ShowDialog();
        Close();
    }

    #endregion
}