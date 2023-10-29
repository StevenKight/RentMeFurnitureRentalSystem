﻿namespace RentMeFurnitureRentalSystem
{
    partial class MainScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.employeeDisplay = new System.Windows.Forms.TextBox();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.dashboardTabs = new System.Windows.Forms.TabControl();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.resetCustomerButton = new System.Windows.Forms.Button();
            this.customerSearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.firstNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.memberIdTextBox = new System.Windows.Forms.TextBox();
            this.memberIDRadioButton = new System.Windows.Forms.RadioButton();
            this.furnitureTabpage = new System.Windows.Forms.TabPage();
            this.resetButton = new System.Windows.Forms.Button();
            this.categoryRadioButton = new System.Windows.Forms.RadioButton();
            this.StyleRadioButton = new System.Windows.Forms.RadioButton();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.IdRadioButton = new System.Windows.Forms.RadioButton();
            this.furnitureSearchTextBox = new System.Windows.Forms.TextBox();
            this.furnitureSearchButton = new System.Windows.Forms.Button();
            this.addFurnitureButton = new System.Windows.Forms.Button();
            this.furnitureGridView = new System.Windows.Forms.DataGridView();
            this.employeesTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.dashboardTabs.SuspendLayout();
            this.customersTab.SuspendLayout();
            this.furnitureTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureGridView)).BeginInit();
            this.employeesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(6, 6);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(134, 23);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee ";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rental Furniture System ";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(6, 6);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(134, 23);
            this.addCustomerButton.TabIndex = 2;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click_1);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(655, 28);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // employeeDisplay
            // 
            this.employeeDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.employeeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeDisplay.Location = new System.Drawing.Point(599, 11);
            this.employeeDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeDisplay.Name = "employeeDisplay";
            this.employeeDisplay.Size = new System.Drawing.Size(186, 16);
            this.employeeDisplay.TabIndex = 7;
            this.employeeDisplay.Text = "USER";
            this.employeeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(146, 64);
            this.customerGridView.MultiSelect = false;
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersVisible = false;
            this.customerGridView.RowTemplate.Height = 25;
            this.customerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGridView.Size = new System.Drawing.Size(617, 283);
            this.customerGridView.TabIndex = 10;
            // 
            // employeeGridView
            // 
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Location = new System.Drawing.Point(146, 6);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.ReadOnly = true;
            this.employeeGridView.RowHeadersVisible = false;
            this.employeeGridView.RowTemplate.Height = 25;
            this.employeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeGridView.Size = new System.Drawing.Size(617, 341);
            this.employeeGridView.TabIndex = 11;
            // 
            // dashboardTabs
            // 
            this.dashboardTabs.Controls.Add(this.customersTab);
            this.dashboardTabs.Controls.Add(this.furnitureTabpage);
            this.dashboardTabs.Controls.Add(this.employeesTab);
            this.dashboardTabs.Location = new System.Drawing.Point(12, 57);
            this.dashboardTabs.Name = "dashboardTabs";
            this.dashboardTabs.SelectedIndex = 0;
            this.dashboardTabs.Size = new System.Drawing.Size(777, 381);
            this.dashboardTabs.TabIndex = 12;
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.resetCustomerButton);
            this.customersTab.Controls.Add(this.customerSearchButton);
            this.customersTab.Controls.Add(this.label3);
            this.customersTab.Controls.Add(this.label2);
            this.customersTab.Controls.Add(this.lastNameSearchTextBox);
            this.customersTab.Controls.Add(this.nameRadioButton);
            this.customersTab.Controls.Add(this.firstNameSearchTextBox);
            this.customersTab.Controls.Add(this.phoneNumberRadioButton);
            this.customersTab.Controls.Add(this.phoneNumberTextBox);
            this.customersTab.Controls.Add(this.memberIdTextBox);
            this.customersTab.Controls.Add(this.memberIDRadioButton);
            this.customersTab.Controls.Add(this.addCustomerButton);
            this.customersTab.Controls.Add(this.customerGridView);
            this.customersTab.Location = new System.Drawing.Point(4, 24);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(769, 353);
            this.customersTab.TabIndex = 0;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // resetCustomerButton
            // 
            this.resetCustomerButton.Location = new System.Drawing.Point(668, 8);
            this.resetCustomerButton.Name = "resetCustomerButton";
            this.resetCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.resetCustomerButton.TabIndex = 21;
            this.resetCustomerButton.Text = "Reset";
            this.resetCustomerButton.UseVisualStyleBackColor = true;
            this.resetCustomerButton.Click += new System.EventHandler(this.resetCustomerButton_Click);
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.Location = new System.Drawing.Point(587, 8);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new System.Drawing.Size(75, 23);
            this.customerSearchButton.TabIndex = 20;
            this.customerSearchButton.Text = "Search";
            this.customerSearchButton.UseVisualStyleBackColor = true;
            this.customerSearchButton.Click += new System.EventHandler(this.customerSearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "First Name:";
            // 
            // lastNameSearchTextBox
            // 
            this.lastNameSearchTextBox.Location = new System.Drawing.Point(516, 38);
            this.lastNameSearchTextBox.Name = "lastNameSearchTextBox";
            this.lastNameSearchTextBox.Size = new System.Drawing.Size(159, 23);
            this.lastNameSearchTextBox.TabIndex = 17;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(146, 39);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(57, 19);
            this.nameRadioButton.TabIndex = 16;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstNameSearchTextBox
            // 
            this.firstNameSearchTextBox.Location = new System.Drawing.Point(282, 38);
            this.firstNameSearchTextBox.Name = "firstNameSearchTextBox";
            this.firstNameSearchTextBox.Size = new System.Drawing.Size(156, 23);
            this.firstNameSearchTextBox.TabIndex = 15;
            // 
            // phoneNumberRadioButton
            // 
            this.phoneNumberRadioButton.AutoSize = true;
            this.phoneNumberRadioButton.Location = new System.Drawing.Point(329, 10);
            this.phoneNumberRadioButton.Name = "phoneNumberRadioButton";
            this.phoneNumberRadioButton.Size = new System.Drawing.Size(109, 19);
            this.phoneNumberRadioButton.TabIndex = 14;
            this.phoneNumberRadioButton.Text = "Phone Number:";
            this.phoneNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(444, 8);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(137, 23);
            this.phoneNumberTextBox.TabIndex = 13;
            // 
            // memberIdTextBox
            // 
            this.memberIdTextBox.Location = new System.Drawing.Point(239, 8);
            this.memberIdTextBox.Name = "memberIdTextBox";
            this.memberIdTextBox.Size = new System.Drawing.Size(84, 23);
            this.memberIdTextBox.TabIndex = 12;
            // 
            // memberIDRadioButton
            // 
            this.memberIDRadioButton.AutoSize = true;
            this.memberIDRadioButton.Checked = true;
            this.memberIDRadioButton.Location = new System.Drawing.Point(146, 10);
            this.memberIDRadioButton.Name = "memberIDRadioButton";
            this.memberIDRadioButton.Size = new System.Drawing.Size(86, 19);
            this.memberIDRadioButton.TabIndex = 11;
            this.memberIDRadioButton.TabStop = true;
            this.memberIDRadioButton.Text = "Member Id:";
            this.memberIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // furnitureTabpage
            // 
            this.furnitureTabpage.Controls.Add(this.resetButton);
            this.furnitureTabpage.Controls.Add(this.categoryRadioButton);
            this.furnitureTabpage.Controls.Add(this.StyleRadioButton);
            this.furnitureTabpage.Controls.Add(this.categoryComboBox);
            this.furnitureTabpage.Controls.Add(this.styleComboBox);
            this.furnitureTabpage.Controls.Add(this.IdRadioButton);
            this.furnitureTabpage.Controls.Add(this.furnitureSearchTextBox);
            this.furnitureTabpage.Controls.Add(this.furnitureSearchButton);
            this.furnitureTabpage.Controls.Add(this.addFurnitureButton);
            this.furnitureTabpage.Controls.Add(this.furnitureGridView);
            this.furnitureTabpage.Location = new System.Drawing.Point(4, 24);
            this.furnitureTabpage.Name = "furnitureTabpage";
            this.furnitureTabpage.Size = new System.Drawing.Size(769, 353);
            this.furnitureTabpage.TabIndex = 2;
            this.furnitureTabpage.Text = "Furniture";
            this.furnitureTabpage.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(715, 7);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(48, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // categoryRadioButton
            // 
            this.categoryRadioButton.AutoSize = true;
            this.categoryRadioButton.Location = new System.Drawing.Point(468, 8);
            this.categoryRadioButton.Name = "categoryRadioButton";
            this.categoryRadioButton.Size = new System.Drawing.Size(73, 19);
            this.categoryRadioButton.TabIndex = 8;
            this.categoryRadioButton.Text = "Category";
            this.categoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // StyleRadioButton
            // 
            this.StyleRadioButton.AutoSize = true;
            this.StyleRadioButton.Location = new System.Drawing.Point(312, 7);
            this.StyleRadioButton.Name = "StyleRadioButton";
            this.StyleRadioButton.Size = new System.Drawing.Size(50, 19);
            this.StyleRadioButton.TabIndex = 7;
            this.StyleRadioButton.Text = "Style";
            this.StyleRadioButton.UseVisualStyleBackColor = true;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(547, 6);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(105, 23);
            this.categoryComboBox.TabIndex = 6;
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(368, 8);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(94, 23);
            this.styleComboBox.TabIndex = 5;
            // 
            // IdRadioButton
            // 
            this.IdRadioButton.AutoSize = true;
            this.IdRadioButton.Checked = true;
            this.IdRadioButton.Location = new System.Drawing.Point(149, 8);
            this.IdRadioButton.Name = "IdRadioButton";
            this.IdRadioButton.Size = new System.Drawing.Size(86, 19);
            this.IdRadioButton.TabIndex = 4;
            this.IdRadioButton.TabStop = true;
            this.IdRadioButton.Text = "Furniture Id";
            this.IdRadioButton.UseVisualStyleBackColor = true;
            // 
            // furnitureSearchTextBox
            // 
            this.furnitureSearchTextBox.Location = new System.Drawing.Point(241, 6);
            this.furnitureSearchTextBox.Name = "furnitureSearchTextBox";
            this.furnitureSearchTextBox.Size = new System.Drawing.Size(65, 23);
            this.furnitureSearchTextBox.TabIndex = 3;
            // 
            // furnitureSearchButton
            // 
            this.furnitureSearchButton.Location = new System.Drawing.Point(658, 6);
            this.furnitureSearchButton.Name = "furnitureSearchButton";
            this.furnitureSearchButton.Size = new System.Drawing.Size(56, 23);
            this.furnitureSearchButton.TabIndex = 2;
            this.furnitureSearchButton.Text = "Search";
            this.furnitureSearchButton.UseVisualStyleBackColor = true;
            this.furnitureSearchButton.Click += new System.EventHandler(this.furnitureSearchButton_Click);
            // 
            // addFurnitureButton
            // 
            this.addFurnitureButton.Location = new System.Drawing.Point(6, 6);
            this.addFurnitureButton.Name = "addFurnitureButton";
            this.addFurnitureButton.Size = new System.Drawing.Size(137, 23);
            this.addFurnitureButton.TabIndex = 1;
            this.addFurnitureButton.Text = "Add Furniture";
            this.addFurnitureButton.UseVisualStyleBackColor = true;
            this.addFurnitureButton.Click += new System.EventHandler(this.addFurnitureButton_Click);
            // 
            // furnitureGridView
            // 
            this.furnitureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureGridView.Location = new System.Drawing.Point(146, 35);
            this.furnitureGridView.Name = "furnitureGridView";
            this.furnitureGridView.RowTemplate.Height = 25;
            this.furnitureGridView.Size = new System.Drawing.Size(617, 312);
            this.furnitureGridView.TabIndex = 0;
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.employeeGridView);
            this.employeesTab.Controls.Add(this.addEmployeeButton);
            this.employeesTab.Location = new System.Drawing.Point(4, 24);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeesTab.Size = new System.Drawing.Size(769, 353);
            this.employeesTab.TabIndex = 1;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dashboardTabs);
            this.Controls.Add(this.employeeDisplay);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Name = "MainScreenForm";
            this.Text = "MainScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.dashboardTabs.ResumeLayout(false);
            this.customersTab.ResumeLayout(false);
            this.customersTab.PerformLayout();
            this.furnitureTabpage.ResumeLayout(false);
            this.furnitureTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureGridView)).EndInit();
            this.employeesTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addEmployeeButton;
        private Label label1;
        private Button addCustomerButton;
        private Button logoutButton;
        private TextBox employeeDisplay;
        private DataGridView customerGridView;
        private DataGridView employeeGridView;
        private TabControl dashboardTabs;
        private TabPage customersTab;
        private TabPage employeesTab;
        private TabPage furnitureTabpage;
        private DataGridView furnitureGridView;
        private Button addFurnitureButton;
        private RadioButton IdRadioButton;
        private TextBox furnitureSearchTextBox;
        private Button furnitureSearchButton;
        private RadioButton categoryRadioButton;
        private RadioButton StyleRadioButton;
        private ComboBox categoryComboBox;
        private ComboBox styleComboBox;
        private Button resetButton;
        private Label label2;
        private TextBox lastNameSearchTextBox;
        private RadioButton nameRadioButton;
        private TextBox firstNameSearchTextBox;
        private RadioButton phoneNumberRadioButton;
        private TextBox phoneNumberTextBox;
        private TextBox memberIdTextBox;
        private RadioButton memberIDRadioButton;
        private Label label3;
        private Button resetCustomerButton;
        private Button customerSearchButton;
    }
}