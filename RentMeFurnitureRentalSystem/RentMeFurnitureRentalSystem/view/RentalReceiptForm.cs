using System.ComponentModel;
using System.IO.Pipelines;
using System.Text.RegularExpressions;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.view;

public partial class RentalReceiptForm : Form
{
    private List<Furniture> Furniture;

    #region Constructors

    public RentalReceiptForm(int rentalId)
    {

        this.InitializeComponent();

        this.loadData(rentalId);
    }

    #endregion

    private void loadData(int rentalId)
    {
        var rental = RentalDAL.GetRentalById(rentalId);
        var customer = CustomerDal.GetCustomerById(rental.Member_id);
        var rentalItems = RentalDAL.GetRentalItems(rentalId);
        var rentalTotal = RentalDAL.GetRentalTotal(rentalId);
        this.Furniture = FurnitureDAL.GetFurniture().Where(piece => piece.Quantity > 0).ToList();

        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<ID>", rentalId.ToString());
        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<USER>", customer.Fullname);

        this.totalTextBox.Text = this.totalTextBox.Text.Replace("<TOTAL>", rentalTotal.ToString());

        this.dueDateTextBox.Text = this.dueDateTextBox.Text.Replace("<DUE_DATE>", rental.Due_date.ToShortDateString());
        this.Furniture = this.Furniture.Where(x =>
        {
            if (rentalItems.Any(y => y.Furniture_id == x.Furniture_id))
            {
                var rentalItem = rentalItems.Find(y => y.Furniture_id == x.Furniture_id);
                x.Quantity = rentalItem.Quantity;
                return true;
            }

            return false;
        }).ToList();

        this.furnitureGridView.DataSource = this.Furniture;

        var itemCount = this.Furniture.Sum(x => x.Quantity);
        this.itemCountTextBox.Text = this.itemCountTextBox.Text.Replace("<ITEM_COUNT>", itemCount.ToString());
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        // TODO: if back continue result, else close

        MessageBox.Show("Successfully rented.");
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}