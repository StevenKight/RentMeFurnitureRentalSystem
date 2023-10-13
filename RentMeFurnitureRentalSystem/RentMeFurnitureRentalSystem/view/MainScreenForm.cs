﻿using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.view;

namespace RentMeFurnitureRentalSystem;

public partial class MainScreenForm : Form
{
    #region properties
    public Employee LoggedInEmployee { get; set; }
    

    #endregion
    #region Constructors

    public MainScreenForm(Employee employee)
    {
        this.InitializeComponent();

        var screenWidth = Screen.PrimaryScreen.Bounds.Width;
        var screenHeight = Screen.PrimaryScreen.Bounds.Height;

        StartPosition = FormStartPosition.Manual;
        var x = (screenWidth - Width) / 2;
        var y = (screenHeight - Height) / 2;
        Location = new Point(x, y);
        this.LoggedInEmployee = employee;
        this.employeeLabel.Text = employee.EmployeeNum + ": " + employee.Firstname;
        this.checkIfAdmin();

    }

    #endregion

    #region Methods

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        var addEmployeeForm = new addUserForm(true);
        addEmployeeForm.StartPosition = FormStartPosition.Manual;
        addEmployeeForm.Left = Left + (Width - addEmployeeForm.Width) / 2;
        addEmployeeForm.Top = Top + (Height - addEmployeeForm.Height) / 2;

        addEmployeeForm.ShowDialog();
    }

    private void addCustomerButton_Click(object sender, EventArgs e)
    {
        var addCustomerForm = new addUserForm(false);
        addCustomerForm.StartPosition = FormStartPosition.Manual;
        addCustomerForm.Left = this.Left + (this.Width - addCustomerForm.Width) / 2;
        addCustomerForm.Top = this.Top + (this.Height - addCustomerForm.Height) / 2;

        addCustomerForm.ShowDialog();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        Hide();
        var loginForm = new Form1();
        loginForm.ShowDialog();
        Close();
    }

    private void checkIfAdmin()
    {
        if (!this.LoggedInEmployee.Role.Equals("administrator"))
        {
            this.addEmployeeButton.Enabled = false;
            this.addEmployeeButton.Hide();
        }
    }

    #endregion
}