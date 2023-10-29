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
            components = new System.ComponentModel.Container();
            addEmployeeButton = new Button();
            label1 = new Label();
            addCustomerButton = new Button();
            logoutButton = new Button();
            employeeDisplay = new TextBox();
            customerGridView = new DataGridView();
            fullnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            zipDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registerdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            employeeGridView = new DataGridView();
            fullnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dobDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            zipDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            rolenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            dashboardTabs = new TabControl();
            customersTab = new TabPage();
            deleteCustomerButton = new Button();
            furnitureTabpage = new TabPage();
            resetButton = new Button();
            categoryRadioButton = new RadioButton();
            StyleRadioButton = new RadioButton();
            categoryComboBox = new ComboBox();
            styleComboBox = new ComboBox();
            IdRadioButton = new RadioButton();
            furnitureSearchTextBox = new TextBox();
            furnitureSearchButton = new Button();
            addFurnitureButton = new Button();
            furnitureGridView = new DataGridView();
            furnitureidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorynameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stylenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentalrateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finerateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            furnitureBindingSource = new BindingSource(components);
            employeesTab = new TabPage();
            deleteEmployeeButton = new Button();
            rentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            dashboardTabs.SuspendLayout();
            customersTab.SuspendLayout();
            furnitureTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)furnitureGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).BeginInit();
            employeesTab.SuspendLayout();
            SuspendLayout();
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.Location = new Point(6, 6);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(134, 23);
            addEmployeeButton.TabIndex = 0;
            addEmployeeButton.Text = "Add Employee ";
            addEmployeeButton.UseVisualStyleBackColor = true;
            addEmployeeButton.Click += addEmployeeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(283, 21);
            label1.Name = "label1";
            label1.Size = new Size(301, 37);
            label1.TabIndex = 1;
            label1.Text = "Rental Furniture System ";
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(6, 6);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(134, 23);
            addCustomerButton.TabIndex = 2;
            addCustomerButton.Text = "Add Customer";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(655, 28);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 23);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // employeeDisplay
            // 
            employeeDisplay.BackColor = SystemColors.Control;
            employeeDisplay.BorderStyle = BorderStyle.None;
            employeeDisplay.Location = new Point(599, 11);
            employeeDisplay.Margin = new Padding(3, 2, 3, 2);
            employeeDisplay.Name = "employeeDisplay";
            employeeDisplay.Size = new Size(186, 16);
            employeeDisplay.TabIndex = 7;
            employeeDisplay.Text = "USER";
            employeeDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // customerGridView
            // 
            customerGridView.AllowUserToAddRows = false;
            customerGridView.AllowUserToDeleteRows = false;
            customerGridView.AutoGenerateColumns = false;
            customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerGridView.Columns.AddRange(new DataGridViewColumn[] { fullnameDataGridViewTextBoxColumn, fnameDataGridViewTextBoxColumn, lnameDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, zipDataGridViewTextBoxColumn, registerdateDataGridViewTextBoxColumn });
            customerGridView.DataSource = customerBindingSource;
            customerGridView.Location = new Point(146, 6);
            customerGridView.MultiSelect = false;
            customerGridView.Name = "customerGridView";
            customerGridView.ReadOnly = true;
            customerGridView.RowHeadersVisible = false;
            customerGridView.RowHeadersWidth = 51;
            customerGridView.RowTemplate.Height = 25;
            customerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerGridView.Size = new Size(614, 320);
            customerGridView.TabIndex = 10;
            customerGridView.RowStateChanged += customerGridView_RowStateChanged;
            customerGridView.MouseDoubleClick += customerGridView_MouseDoubleClick;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            fullnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            fullnameDataGridViewTextBoxColumn.Width = 81;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            fnameDataGridViewTextBoxColumn.ReadOnly = true;
            fnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            lnameDataGridViewTextBoxColumn.ReadOnly = true;
            lnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            dobDataGridViewTextBoxColumn.ReadOnly = true;
            dobDataGridViewTextBoxColumn.Width = 54;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 70;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            phoneDataGridViewTextBoxColumn.Width = 66;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 61;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "State";
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
            stateDataGridViewTextBoxColumn.Visible = false;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            zipDataGridViewTextBoxColumn.ReadOnly = true;
            zipDataGridViewTextBoxColumn.Visible = false;
            // 
            // registerdateDataGridViewTextBoxColumn
            // 
            registerdateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            registerdateDataGridViewTextBoxColumn.DataPropertyName = "Register_date";
            registerdateDataGridViewTextBoxColumn.HeaderText = "Register_date";
            registerdateDataGridViewTextBoxColumn.Name = "registerdateDataGridViewTextBoxColumn";
            registerdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // employeeGridView
            // 
            employeeGridView.AutoGenerateColumns = false;
            employeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeGridView.Columns.AddRange(new DataGridViewColumn[] { fullnameDataGridViewTextBoxColumn1, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, fnameDataGridViewTextBoxColumn1, lnameDataGridViewTextBoxColumn1, dobDataGridViewTextBoxColumn1, genderDataGridViewTextBoxColumn1, phoneDataGridViewTextBoxColumn1, addressDataGridViewTextBoxColumn1, cityDataGridViewTextBoxColumn1, stateDataGridViewTextBoxColumn1, zipDataGridViewTextBoxColumn1, emailDataGridViewTextBoxColumn1, rolenameDataGridViewTextBoxColumn });
            employeeGridView.DataSource = employeeBindingSource;
            employeeGridView.Location = new Point(146, 6);
            employeeGridView.Margin = new Padding(3, 4, 3, 4);
            employeeGridView.MultiSelect = false;
            employeeGridView.Name = "employeeGridView";
            employeeGridView.ReadOnly = true;
            employeeGridView.RowHeadersVisible = false;
            employeeGridView.RowHeadersWidth = 51;
            employeeGridView.RowTemplate.Height = 25;
            employeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeGridView.Size = new Size(614, 320);
            employeeGridView.TabIndex = 11;
            employeeGridView.RowStateChanged += employeeGridView_RowStateChanged;
            employeeGridView.MouseDoubleClick += employeeGridView_MouseDoubleClick;
            // 
            // fullnameDataGridViewTextBoxColumn1
            // 
            fullnameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fullnameDataGridViewTextBoxColumn1.DataPropertyName = "Fullname";
            fullnameDataGridViewTextBoxColumn1.HeaderText = "Fullname";
            fullnameDataGridViewTextBoxColumn1.Name = "fullnameDataGridViewTextBoxColumn1";
            fullnameDataGridViewTextBoxColumn1.ReadOnly = true;
            fullnameDataGridViewTextBoxColumn1.Width = 81;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            usernameDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // fnameDataGridViewTextBoxColumn1
            // 
            fnameDataGridViewTextBoxColumn1.DataPropertyName = "Fname";
            fnameDataGridViewTextBoxColumn1.HeaderText = "Fname";
            fnameDataGridViewTextBoxColumn1.Name = "fnameDataGridViewTextBoxColumn1";
            fnameDataGridViewTextBoxColumn1.ReadOnly = true;
            fnameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // lnameDataGridViewTextBoxColumn1
            // 
            lnameDataGridViewTextBoxColumn1.DataPropertyName = "Lname";
            lnameDataGridViewTextBoxColumn1.HeaderText = "Lname";
            lnameDataGridViewTextBoxColumn1.Name = "lnameDataGridViewTextBoxColumn1";
            lnameDataGridViewTextBoxColumn1.ReadOnly = true;
            lnameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dobDataGridViewTextBoxColumn1
            // 
            dobDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dobDataGridViewTextBoxColumn1.DataPropertyName = "Dob";
            dobDataGridViewTextBoxColumn1.HeaderText = "Dob";
            dobDataGridViewTextBoxColumn1.Name = "dobDataGridViewTextBoxColumn1";
            dobDataGridViewTextBoxColumn1.ReadOnly = true;
            dobDataGridViewTextBoxColumn1.Width = 54;
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            genderDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            genderDataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            genderDataGridViewTextBoxColumn1.ReadOnly = true;
            genderDataGridViewTextBoxColumn1.Width = 70;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            phoneDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            phoneDataGridViewTextBoxColumn1.Width = 66;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            addressDataGridViewTextBoxColumn1.ReadOnly = true;
            addressDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn1.HeaderText = "City";
            cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            cityDataGridViewTextBoxColumn1.ReadOnly = true;
            cityDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            stateDataGridViewTextBoxColumn1.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn1.HeaderText = "State";
            stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            stateDataGridViewTextBoxColumn1.ReadOnly = true;
            stateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // zipDataGridViewTextBoxColumn1
            // 
            zipDataGridViewTextBoxColumn1.DataPropertyName = "Zip";
            zipDataGridViewTextBoxColumn1.HeaderText = "Zip";
            zipDataGridViewTextBoxColumn1.Name = "zipDataGridViewTextBoxColumn1";
            zipDataGridViewTextBoxColumn1.ReadOnly = true;
            zipDataGridViewTextBoxColumn1.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            emailDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            emailDataGridViewTextBoxColumn1.ReadOnly = true;
            emailDataGridViewTextBoxColumn1.Width = 61;
            // 
            // rolenameDataGridViewTextBoxColumn
            // 
            rolenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rolenameDataGridViewTextBoxColumn.DataPropertyName = "Role_name";
            rolenameDataGridViewTextBoxColumn.HeaderText = "Role_name";
            rolenameDataGridViewTextBoxColumn.Name = "rolenameDataGridViewTextBoxColumn";
            rolenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(model.Employee);
            // 
            // dashboardTabs
            // 
            dashboardTabs.Controls.Add(customersTab);
            dashboardTabs.Controls.Add(furnitureTabpage);
            dashboardTabs.Controls.Add(employeesTab);
            dashboardTabs.Location = new Point(14, 76);
            dashboardTabs.Margin = new Padding(3, 4, 3, 4);
            dashboardTabs.Name = "dashboardTabs";
            dashboardTabs.SelectedIndex = 0;
            dashboardTabs.Size = new Size(774, 361);
            dashboardTabs.TabIndex = 12;
            dashboardTabs.SelectedIndexChanged += dashboardTabs_SelectedIndexChanged;
            // 
            // customersTab
            // 
            customersTab.Controls.Add(rentButton);
            customersTab.Controls.Add(deleteCustomerButton);
            customersTab.Controls.Add(addCustomerButton);
            customersTab.Controls.Add(customerGridView);
            customersTab.Location = new Point(4, 24);
            customersTab.Margin = new Padding(3, 4, 3, 4);
            customersTab.Name = "customersTab";
            customersTab.Padding = new Padding(3, 4, 3, 4);
            customersTab.Size = new Size(766, 333);
            customersTab.TabIndex = 0;
            customersTab.Text = "Customers";
            customersTab.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.Location = new Point(6, 36);
            deleteCustomerButton.Margin = new Padding(3, 4, 3, 4);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(134, 23);
            deleteCustomerButton.TabIndex = 11;
            deleteCustomerButton.Text = "Delete Customer";
            deleteCustomerButton.UseVisualStyleBackColor = true;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // furnitureTabpage
            // 
            furnitureTabpage.Controls.Add(resetButton);
            furnitureTabpage.Controls.Add(categoryRadioButton);
            furnitureTabpage.Controls.Add(StyleRadioButton);
            furnitureTabpage.Controls.Add(categoryComboBox);
            furnitureTabpage.Controls.Add(styleComboBox);
            furnitureTabpage.Controls.Add(IdRadioButton);
            furnitureTabpage.Controls.Add(furnitureSearchTextBox);
            furnitureTabpage.Controls.Add(furnitureSearchButton);
            furnitureTabpage.Controls.Add(addFurnitureButton);
            furnitureTabpage.Controls.Add(furnitureGridView);
            furnitureTabpage.Location = new Point(4, 24);
            furnitureTabpage.Name = "furnitureTabpage";
            furnitureTabpage.Size = new Size(766, 333);
            furnitureTabpage.TabIndex = 2;
            furnitureTabpage.Text = "Furniture";
            furnitureTabpage.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(710, 6);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(49, 23);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // categoryRadioButton
            // 
            categoryRadioButton.AutoSize = true;
            categoryRadioButton.Location = new Point(464, 8);
            categoryRadioButton.Name = "categoryRadioButton";
            categoryRadioButton.Size = new Size(73, 19);
            categoryRadioButton.TabIndex = 8;
            categoryRadioButton.Text = "Category";
            categoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // StyleRadioButton
            // 
            StyleRadioButton.AutoSize = true;
            StyleRadioButton.Location = new Point(308, 8);
            StyleRadioButton.Name = "StyleRadioButton";
            StyleRadioButton.Size = new Size(50, 19);
            StyleRadioButton.TabIndex = 7;
            StyleRadioButton.Text = "Style";
            StyleRadioButton.UseVisualStyleBackColor = true;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(542, 7);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(106, 23);
            categoryComboBox.TabIndex = 6;
            // 
            // styleComboBox
            // 
            styleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            styleComboBox.FormattingEnabled = true;
            styleComboBox.Location = new Point(363, 7);
            styleComboBox.Name = "styleComboBox";
            styleComboBox.Size = new Size(95, 23);
            styleComboBox.TabIndex = 5;
            // 
            // IdRadioButton
            // 
            IdRadioButton.AutoSize = true;
            IdRadioButton.Checked = true;
            IdRadioButton.Location = new Point(145, 8);
            IdRadioButton.Name = "IdRadioButton";
            IdRadioButton.Size = new Size(86, 19);
            IdRadioButton.TabIndex = 4;
            IdRadioButton.TabStop = true;
            IdRadioButton.Text = "Furniture Id";
            IdRadioButton.UseVisualStyleBackColor = true;
            // 
            // furnitureSearchTextBox
            // 
            furnitureSearchTextBox.Location = new Point(236, 7);
            furnitureSearchTextBox.Name = "furnitureSearchTextBox";
            furnitureSearchTextBox.Size = new Size(66, 23);
            furnitureSearchTextBox.TabIndex = 3;
            // 
            // furnitureSearchButton
            // 
            furnitureSearchButton.Location = new Point(653, 6);
            furnitureSearchButton.Name = "furnitureSearchButton";
            furnitureSearchButton.Size = new Size(57, 23);
            furnitureSearchButton.TabIndex = 2;
            furnitureSearchButton.Text = "Search";
            furnitureSearchButton.UseVisualStyleBackColor = true;
            furnitureSearchButton.Click += furnitureSearchButton_Click;
            // 
            // addFurnitureButton
            // 
            addFurnitureButton.Location = new Point(6, 6);
            addFurnitureButton.Name = "addFurnitureButton";
            addFurnitureButton.Size = new Size(134, 23);
            addFurnitureButton.TabIndex = 1;
            addFurnitureButton.Text = "Add Furniture";
            addFurnitureButton.UseVisualStyleBackColor = true;
            addFurnitureButton.Click += addFurnitureButton_Click;
            // 
            // furnitureGridView
            // 
            furnitureGridView.AutoGenerateColumns = false;
            furnitureGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            furnitureGridView.Columns.AddRange(new DataGridViewColumn[] { furnitureidDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categorynameDataGridViewTextBoxColumn, stylenameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, rentalrateDataGridViewTextBoxColumn, finerateDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            furnitureGridView.DataSource = furnitureBindingSource;
            furnitureGridView.Location = new Point(146, 37);
            furnitureGridView.MultiSelect = false;
            furnitureGridView.Name = "furnitureGridView";
            furnitureGridView.ReadOnly = true;
            furnitureGridView.RowHeadersVisible = false;
            furnitureGridView.RowTemplate.Height = 25;
            furnitureGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            furnitureGridView.Size = new Size(614, 289);
            furnitureGridView.TabIndex = 0;
            // 
            // furnitureidDataGridViewTextBoxColumn
            // 
            furnitureidDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            furnitureidDataGridViewTextBoxColumn.DataPropertyName = "Furniture_id";
            furnitureidDataGridViewTextBoxColumn.HeaderText = "Furniture_id";
            furnitureidDataGridViewTextBoxColumn.Name = "furnitureidDataGridViewTextBoxColumn";
            furnitureidDataGridViewTextBoxColumn.ReadOnly = true;
            furnitureidDataGridViewTextBoxColumn.Width = 95;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 64;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            categorynameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            categorynameDataGridViewTextBoxColumn.DataPropertyName = "Category_name";
            categorynameDataGridViewTextBoxColumn.HeaderText = "Category";
            categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            categorynameDataGridViewTextBoxColumn.ReadOnly = true;
            categorynameDataGridViewTextBoxColumn.Width = 80;
            // 
            // stylenameDataGridViewTextBoxColumn
            // 
            stylenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stylenameDataGridViewTextBoxColumn.DataPropertyName = "Style_name";
            stylenameDataGridViewTextBoxColumn.HeaderText = "Style";
            stylenameDataGridViewTextBoxColumn.Name = "stylenameDataGridViewTextBoxColumn";
            stylenameDataGridViewTextBoxColumn.ReadOnly = true;
            stylenameDataGridViewTextBoxColumn.Width = 57;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // rentalrateDataGridViewTextBoxColumn
            // 
            rentalrateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rentalrateDataGridViewTextBoxColumn.DataPropertyName = "Rental_rate";
            rentalrateDataGridViewTextBoxColumn.HeaderText = "Rental_rate";
            rentalrateDataGridViewTextBoxColumn.Name = "rentalrateDataGridViewTextBoxColumn";
            rentalrateDataGridViewTextBoxColumn.ReadOnly = true;
            rentalrateDataGridViewTextBoxColumn.Width = 90;
            // 
            // finerateDataGridViewTextBoxColumn
            // 
            finerateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            finerateDataGridViewTextBoxColumn.DataPropertyName = "Fine_rate";
            finerateDataGridViewTextBoxColumn.HeaderText = "Fine_rate";
            finerateDataGridViewTextBoxColumn.Name = "finerateDataGridViewTextBoxColumn";
            finerateDataGridViewTextBoxColumn.ReadOnly = true;
            finerateDataGridViewTextBoxColumn.Width = 79;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // furnitureBindingSource
            // 
            furnitureBindingSource.DataSource = typeof(model.Furniture);
            // 
            // employeesTab
            // 
            employeesTab.Controls.Add(deleteEmployeeButton);
            employeesTab.Controls.Add(employeeGridView);
            employeesTab.Controls.Add(addEmployeeButton);
            employeesTab.Location = new Point(4, 24);
            employeesTab.Margin = new Padding(3, 4, 3, 4);
            employeesTab.Name = "employeesTab";
            employeesTab.Padding = new Padding(3);
            employeesTab.Size = new Size(766, 333);
            employeesTab.TabIndex = 1;
            employeesTab.Text = "Employees";
            employeesTab.UseVisualStyleBackColor = true;
            // 
            // deleteEmployeeButton
            // 
            deleteEmployeeButton.Location = new Point(6, 36);
            deleteEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            deleteEmployeeButton.Name = "deleteEmployeeButton";
            deleteEmployeeButton.Size = new Size(134, 23);
            deleteEmployeeButton.TabIndex = 12;
            deleteEmployeeButton.Text = "Delete Employee ";
            deleteEmployeeButton.UseVisualStyleBackColor = true;
            deleteEmployeeButton.Click += deleteEmployeeButton_Click;
            // 
            // rentButton
            // 
            rentButton.Location = new Point(6, 66);
            rentButton.Name = "rentButton";
            rentButton.Size = new Size(134, 23);
            rentButton.TabIndex = 13;
            rentButton.Text = "Rent Furniture";
            rentButton.UseVisualStyleBackColor = true;
            rentButton.Click += rentButton_Click;
            // 
            // MainScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dashboardTabs);
            Controls.Add(employeeDisplay);
            Controls.Add(logoutButton);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainScreenForm";
            Text = "MainScreenForm";
            ((System.ComponentModel.ISupportInitialize)customerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            dashboardTabs.ResumeLayout(false);
            customersTab.ResumeLayout(false);
            furnitureTabpage.ResumeLayout(false);
            furnitureTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)furnitureGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).EndInit();
            employeesTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button rentButton;
        private BindingSource customerBindingSource;
        private BindingSource employeeBindingSource;
        private DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registerdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn employeeNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rolenameDataGridViewTextBoxColumn;
        private Button deleteCustomerButton;
        private Button deleteEmployeeButton;
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
        private BindingSource furnitureBindingSource;
        private DataGridViewTextBoxColumn furnitureidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stylenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentalrateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finerateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}