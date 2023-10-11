﻿using RentMeFurnitureRentalSystem.view;

namespace RentMeFurnitureRentalSystem;

public partial class MainScreenForm : Form
{
    #region Constructors

    public MainScreenForm()
    {
        this.InitializeComponent();

        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        this.StartPosition = FormStartPosition.Manual;
        int x = (screenWidth - this.Width) / 2;
        int y = (screenHeight - this.Height) / 2;
        this.Location = new Point(x, y);
    }

    #endregion

    #region Methods

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        var addEmployeeForm = new addEmployeeForm();
        addEmployeeForm.StartPosition = FormStartPosition.Manual;
        addEmployeeForm.Left = this.Left + (this.Width - addEmployeeForm.Width) / 2;
        addEmployeeForm.Top = this.Top + (this.Height - addEmployeeForm.Height) / 2;

        addEmployeeForm.ShowDialog();
    }

    private void addCustomerButton_Click(object sender, EventArgs e)
    {
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        // TODO: Logout user
        this.DialogResult = DialogResult.Continue;
        this.Close();
    }

    #endregion


}