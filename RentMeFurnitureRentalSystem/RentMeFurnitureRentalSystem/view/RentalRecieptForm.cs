﻿using System.ComponentModel;
using System.IO.Pipelines;
using System.Text.RegularExpressions;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.view;

public partial class RentalRecieptForm : Form
{
    private List<Customer> Customers;
    private List<Furniture> Furniture;

    private Employee employee;
    private Customer customer;

    #region Constructors

    public RentalRecieptForm(Employee employee, Customer customer)
    {
        this.employee = employee;
        this.customer = customer;

        this.InitializeComponent();

        this.loadData();
    }

    #endregion

    private void loadData()
    {
        this.Furniture = FurnitureDAL.GetFurniture().Where(piece => piece.Quantity > 0).ToList();
        this.Furniture.ForEach(x => x.Quantity = 0);

        this.furnitureGridView.DataSource = this.Furniture; ;
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        var selectedFurniture = this.Furniture.Where(x => x.Quantity > 0).ToList();

        if (selectedFurniture.Count <= 0)
        {
            this.errorProvider.SetError(this.furnitureGridView, "Please select at least one piece of furniture for the rental.");
        }

        var rental = new RentalItem()
        {
            Member_id = this.customer.Member_id,
            Employee_num = this.employee.Employee_num,
            Start_date = DateTime.Now.Date,
            Due_date = this.dueDateDateTimePicker.Value.Date
        };

        if (!RentalDAL.CreateRental(rental))
        {
            MessageBox.Show("Error creating rental transaction.");
            return;
        }

        foreach (var furniture in selectedFurniture)
        {
            var item = new RentalItem()
            {
                Member_id = rental.Member_id,
                Employee_num = rental.Employee_num,
                Start_date = rental.Start_date,
                Due_date = rental.Due_date,
                Furniture_id = furniture.Furniture_id,
                Quantity = furniture.Quantity
            };

            if (!RentalDAL.CreateRentalItem(item))
            {
                MessageBox.Show("Error adding " + furniture.Name + " to the transaction.");
                return;
            }
        }

        MessageBox.Show("Successfully rented.");

        // TODO: Open receipt as modal and hide self and if continue result, don't close, else close
    }
}