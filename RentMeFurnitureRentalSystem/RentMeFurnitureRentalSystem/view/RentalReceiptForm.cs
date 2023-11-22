﻿using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.view;

public partial class RentalReceiptForm : Form
{
    #region Data members

    private List<Furniture> Furniture;

    #endregion

    #region Constructors

    public RentalReceiptForm(int rentalId)
    {
        this.InitializeComponent();

        this.loadData(rentalId);
    }

    #endregion

    #region Methods

    private void loadData(int rentalId)
    {
        var rental = RentalDAL.GetRentalById(rentalId);
        var customer = CustomerDal.GetCustomerByMemberID(rental.Member_id).ElementAt(0);
        var rentalItems = RentalDAL.GetRentalItems(rentalId);
        var rentalTotal = RentalDAL.GetRentalTotal(rentalId);
        this.Furniture = rentalItems;

        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<ID>", rentalId.ToString());
        this.titleTextBox.Text = this.titleTextBox.Text.Replace("<USER>", customer.Fullname);

        this.totalTextBox.Text = this.totalTextBox.Text.Replace("<TOTAL>", rentalTotal.ToString());

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