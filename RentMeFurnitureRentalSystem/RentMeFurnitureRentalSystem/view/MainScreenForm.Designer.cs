namespace RentMeFurnitureRentalSystem
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            addEmployeeButton = new Button();
            label1 = new Label();
            addCustomerButton = new Button();
            logoutButton = new Button();
            employeeDisplay = new TextBox();
            customerBindingSource = new BindingSource(components);
            customerSearchButton = new Button();
            label3 = new Label();
            label2 = new Label();
            lastNameSearchTextBox = new TextBox();
            nameRadioButton = new RadioButton();
            firstNameSearchTextBox = new TextBox();
            phoneNumberRadioButton = new RadioButton();
            phoneNumberTextBox = new TextBox();
            memberIdTextBox = new TextBox();
            memberIDRadioButton = new RadioButton();
            employeeGridView = new DataGridView();
            Employee_num = new DataGridViewTextBoxColumn();
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
            returnButton = new Button();
            rentButton = new Button();
            resetCustomerButton = new Button();
            deleteCustomerButton = new Button();
            customerGridView = new DataGridView();
            Member_id = new DataGridViewTextBoxColumn();
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
            furnitureTabpage = new TabPage();
            deleteFurnitureButton = new Button();
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
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            employeeLnameTextBox = new TextBox();
            employeeNameRadioButton = new RadioButton();
            employeeFnameTextBox = new TextBox();
            employeePhoneRadioButton = new RadioButton();
            employeePhoneTextBox = new TextBox();
            employeeNumTextBox = new TextBox();
            employeeNumRadioButton = new RadioButton();
            deleteEmployeeButton = new Button();
            adminTableButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            dashboardTabs.SuspendLayout();
            customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
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
            addEmployeeButton.Size = new Size(135, 25);
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
            addCustomerButton.Size = new Size(135, 25);
            addCustomerButton.TabIndex = 2;
            addCustomerButton.Text = "Add Customer";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(659, 39);
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
            employeeDisplay.Location = new Point(615, 18);
            employeeDisplay.Margin = new Padding(3, 2, 3, 2);
            employeeDisplay.Name = "employeeDisplay";
            employeeDisplay.Size = new Size(163, 16);
            employeeDisplay.TabIndex = 7;
            employeeDisplay.Text = "USER";
            employeeDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // customerSearchButton
            // 
            customerSearchButton.Location = new Point(593, 8);
            customerSearchButton.Name = "customerSearchButton";
            customerSearchButton.Size = new Size(75, 23);
            customerSearchButton.TabIndex = 20;
            customerSearchButton.Text = "Search";
            customerSearchButton.UseVisualStyleBackColor = true;
            customerSearchButton.Click += customerSearchButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 41);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 19;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 41);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 18;
            label2.Text = "First Name:";
            // 
            // lastNameSearchTextBox
            // 
            lastNameSearchTextBox.Location = new Point(522, 38);
            lastNameSearchTextBox.Name = "lastNameSearchTextBox";
            lastNameSearchTextBox.Size = new Size(159, 23);
            lastNameSearchTextBox.TabIndex = 17;
            // 
            // nameRadioButton
            // 
            nameRadioButton.AutoSize = true;
            nameRadioButton.Location = new Point(152, 39);
            nameRadioButton.Name = "nameRadioButton";
            nameRadioButton.Size = new Size(57, 19);
            nameRadioButton.TabIndex = 16;
            nameRadioButton.Text = "Name";
            nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstNameSearchTextBox
            // 
            firstNameSearchTextBox.Location = new Point(288, 38);
            firstNameSearchTextBox.Name = "firstNameSearchTextBox";
            firstNameSearchTextBox.Size = new Size(156, 23);
            firstNameSearchTextBox.TabIndex = 15;
            // 
            // phoneNumberRadioButton
            // 
            phoneNumberRadioButton.AutoSize = true;
            phoneNumberRadioButton.Location = new Point(335, 10);
            phoneNumberRadioButton.Name = "phoneNumberRadioButton";
            phoneNumberRadioButton.Size = new Size(109, 19);
            phoneNumberRadioButton.TabIndex = 14;
            phoneNumberRadioButton.Text = "Phone Number:";
            phoneNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(450, 8);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(137, 23);
            phoneNumberTextBox.TabIndex = 13;
            // 
            // memberIdTextBox
            // 
            memberIdTextBox.Location = new Point(245, 8);
            memberIdTextBox.Name = "memberIdTextBox";
            memberIdTextBox.Size = new Size(84, 23);
            memberIdTextBox.TabIndex = 12;
            // 
            // memberIDRadioButton
            // 
            memberIDRadioButton.AutoSize = true;
            memberIDRadioButton.Checked = true;
            memberIDRadioButton.Location = new Point(152, 10);
            memberIDRadioButton.Name = "memberIDRadioButton";
            memberIDRadioButton.Size = new Size(86, 19);
            memberIDRadioButton.TabIndex = 11;
            memberIDRadioButton.TabStop = true;
            memberIDRadioButton.Text = "Member Id:";
            memberIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeGridView
            // 
            employeeGridView.AutoGenerateColumns = false;
            employeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeGridView.Columns.AddRange(new DataGridViewColumn[] { Employee_num, fullnameDataGridViewTextBoxColumn1, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, fnameDataGridViewTextBoxColumn1, lnameDataGridViewTextBoxColumn1, dobDataGridViewTextBoxColumn1, genderDataGridViewTextBoxColumn1, phoneDataGridViewTextBoxColumn1, addressDataGridViewTextBoxColumn1, cityDataGridViewTextBoxColumn1, stateDataGridViewTextBoxColumn1, zipDataGridViewTextBoxColumn1, emailDataGridViewTextBoxColumn1, rolenameDataGridViewTextBoxColumn });
            employeeGridView.DataSource = employeeBindingSource;
            employeeGridView.Location = new Point(143, 67);
            employeeGridView.Margin = new Padding(3, 4, 3, 4);
            employeeGridView.MultiSelect = false;
            employeeGridView.Name = "employeeGridView";
            employeeGridView.ReadOnly = true;
            employeeGridView.RowHeadersVisible = false;
            employeeGridView.RowHeadersWidth = 51;
            employeeGridView.RowTemplate.Height = 25;
            employeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeGridView.Size = new Size(617, 259);
            employeeGridView.TabIndex = 11;
            employeeGridView.RowStateChanged += employeeGridView_RowStateChanged;
            employeeGridView.MouseDoubleClick += employeeGridView_MouseDoubleClick;
            // 
            // Employee_num
            // 
            Employee_num.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Employee_num.DataPropertyName = "Employee_num";
            Employee_num.HeaderText = "Employee Num";
            Employee_num.Name = "Employee_num";
            Employee_num.ReadOnly = true;
            Employee_num.Width = 75;
            // 
            // fullnameDataGridViewTextBoxColumn1
            // 
            fullnameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fullnameDataGridViewTextBoxColumn1.DataPropertyName = "Fullname";
            fullnameDataGridViewTextBoxColumn1.HeaderText = "Fullname";
            fullnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            fullnameDataGridViewTextBoxColumn1.Name = "fullnameDataGridViewTextBoxColumn1";
            fullnameDataGridViewTextBoxColumn1.ReadOnly = true;
            fullnameDataGridViewTextBoxColumn1.Width = 81;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            usernameDataGridViewTextBoxColumn.Visible = false;
            usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn1
            // 
            fnameDataGridViewTextBoxColumn1.DataPropertyName = "Fname";
            fnameDataGridViewTextBoxColumn1.HeaderText = "Fname";
            fnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            fnameDataGridViewTextBoxColumn1.Name = "fnameDataGridViewTextBoxColumn1";
            fnameDataGridViewTextBoxColumn1.ReadOnly = true;
            fnameDataGridViewTextBoxColumn1.Visible = false;
            fnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn1
            // 
            lnameDataGridViewTextBoxColumn1.DataPropertyName = "Lname";
            lnameDataGridViewTextBoxColumn1.HeaderText = "Lname";
            lnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            lnameDataGridViewTextBoxColumn1.Name = "lnameDataGridViewTextBoxColumn1";
            lnameDataGridViewTextBoxColumn1.ReadOnly = true;
            lnameDataGridViewTextBoxColumn1.Visible = false;
            lnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn1
            // 
            dobDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dobDataGridViewTextBoxColumn1.DataPropertyName = "Dob";
            dobDataGridViewTextBoxColumn1.HeaderText = "Dob";
            dobDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dobDataGridViewTextBoxColumn1.Name = "dobDataGridViewTextBoxColumn1";
            dobDataGridViewTextBoxColumn1.ReadOnly = true;
            dobDataGridViewTextBoxColumn1.Width = 54;
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            genderDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            genderDataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn1.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            genderDataGridViewTextBoxColumn1.ReadOnly = true;
            genderDataGridViewTextBoxColumn1.Width = 70;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            phoneDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            phoneDataGridViewTextBoxColumn1.Width = 66;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            addressDataGridViewTextBoxColumn1.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            addressDataGridViewTextBoxColumn1.ReadOnly = true;
            addressDataGridViewTextBoxColumn1.Visible = false;
            addressDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn1.HeaderText = "City";
            cityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            cityDataGridViewTextBoxColumn1.ReadOnly = true;
            cityDataGridViewTextBoxColumn1.Visible = false;
            cityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            stateDataGridViewTextBoxColumn1.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn1.HeaderText = "State";
            stateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            stateDataGridViewTextBoxColumn1.ReadOnly = true;
            stateDataGridViewTextBoxColumn1.Visible = false;
            stateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // zipDataGridViewTextBoxColumn1
            // 
            zipDataGridViewTextBoxColumn1.DataPropertyName = "Zip";
            zipDataGridViewTextBoxColumn1.HeaderText = "Zip";
            zipDataGridViewTextBoxColumn1.MinimumWidth = 6;
            zipDataGridViewTextBoxColumn1.Name = "zipDataGridViewTextBoxColumn1";
            zipDataGridViewTextBoxColumn1.ReadOnly = true;
            zipDataGridViewTextBoxColumn1.Visible = false;
            zipDataGridViewTextBoxColumn1.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            emailDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            emailDataGridViewTextBoxColumn1.ReadOnly = true;
            emailDataGridViewTextBoxColumn1.Width = 61;
            // 
            // rolenameDataGridViewTextBoxColumn
            // 
            rolenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rolenameDataGridViewTextBoxColumn.DataPropertyName = "Role_name";
            rolenameDataGridViewTextBoxColumn.HeaderText = "Role";
            rolenameDataGridViewTextBoxColumn.MinimumWidth = 6;
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
            customersTab.Controls.Add(returnButton);
            customersTab.Controls.Add(rentButton);
            customersTab.Controls.Add(resetCustomerButton);
            customersTab.Controls.Add(customerSearchButton);
            customersTab.Controls.Add(label3);
            customersTab.Controls.Add(label2);
            customersTab.Controls.Add(lastNameSearchTextBox);
            customersTab.Controls.Add(nameRadioButton);
            customersTab.Controls.Add(firstNameSearchTextBox);
            customersTab.Controls.Add(phoneNumberRadioButton);
            customersTab.Controls.Add(phoneNumberTextBox);
            customersTab.Controls.Add(memberIdTextBox);
            customersTab.Controls.Add(memberIDRadioButton);
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
            // returnButton
            // 
            returnButton.Location = new Point(6, 101);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(135, 25);
            returnButton.TabIndex = 22;
            returnButton.Text = "Return Furniture";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // rentButton
            // 
            rentButton.Location = new Point(6, 70);
            rentButton.Name = "rentButton";
            rentButton.Size = new Size(135, 25);
            rentButton.TabIndex = 13;
            rentButton.Text = "Rent Furniture";
            rentButton.UseVisualStyleBackColor = true;
            rentButton.Click += rentButton_Click;
            // 
            // resetCustomerButton
            // 
            resetCustomerButton.Location = new Point(674, 8);
            resetCustomerButton.Name = "resetCustomerButton";
            resetCustomerButton.Size = new Size(75, 23);
            resetCustomerButton.TabIndex = 21;
            resetCustomerButton.Text = "Reset";
            resetCustomerButton.UseVisualStyleBackColor = true;
            resetCustomerButton.Click += resetCustomerButton_Click;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.Location = new Point(6, 38);
            deleteCustomerButton.Margin = new Padding(3, 4, 3, 4);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(135, 25);
            deleteCustomerButton.TabIndex = 11;
            deleteCustomerButton.Text = "Delete Customer";
            deleteCustomerButton.UseVisualStyleBackColor = true;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // customerGridView
            // 
            customerGridView.AllowUserToAddRows = false;
            customerGridView.AllowUserToDeleteRows = false;
            customerGridView.AutoGenerateColumns = false;
            customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerGridView.Columns.AddRange(new DataGridViewColumn[] { Member_id, fullnameDataGridViewTextBoxColumn, fnameDataGridViewTextBoxColumn, lnameDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, zipDataGridViewTextBoxColumn, registerdateDataGridViewTextBoxColumn });
            customerGridView.DataSource = customerBindingSource;
            customerGridView.Location = new Point(143, 67);
            customerGridView.MultiSelect = false;
            customerGridView.Name = "customerGridView";
            customerGridView.ReadOnly = true;
            customerGridView.RowHeadersVisible = false;
            customerGridView.RowHeadersWidth = 51;
            customerGridView.RowTemplate.Height = 25;
            customerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerGridView.Size = new Size(617, 259);
            customerGridView.TabIndex = 10;
            customerGridView.RowStateChanged += customerGridView_RowStateChanged;
            customerGridView.MouseDoubleClick += customerGridView_MouseDoubleClick;
            // 
            // Member_id
            // 
            Member_id.DataPropertyName = "Member_id";
            Member_id.HeaderText = "Member Id";
            Member_id.Name = "Member_id";
            Member_id.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            fullnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            fullnameDataGridViewTextBoxColumn.Width = 81;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            fnameDataGridViewTextBoxColumn.ReadOnly = true;
            fnameDataGridViewTextBoxColumn.Visible = false;
            fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            lnameDataGridViewTextBoxColumn.ReadOnly = true;
            lnameDataGridViewTextBoxColumn.Visible = false;
            lnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            dobDataGridViewTextBoxColumn.ReadOnly = true;
            dobDataGridViewTextBoxColumn.Width = 54;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 70;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            phoneDataGridViewTextBoxColumn.Width = 66;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 61;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Visible = false;
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Visible = false;
            cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "State";
            stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
            stateDataGridViewTextBoxColumn.Visible = false;
            stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            zipDataGridViewTextBoxColumn.MinimumWidth = 6;
            zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            zipDataGridViewTextBoxColumn.ReadOnly = true;
            zipDataGridViewTextBoxColumn.Visible = false;
            zipDataGridViewTextBoxColumn.Width = 125;
            // 
            // registerdateDataGridViewTextBoxColumn
            // 
            registerdateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            registerdateDataGridViewTextBoxColumn.DataPropertyName = "Register_date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            registerdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            registerdateDataGridViewTextBoxColumn.HeaderText = "Register Date";
            registerdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            registerdateDataGridViewTextBoxColumn.Name = "registerdateDataGridViewTextBoxColumn";
            registerdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // furnitureTabpage
            // 
            furnitureTabpage.Controls.Add(deleteFurnitureButton);
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
            // deleteFurnitureButton
            // 
            deleteFurnitureButton.Location = new Point(6, 38);
            deleteFurnitureButton.Margin = new Padding(3, 4, 3, 4);
            deleteFurnitureButton.Name = "deleteFurnitureButton";
            deleteFurnitureButton.Size = new Size(135, 25);
            deleteFurnitureButton.TabIndex = 12;
            deleteFurnitureButton.Text = "Delete Furniture";
            deleteFurnitureButton.UseVisualStyleBackColor = true;
            deleteFurnitureButton.Click += deleteFurnitureButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(710, 7);
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
            categoryRadioButton.Location = new Point(464, 9);
            categoryRadioButton.Name = "categoryRadioButton";
            categoryRadioButton.Size = new Size(73, 19);
            categoryRadioButton.TabIndex = 8;
            categoryRadioButton.Text = "Category";
            categoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // StyleRadioButton
            // 
            StyleRadioButton.AutoSize = true;
            StyleRadioButton.Location = new Point(308, 9);
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
            categoryComboBox.Location = new Point(542, 8);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(106, 23);
            categoryComboBox.TabIndex = 6;
            // 
            // styleComboBox
            // 
            styleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            styleComboBox.FormattingEnabled = true;
            styleComboBox.Location = new Point(363, 8);
            styleComboBox.Name = "styleComboBox";
            styleComboBox.Size = new Size(95, 23);
            styleComboBox.TabIndex = 5;
            // 
            // IdRadioButton
            // 
            IdRadioButton.AutoSize = true;
            IdRadioButton.Checked = true;
            IdRadioButton.Location = new Point(145, 9);
            IdRadioButton.Name = "IdRadioButton";
            IdRadioButton.Size = new Size(86, 19);
            IdRadioButton.TabIndex = 4;
            IdRadioButton.TabStop = true;
            IdRadioButton.Text = "Furniture Id";
            IdRadioButton.UseVisualStyleBackColor = true;
            // 
            // furnitureSearchTextBox
            // 
            furnitureSearchTextBox.Location = new Point(236, 8);
            furnitureSearchTextBox.Name = "furnitureSearchTextBox";
            furnitureSearchTextBox.Size = new Size(66, 23);
            furnitureSearchTextBox.TabIndex = 3;
            // 
            // furnitureSearchButton
            // 
            furnitureSearchButton.Location = new Point(653, 7);
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
            addFurnitureButton.Size = new Size(135, 25);
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
            furnitureGridView.RowHeadersWidth = 51;
            furnitureGridView.RowTemplate.Height = 25;
            furnitureGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            furnitureGridView.Size = new Size(614, 289);
            furnitureGridView.TabIndex = 0;
            furnitureGridView.RowStateChanged += furnitureGridView_RowStateChanged;
            // 
            // furnitureidDataGridViewTextBoxColumn
            // 
            furnitureidDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            furnitureidDataGridViewTextBoxColumn.DataPropertyName = "Furniture_id";
            furnitureidDataGridViewTextBoxColumn.HeaderText = "Furniture Id";
            furnitureidDataGridViewTextBoxColumn.MinimumWidth = 6;
            furnitureidDataGridViewTextBoxColumn.Name = "furnitureidDataGridViewTextBoxColumn";
            furnitureidDataGridViewTextBoxColumn.ReadOnly = true;
            furnitureidDataGridViewTextBoxColumn.Width = 93;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 64;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            categorynameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            categorynameDataGridViewTextBoxColumn.DataPropertyName = "Category_name";
            categorynameDataGridViewTextBoxColumn.HeaderText = "Category";
            categorynameDataGridViewTextBoxColumn.MinimumWidth = 6;
            categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            categorynameDataGridViewTextBoxColumn.ReadOnly = true;
            categorynameDataGridViewTextBoxColumn.Width = 80;
            // 
            // stylenameDataGridViewTextBoxColumn
            // 
            stylenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stylenameDataGridViewTextBoxColumn.DataPropertyName = "Style_name";
            stylenameDataGridViewTextBoxColumn.HeaderText = "Style";
            stylenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            stylenameDataGridViewTextBoxColumn.Name = "stylenameDataGridViewTextBoxColumn";
            stylenameDataGridViewTextBoxColumn.ReadOnly = true;
            stylenameDataGridViewTextBoxColumn.Width = 57;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // rentalrateDataGridViewTextBoxColumn
            // 
            rentalrateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rentalrateDataGridViewTextBoxColumn.DataPropertyName = "Rental_rate";
            rentalrateDataGridViewTextBoxColumn.HeaderText = "Rental Rate";
            rentalrateDataGridViewTextBoxColumn.MinimumWidth = 6;
            rentalrateDataGridViewTextBoxColumn.Name = "rentalrateDataGridViewTextBoxColumn";
            rentalrateDataGridViewTextBoxColumn.ReadOnly = true;
            rentalrateDataGridViewTextBoxColumn.Width = 91;
            // 
            // finerateDataGridViewTextBoxColumn
            // 
            finerateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            finerateDataGridViewTextBoxColumn.DataPropertyName = "Fine_rate";
            finerateDataGridViewTextBoxColumn.HeaderText = "Fine Rate";
            finerateDataGridViewTextBoxColumn.MinimumWidth = 6;
            finerateDataGridViewTextBoxColumn.Name = "finerateDataGridViewTextBoxColumn";
            finerateDataGridViewTextBoxColumn.ReadOnly = true;
            finerateDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // furnitureBindingSource
            // 
            furnitureBindingSource.DataSource = typeof(model.Furniture);
            // 
            // employeesTab
            // 
            employeesTab.Controls.Add(button1);
            employeesTab.Controls.Add(button2);
            employeesTab.Controls.Add(label4);
            employeesTab.Controls.Add(label5);
            employeesTab.Controls.Add(employeeLnameTextBox);
            employeesTab.Controls.Add(employeeNameRadioButton);
            employeesTab.Controls.Add(employeeFnameTextBox);
            employeesTab.Controls.Add(employeePhoneRadioButton);
            employeesTab.Controls.Add(employeePhoneTextBox);
            employeesTab.Controls.Add(employeeNumTextBox);
            employeesTab.Controls.Add(employeeNumRadioButton);
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
            // button1
            // 
            button1.Location = new Point(679, 8);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += resetEmployeeButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(598, 8);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 31;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += employeeSearchButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 41);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 30;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 41);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 29;
            label5.Text = "First Name:";
            // 
            // employeeLnameTextBox
            // 
            employeeLnameTextBox.Location = new Point(522, 38);
            employeeLnameTextBox.Name = "employeeLnameTextBox";
            employeeLnameTextBox.Size = new Size(159, 23);
            employeeLnameTextBox.TabIndex = 28;
            // 
            // employeeNameRadioButton
            // 
            employeeNameRadioButton.AutoSize = true;
            employeeNameRadioButton.Location = new Point(152, 39);
            employeeNameRadioButton.Name = "employeeNameRadioButton";
            employeeNameRadioButton.Size = new Size(57, 19);
            employeeNameRadioButton.TabIndex = 27;
            employeeNameRadioButton.Text = "Name";
            employeeNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeFnameTextBox
            // 
            employeeFnameTextBox.Location = new Point(288, 38);
            employeeFnameTextBox.Name = "employeeFnameTextBox";
            employeeFnameTextBox.Size = new Size(156, 23);
            employeeFnameTextBox.TabIndex = 26;
            // 
            // employeePhoneRadioButton
            // 
            employeePhoneRadioButton.AutoSize = true;
            employeePhoneRadioButton.Location = new Point(348, 10);
            employeePhoneRadioButton.Name = "employeePhoneRadioButton";
            employeePhoneRadioButton.Size = new Size(109, 19);
            employeePhoneRadioButton.TabIndex = 25;
            employeePhoneRadioButton.Text = "Phone Number:";
            employeePhoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeePhoneTextBox
            // 
            employeePhoneTextBox.Location = new Point(457, 8);
            employeePhoneTextBox.Name = "employeePhoneTextBox";
            employeePhoneTextBox.Size = new Size(137, 23);
            employeePhoneTextBox.TabIndex = 24;
            // 
            // employeeNumTextBox
            // 
            employeeNumTextBox.Location = new Point(258, 8);
            employeeNumTextBox.Name = "employeeNumTextBox";
            employeeNumTextBox.Size = new Size(84, 23);
            employeeNumTextBox.TabIndex = 23;
            // 
            // employeeNumRadioButton
            // 
            employeeNumRadioButton.AutoSize = true;
            employeeNumRadioButton.Checked = true;
            employeeNumRadioButton.Location = new Point(152, 10);
            employeeNumRadioButton.Name = "employeeNumRadioButton";
            employeeNumRadioButton.Size = new Size(108, 19);
            employeeNumRadioButton.TabIndex = 22;
            employeeNumRadioButton.TabStop = true;
            employeeNumRadioButton.Text = "Employee num:";
            employeeNumRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteEmployeeButton
            // 
            deleteEmployeeButton.Location = new Point(6, 37);
            deleteEmployeeButton.Name = "deleteEmployeeButton";
            deleteEmployeeButton.Size = new Size(135, 25);
            deleteEmployeeButton.TabIndex = 12;
            deleteEmployeeButton.Text = "Delete Employee ";
            deleteEmployeeButton.UseVisualStyleBackColor = true;
            deleteEmployeeButton.Click += deleteEmployeeButton_Click;
            // 
            // adminTableButton
            // 
            adminTableButton.Location = new Point(52, 32);
            adminTableButton.Margin = new Padding(3, 2, 3, 2);
            adminTableButton.Name = "adminTableButton";
            adminTableButton.Size = new Size(106, 26);
            adminTableButton.TabIndex = 13;
            adminTableButton.Text = "Admin Tools";
            adminTableButton.UseVisualStyleBackColor = true;
            adminTableButton.Click += adminTableButton_Click;
            // 
            // MainScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adminTableButton);
            Controls.Add(dashboardTabs);
            Controls.Add(employeeDisplay);
            Controls.Add(logoutButton);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainScreenForm";
            Text = "MainScreenForm";
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            dashboardTabs.ResumeLayout(false);
            customersTab.ResumeLayout(false);
            customersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerGridView).EndInit();
            furnitureTabpage.ResumeLayout(false);
            furnitureTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)furnitureGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).EndInit();
            employeesTab.ResumeLayout(false);
            employeesTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addEmployeeButton;
        private Label label1;
        private Button addCustomerButton;
        private Button logoutButton;
        private TextBox employeeDisplay;
        private DataGridView employeeGridView;
        private TabControl dashboardTabs;
        private TabPage customersTab;
        private TabPage employeesTab;
        private Button rentButton;
        private BindingSource customerBindingSource;
        private BindingSource employeeBindingSource;
        private DataGridViewTextBoxColumn employeeNumDataGridViewTextBoxColumn;
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
        private Label label2;
        private TextBox lastNameSearchTextBox;
        private RadioButton nameRadioButton;
        private TextBox firstNameSearchTextBox;
        private RadioButton phoneNumberRadioButton;
        private TextBox phoneNumberTextBox;
        private TextBox memberIdTextBox;
        private RadioButton memberIDRadioButton;
        private Label label3;
        private Button customerSearchButton;
        private Button resetCustomerButton;
        private DataGridView customerGridView;
        private Button returnButton;
        private Button adminTableButton;
        private DataGridViewTextBoxColumn Employee_num;
        private DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn1;
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
        private DataGridViewTextBoxColumn Member_id;
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
        private DataGridViewTextBoxColumn furnitureidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stylenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentalrateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finerateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private Button deleteFurnitureButton;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private TextBox employeeLnameTextBox;
        private RadioButton employeeNameRadioButton;
        private TextBox employeeFnameTextBox;
        private RadioButton employeePhoneRadioButton;
        private TextBox employeePhoneTextBox;
        private TextBox employeeNumTextBox;
        private RadioButton employeeNumRadioButton;
    }
}