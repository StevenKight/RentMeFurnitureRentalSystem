using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.view;
/// <summary>
/// Represents the return receipt form
/// </summary>
public partial class ReturnReceiptForm : Form
{
    #region Data members

    private List<Furniture> Furniture;

    #endregion

    #region Constructors
    /// <summary>
    /// Returns a new instance of ReturnReceiptForm
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
        var receiptReturn = RentalDAL.GetReturnById(returnId);
        var customer = CustomerDal.GetCustomerByMemberID(receiptReturn.Member_id).ElementAt(0);
        var returnItems = RentalDAL.GetReturnItems(returnId);
        var returnTotal = RentalDAL.GetReturnTotal(returnId);
        this.Furniture = returnItems;

        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<ID>", returnId.ToString());
        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<USER>", customer.Fullname);

        this.totalTextBox.Text = this.totalTextBox.Text.Replace("<TOTAL>", returnTotal.ToString());

        this.furnitureGridView.DataSource = this.Furniture;

        var itemCount = this.Furniture.Sum(x => x.Quantity);
        this.itemCountTextBox.Text = this.itemCountTextBox.Text.Replace("<ITEM_COUNT>", itemCount.ToString());
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}