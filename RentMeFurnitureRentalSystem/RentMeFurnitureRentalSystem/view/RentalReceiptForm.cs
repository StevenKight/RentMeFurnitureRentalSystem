using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.View;

/// <summary>
///     Rental receipt form
/// </summary>
public partial class RentalReceiptForm : Form
{
    #region Data members

    private List<Furniture> furniture;

    #endregion

    #region Constructors

    /// <summary>
    ///     Constructor for the rental receipt form
    /// </summary>
    /// <param name="rentalId"></param>
    public RentalReceiptForm(int rentalId)
    {
        this.InitializeComponent();

        this.loadData(rentalId);
    }

    #endregion

    #region Methods

    private void loadData(int rentalId)
    {
        var rental = RentalDal.GetRentalById(rentalId);
        var customer = CustomerDal.GetCustomerByMemberId(rental.MemberId).ElementAt(0);
        var rentalItems = RentalDal.GetRentalItems(rentalId);
        var rentalTotal = RentalDal.GetRentalTotal(rentalId);
        this.furniture = rentalItems;

        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<ID>", rentalId.ToString());
        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<USER>", customer.Fullname);

        this.totalTextBox.Text = this.totalTextBox.Text.Replace("<TOTAL>", rentalTotal.ToString());

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