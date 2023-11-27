using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.View;

/// <summary>
///     Represents the return receipt form
/// </summary>
public partial class ReturnReceiptForm : Form
{
    #region Data members

    private List<Furniture> furniture;

    #endregion

    #region Constructors

    /// <summary>
    ///     Returns a new instance of ReturnReceiptForm
    /// </summary>
    /// <param name="returnId"></param>
    public ReturnReceiptForm(int returnId)
    {
        this.InitializeComponent();

        this.loadData(returnId);
    }

    #endregion

    #region Methods

    private void loadData(int returnId)
    {
        var receiptReturn = RentalDal.GetReturnById(returnId);
        var customer = CustomerDal.GetCustomerByMemberId(receiptReturn.Member_id).ElementAt(0);
        var returnItems = RentalDal.GetReturnItems(returnId);
        var returnTotal = RentalDal.GetReturnTotal(returnId);
        this.furniture = returnItems;

        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<ID>", returnId.ToString());
        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<USER>", customer.Fullname);

        this.totalTextBox.Text = this.totalTextBox.Text.Replace("<TOTAL>", returnTotal.ToString());

        this.furnitureGridView.DataSource = this.furniture;

        var itemCount = this.furniture.Sum(x => x.Quantity);
        this.itemCountTextBox.Text = this.itemCountTextBox.Text.Replace("<ITEM_COUNT>", itemCount.ToString());
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}