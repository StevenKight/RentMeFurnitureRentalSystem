using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.View
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            this.addEmployeeButton = new Button();
            this.label1 = new Label();
            this.addCustomerButton = new Button();
            this.logoutButton = new Button();
            this.employeeDisplay = new TextBox();
            this.customerBindingSource = new BindingSource(this.components);
            this.customerSearchButton = new Button();
            this.label3 = new Label();
            this.label2 = new Label();
            this.lastNameSearchTextBox = new TextBox();
            this.nameRadioButton = new RadioButton();
            this.firstNameSearchTextBox = new TextBox();
            this.phoneNumberRadioButton = new RadioButton();
            this.phoneNumberTextBox = new TextBox();
            this.memberIdTextBox = new TextBox();
            this.memberIDRadioButton = new RadioButton();
            this.employeeGridView = new DataGridView();
            this.Employee_num = new DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.rolenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.employeeBindingSource = new BindingSource(this.components);
            this.dashboardTabs = new TabControl();
            this.customersTab = new TabPage();
            this.returnButton = new Button();
            this.rentButton = new Button();
            this.resetCustomerButton = new Button();
            this.deleteCustomerButton = new Button();
            this.customerGridView = new DataGridView();
            this.Member_id = new DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.registerdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.furnitureTabpage = new TabPage();
            this.deleteFurnitureButton = new Button();
            this.resetButton = new Button();
            this.categoryRadioButton = new RadioButton();
            this.StyleRadioButton = new RadioButton();
            this.categoryComboBox = new ComboBox();
            this.styleComboBox = new ComboBox();
            this.IdRadioButton = new RadioButton();
            this.furnitureSearchTextBox = new TextBox();
            this.furnitureSearchButton = new Button();
            this.addFurnitureButton = new Button();
            this.furnitureGridView = new DataGridView();
            this.furnitureidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.stylenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.rentalrateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.finerateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.furnitureBindingSource = new BindingSource(this.components);
            this.employeesTab = new TabPage();
            this.button1 = new Button();
            this.button2 = new Button();
            this.label4 = new Label();
            this.label5 = new Label();
            this.employeeLnameTextBox = new TextBox();
            this.employeeNameRadioButton = new RadioButton();
            this.employeeFnameTextBox = new TextBox();
            this.employeePhoneRadioButton = new RadioButton();
            this.employeePhoneTextBox = new TextBox();
            this.employeeNumTextBox = new TextBox();
            this.employeeNumRadioButton = new RadioButton();
            this.deleteEmployeeButton = new Button();
            this.adminTableButton = new Button();
            ((System.ComponentModel.ISupportInitialize)this.customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.employeeGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.employeeBindingSource).BeginInit();
            this.dashboardTabs.SuspendLayout();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.customerGridView).BeginInit();
            this.furnitureTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.furnitureGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.furnitureBindingSource).BeginInit();
            this.employeesTab.SuspendLayout();
            SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new Point(6, 6);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new Size(135, 25);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee ";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += this.addEmployeeButton_Click;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            this.label1.Location = new Point(283, 21);
            this.label1.Name = "label1";
            this.label1.Size = new Size(301, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rental Furniture System ";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new Point(6, 6);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new Size(135, 25);
            this.addCustomerButton.TabIndex = 2;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += this.addCustomerButton_Click;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new Point(659, 39);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += this.logoutButton_Click;
            // 
            // employeeDisplay
            // 
            this.employeeDisplay.BackColor = SystemColors.Control;
            this.employeeDisplay.BorderStyle = BorderStyle.None;
            this.employeeDisplay.Location = new Point(615, 18);
            this.employeeDisplay.Margin = new Padding(3, 2, 3, 2);
            this.employeeDisplay.Name = "employeeDisplay";
            this.employeeDisplay.Size = new Size(163, 16);
            this.employeeDisplay.TabIndex = 7;
            this.employeeDisplay.Text = "USER";
            this.employeeDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.Location = new Point(593, 8);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new Size(75, 23);
            this.customerSearchButton.TabIndex = 20;
            this.customerSearchButton.Text = "Search";
            this.customerSearchButton.UseVisualStyleBackColor = true;
            this.customerSearchButton.Click += this.customerSearchButton_Click;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(450, 41);
            this.label3.Name = "label3";
            this.label3.Size = new Size(66, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(215, 41);
            this.label2.Name = "label2";
            this.label2.Size = new Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "First Name:";
            // 
            // lastNameSearchTextBox
            // 
            this.lastNameSearchTextBox.Location = new Point(522, 38);
            this.lastNameSearchTextBox.Name = "lastNameSearchTextBox";
            this.lastNameSearchTextBox.Size = new Size(159, 23);
            this.lastNameSearchTextBox.TabIndex = 17;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new Point(152, 39);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new Size(57, 19);
            this.nameRadioButton.TabIndex = 16;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstNameSearchTextBox
            // 
            this.firstNameSearchTextBox.Location = new Point(288, 38);
            this.firstNameSearchTextBox.Name = "firstNameSearchTextBox";
            this.firstNameSearchTextBox.Size = new Size(156, 23);
            this.firstNameSearchTextBox.TabIndex = 15;
            // 
            // phoneNumberRadioButton
            // 
            this.phoneNumberRadioButton.AutoSize = true;
            this.phoneNumberRadioButton.Location = new Point(335, 10);
            this.phoneNumberRadioButton.Name = "phoneNumberRadioButton";
            this.phoneNumberRadioButton.Size = new Size(109, 19);
            this.phoneNumberRadioButton.TabIndex = 14;
            this.phoneNumberRadioButton.Text = "Phone Number:";
            this.phoneNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new Point(450, 8);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new Size(137, 23);
            this.phoneNumberTextBox.TabIndex = 13;
            // 
            // memberIdTextBox
            // 
            this.memberIdTextBox.Location = new Point(245, 8);
            this.memberIdTextBox.Name = "memberIdTextBox";
            this.memberIdTextBox.Size = new Size(84, 23);
            this.memberIdTextBox.TabIndex = 12;
            // 
            // memberIDRadioButton
            // 
            this.memberIDRadioButton.AutoSize = true;
            this.memberIDRadioButton.Checked = true;
            this.memberIDRadioButton.Location = new Point(152, 10);
            this.memberIDRadioButton.Name = "memberIDRadioButton";
            this.memberIDRadioButton.Size = new Size(86, 19);
            this.memberIDRadioButton.TabIndex = 11;
            this.memberIDRadioButton.TabStop = true;
            this.memberIDRadioButton.Text = "Member Id:";
            this.memberIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeGridView
            // 
            this.employeeGridView.AutoGenerateColumns = false;
            this.employeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Columns.AddRange(new DataGridViewColumn[] { this.Employee_num, this.fullnameDataGridViewTextBoxColumn1, this.usernameDataGridViewTextBoxColumn, this.passwordDataGridViewTextBoxColumn, this.fnameDataGridViewTextBoxColumn1, this.lnameDataGridViewTextBoxColumn1, this.dobDataGridViewTextBoxColumn1, this.genderDataGridViewTextBoxColumn1, this.phoneDataGridViewTextBoxColumn1, this.addressDataGridViewTextBoxColumn1, this.cityDataGridViewTextBoxColumn1, this.stateDataGridViewTextBoxColumn1, this.zipDataGridViewTextBoxColumn1, this.emailDataGridViewTextBoxColumn1, this.rolenameDataGridViewTextBoxColumn });
            this.employeeGridView.DataSource = this.employeeBindingSource;
            this.employeeGridView.Location = new Point(143, 67);
            this.employeeGridView.Margin = new Padding(3, 4, 3, 4);
            this.employeeGridView.MultiSelect = false;
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.ReadOnly = true;
            this.employeeGridView.RowHeadersVisible = false;
            this.employeeGridView.RowHeadersWidth = 51;
            this.employeeGridView.RowTemplate.Height = 25;
            this.employeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.employeeGridView.Size = new Size(617, 259);
            this.employeeGridView.TabIndex = 11;
            this.employeeGridView.RowStateChanged += this.employeeGridView_RowStateChanged;
            this.employeeGridView.MouseDoubleClick += this.employeeGridView_MouseDoubleClick;
            // 
            // Employee_num
            // 
            this.Employee_num.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Employee_num.DataPropertyName = "Employee_num";
            this.Employee_num.HeaderText = "Employee Num";
            this.Employee_num.Name = "Employee_num";
            this.Employee_num.ReadOnly = true;
            this.Employee_num.Width = 75;
            // 
            // fullnameDataGridViewTextBoxColumn1
            // 
            this.fullnameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.fullnameDataGridViewTextBoxColumn1.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn1.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn1.Name = "fullnameDataGridViewTextBoxColumn1";
            this.fullnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn1.Width = 81;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Visible = false;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn1
            // 
            this.fnameDataGridViewTextBoxColumn1.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn1.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn1.Name = "fnameDataGridViewTextBoxColumn1";
            this.fnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fnameDataGridViewTextBoxColumn1.Visible = false;
            this.fnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn1
            // 
            this.lnameDataGridViewTextBoxColumn1.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn1.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn1.Name = "lnameDataGridViewTextBoxColumn1";
            this.lnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lnameDataGridViewTextBoxColumn1.Visible = false;
            this.lnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn1
            // 
            this.dobDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dobDataGridViewTextBoxColumn1.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn1.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn1.Name = "dobDataGridViewTextBoxColumn1";
            this.dobDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn1.Width = 54;
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            this.genderDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.genderDataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            this.genderDataGridViewTextBoxColumn1.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn1.Width = 70;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn1.Width = 66;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn1.Visible = false;
            this.addressDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn1.Visible = false;
            this.cityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            this.stateDataGridViewTextBoxColumn1.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn1.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            this.stateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn1.Visible = false;
            this.stateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // zipDataGridViewTextBoxColumn1
            // 
            this.zipDataGridViewTextBoxColumn1.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn1.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.zipDataGridViewTextBoxColumn1.Name = "zipDataGridViewTextBoxColumn1";
            this.zipDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zipDataGridViewTextBoxColumn1.Visible = false;
            this.zipDataGridViewTextBoxColumn1.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn1.Width = 61;
            // 
            // rolenameDataGridViewTextBoxColumn
            // 
            this.rolenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.rolenameDataGridViewTextBoxColumn.DataPropertyName = "Role_name";
            this.rolenameDataGridViewTextBoxColumn.HeaderText = "Role";
            this.rolenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolenameDataGridViewTextBoxColumn.Name = "rolenameDataGridViewTextBoxColumn";
            this.rolenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Employee);
            // 
            // dashboardTabs
            // 
            this.dashboardTabs.Controls.Add(this.customersTab);
            this.dashboardTabs.Controls.Add(this.furnitureTabpage);
            this.dashboardTabs.Controls.Add(this.employeesTab);
            this.dashboardTabs.Location = new Point(14, 76);
            this.dashboardTabs.Margin = new Padding(3, 4, 3, 4);
            this.dashboardTabs.Name = "dashboardTabs";
            this.dashboardTabs.SelectedIndex = 0;
            this.dashboardTabs.Size = new Size(774, 361);
            this.dashboardTabs.TabIndex = 12;
            this.dashboardTabs.SelectedIndexChanged += this.dashboardTabs_SelectedIndexChanged;
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.returnButton);
            this.customersTab.Controls.Add(this.rentButton);
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
            this.customersTab.Controls.Add(this.deleteCustomerButton);
            this.customersTab.Controls.Add(this.addCustomerButton);
            this.customersTab.Controls.Add(this.customerGridView);
            this.customersTab.Location = new Point(4, 24);
            this.customersTab.Margin = new Padding(3, 4, 3, 4);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new Padding(3, 4, 3, 4);
            this.customersTab.Size = new Size(766, 333);
            this.customersTab.TabIndex = 0;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new Point(6, 101);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new Size(135, 25);
            this.returnButton.TabIndex = 22;
            this.returnButton.Text = "Return Furniture";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += this.returnButton_Click;
            // 
            // rentButton
            // 
            this.rentButton.Location = new Point(6, 70);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new Size(135, 25);
            this.rentButton.TabIndex = 13;
            this.rentButton.Text = "Rent Furniture";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += this.rentButton_Click;
            // 
            // resetCustomerButton
            // 
            this.resetCustomerButton.Location = new Point(674, 8);
            this.resetCustomerButton.Name = "resetCustomerButton";
            this.resetCustomerButton.Size = new Size(75, 23);
            this.resetCustomerButton.TabIndex = 21;
            this.resetCustomerButton.Text = "Reset";
            this.resetCustomerButton.UseVisualStyleBackColor = true;
            this.resetCustomerButton.Click += this.resetCustomerButton_Click;
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new Point(6, 38);
            this.deleteCustomerButton.Margin = new Padding(3, 4, 3, 4);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new Size(135, 25);
            this.deleteCustomerButton.TabIndex = 11;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += this.deleteCustomerButton_Click;
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.AutoGenerateColumns = false;
            this.customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Columns.AddRange(new DataGridViewColumn[] { this.Member_id, this.fullnameDataGridViewTextBoxColumn, this.fnameDataGridViewTextBoxColumn, this.lnameDataGridViewTextBoxColumn, this.dobDataGridViewTextBoxColumn, this.genderDataGridViewTextBoxColumn, this.phoneDataGridViewTextBoxColumn, this.emailDataGridViewTextBoxColumn, this.addressDataGridViewTextBoxColumn, this.cityDataGridViewTextBoxColumn, this.stateDataGridViewTextBoxColumn, this.zipDataGridViewTextBoxColumn, this.registerdateDataGridViewTextBoxColumn });
            this.customerGridView.DataSource = this.customerBindingSource;
            this.customerGridView.Location = new Point(143, 67);
            this.customerGridView.MultiSelect = false;
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersVisible = false;
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.Height = 25;
            this.customerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.customerGridView.Size = new Size(617, 259);
            this.customerGridView.TabIndex = 10;
            this.customerGridView.RowStateChanged += this.customerGridView_RowStateChanged;
            this.customerGridView.MouseDoubleClick += this.customerGridView_MouseDoubleClick;
            // 
            // Member_id
            // 
            this.Member_id.DataPropertyName = "Member_id";
            this.Member_id.HeaderText = "Member Id";
            this.Member_id.Name = "Member_id";
            this.Member_id.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Width = 81;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnameDataGridViewTextBoxColumn.Visible = false;
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lnameDataGridViewTextBoxColumn.Visible = false;
            this.lnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Width = 54;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 70;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 66;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 61;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Visible = false;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Visible = false;
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Visible = false;
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            this.zipDataGridViewTextBoxColumn.ReadOnly = true;
            this.zipDataGridViewTextBoxColumn.Visible = false;
            this.zipDataGridViewTextBoxColumn.Width = 125;
            // 
            // registerdateDataGridViewTextBoxColumn
            // 
            this.registerdateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.registerdateDataGridViewTextBoxColumn.DataPropertyName = "Register_date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.registerdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.registerdateDataGridViewTextBoxColumn.HeaderText = "Register Date";
            this.registerdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registerdateDataGridViewTextBoxColumn.Name = "registerdateDataGridViewTextBoxColumn";
            this.registerdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // furnitureTabpage
            // 
            this.furnitureTabpage.Controls.Add(this.deleteFurnitureButton);
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
            this.furnitureTabpage.Location = new Point(4, 24);
            this.furnitureTabpage.Name = "furnitureTabpage";
            this.furnitureTabpage.Size = new Size(766, 333);
            this.furnitureTabpage.TabIndex = 2;
            this.furnitureTabpage.Text = "Furniture";
            this.furnitureTabpage.UseVisualStyleBackColor = true;
            // 
            // deleteFurnitureButton
            // 
            this.deleteFurnitureButton.Location = new Point(6, 38);
            this.deleteFurnitureButton.Margin = new Padding(3, 4, 3, 4);
            this.deleteFurnitureButton.Name = "deleteFurnitureButton";
            this.deleteFurnitureButton.Size = new Size(135, 25);
            this.deleteFurnitureButton.TabIndex = 12;
            this.deleteFurnitureButton.Text = "Delete Furniture";
            this.deleteFurnitureButton.UseVisualStyleBackColor = true;
            this.deleteFurnitureButton.Click += this.deleteFurnitureButton_Click;
            // 
            // resetButton
            // 
            this.resetButton.Location = new Point(710, 7);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new Size(49, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += this.resetButton_Click;
            // 
            // categoryRadioButton
            // 
            this.categoryRadioButton.AutoSize = true;
            this.categoryRadioButton.Location = new Point(464, 9);
            this.categoryRadioButton.Name = "categoryRadioButton";
            this.categoryRadioButton.Size = new Size(73, 19);
            this.categoryRadioButton.TabIndex = 8;
            this.categoryRadioButton.Text = "Category";
            this.categoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // StyleRadioButton
            // 
            this.StyleRadioButton.AutoSize = true;
            this.StyleRadioButton.Location = new Point(308, 9);
            this.StyleRadioButton.Name = "StyleRadioButton";
            this.StyleRadioButton.Size = new Size(50, 19);
            this.StyleRadioButton.TabIndex = 7;
            this.StyleRadioButton.Text = "Style";
            this.StyleRadioButton.UseVisualStyleBackColor = true;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new Point(542, 8);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new Size(106, 23);
            this.categoryComboBox.TabIndex = 6;
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new Point(363, 8);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new Size(95, 23);
            this.styleComboBox.TabIndex = 5;
            // 
            // IdRadioButton
            // 
            this.IdRadioButton.AutoSize = true;
            this.IdRadioButton.Checked = true;
            this.IdRadioButton.Location = new Point(145, 9);
            this.IdRadioButton.Name = "IdRadioButton";
            this.IdRadioButton.Size = new Size(86, 19);
            this.IdRadioButton.TabIndex = 4;
            this.IdRadioButton.TabStop = true;
            this.IdRadioButton.Text = "Furniture Id";
            this.IdRadioButton.UseVisualStyleBackColor = true;
            // 
            // furnitureSearchTextBox
            // 
            this.furnitureSearchTextBox.Location = new Point(236, 8);
            this.furnitureSearchTextBox.Name = "furnitureSearchTextBox";
            this.furnitureSearchTextBox.Size = new Size(66, 23);
            this.furnitureSearchTextBox.TabIndex = 3;
            // 
            // furnitureSearchButton
            // 
            this.furnitureSearchButton.Location = new Point(653, 7);
            this.furnitureSearchButton.Name = "furnitureSearchButton";
            this.furnitureSearchButton.Size = new Size(57, 23);
            this.furnitureSearchButton.TabIndex = 2;
            this.furnitureSearchButton.Text = "Search";
            this.furnitureSearchButton.UseVisualStyleBackColor = true;
            this.furnitureSearchButton.Click += this.furnitureSearchButton_Click;
            // 
            // addFurnitureButton
            // 
            this.addFurnitureButton.Location = new Point(6, 6);
            this.addFurnitureButton.Name = "addFurnitureButton";
            this.addFurnitureButton.Size = new Size(135, 25);
            this.addFurnitureButton.TabIndex = 1;
            this.addFurnitureButton.Text = "Add Furniture";
            this.addFurnitureButton.UseVisualStyleBackColor = true;
            this.addFurnitureButton.Click += this.addFurnitureButton_Click;
            // 
            // furnitureGridView
            // 
            this.furnitureGridView.AutoGenerateColumns = false;
            this.furnitureGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureGridView.Columns.AddRange(new DataGridViewColumn[] { this.furnitureidDataGridViewTextBoxColumn, this.nameDataGridViewTextBoxColumn, this.categorynameDataGridViewTextBoxColumn, this.stylenameDataGridViewTextBoxColumn, this.descriptionDataGridViewTextBoxColumn, this.rentalrateDataGridViewTextBoxColumn, this.finerateDataGridViewTextBoxColumn, this.quantityDataGridViewTextBoxColumn });
            this.furnitureGridView.DataSource = this.furnitureBindingSource;
            this.furnitureGridView.Location = new Point(146, 37);
            this.furnitureGridView.MultiSelect = false;
            this.furnitureGridView.Name = "furnitureGridView";
            this.furnitureGridView.ReadOnly = true;
            this.furnitureGridView.RowHeadersVisible = false;
            this.furnitureGridView.RowHeadersWidth = 51;
            this.furnitureGridView.RowTemplate.Height = 25;
            this.furnitureGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.furnitureGridView.Size = new Size(614, 289);
            this.furnitureGridView.TabIndex = 0;
            this.furnitureGridView.RowStateChanged += this.furnitureGridView_RowStateChanged;
            this.furnitureGridView.MouseDoubleClick += this.furnitureGridView_MouseDoubleClick;
            // 
            // furnitureidDataGridViewTextBoxColumn
            // 
            this.furnitureidDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.furnitureidDataGridViewTextBoxColumn.DataPropertyName = "Furniture_id";
            this.furnitureidDataGridViewTextBoxColumn.HeaderText = "Furniture Id";
            this.furnitureidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.furnitureidDataGridViewTextBoxColumn.Name = "furnitureidDataGridViewTextBoxColumn";
            this.furnitureidDataGridViewTextBoxColumn.ReadOnly = true;
            this.furnitureidDataGridViewTextBoxColumn.Width = 93;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 64;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "Category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categorynameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorynameDataGridViewTextBoxColumn.Width = 80;
            // 
            // stylenameDataGridViewTextBoxColumn
            // 
            this.stylenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.stylenameDataGridViewTextBoxColumn.DataPropertyName = "Style_name";
            this.stylenameDataGridViewTextBoxColumn.HeaderText = "Style";
            this.stylenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stylenameDataGridViewTextBoxColumn.Name = "stylenameDataGridViewTextBoxColumn";
            this.stylenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stylenameDataGridViewTextBoxColumn.Width = 57;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // rentalrateDataGridViewTextBoxColumn
            // 
            this.rentalrateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.rentalrateDataGridViewTextBoxColumn.DataPropertyName = "Rental_rate";
            this.rentalrateDataGridViewTextBoxColumn.HeaderText = "Rental Rate";
            this.rentalrateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalrateDataGridViewTextBoxColumn.Name = "rentalrateDataGridViewTextBoxColumn";
            this.rentalrateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentalrateDataGridViewTextBoxColumn.Width = 91;
            // 
            // finerateDataGridViewTextBoxColumn
            // 
            this.finerateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.finerateDataGridViewTextBoxColumn.DataPropertyName = "Fine_rate";
            this.finerateDataGridViewTextBoxColumn.HeaderText = "Fine Rate";
            this.finerateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finerateDataGridViewTextBoxColumn.Name = "finerateDataGridViewTextBoxColumn";
            this.finerateDataGridViewTextBoxColumn.ReadOnly = true;
            this.finerateDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(Furniture);
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.button1);
            this.employeesTab.Controls.Add(this.button2);
            this.employeesTab.Controls.Add(this.label4);
            this.employeesTab.Controls.Add(this.label5);
            this.employeesTab.Controls.Add(this.employeeLnameTextBox);
            this.employeesTab.Controls.Add(this.employeeNameRadioButton);
            this.employeesTab.Controls.Add(this.employeeFnameTextBox);
            this.employeesTab.Controls.Add(this.employeePhoneRadioButton);
            this.employeesTab.Controls.Add(this.employeePhoneTextBox);
            this.employeesTab.Controls.Add(this.employeeNumTextBox);
            this.employeesTab.Controls.Add(this.employeeNumRadioButton);
            this.employeesTab.Controls.Add(this.deleteEmployeeButton);
            this.employeesTab.Controls.Add(this.employeeGridView);
            this.employeesTab.Controls.Add(this.addEmployeeButton);
            this.employeesTab.Location = new Point(4, 24);
            this.employeesTab.Margin = new Padding(3, 4, 3, 4);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new Padding(3);
            this.employeesTab.Size = new Size(766, 333);
            this.employeesTab.TabIndex = 1;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new Point(679, 8);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.resetEmployeeButton_Click;
            // 
            // button2
            // 
            this.button2.Location = new Point(598, 8);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.employeeSearchButton_Click;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(450, 41);
            this.label4.Name = "label4";
            this.label4.Size = new Size(66, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(215, 41);
            this.label5.Name = "label5";
            this.label5.Size = new Size(67, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "First Name:";
            // 
            // employeeLnameTextBox
            // 
            this.employeeLnameTextBox.Location = new Point(522, 38);
            this.employeeLnameTextBox.Name = "employeeLnameTextBox";
            this.employeeLnameTextBox.Size = new Size(159, 23);
            this.employeeLnameTextBox.TabIndex = 28;
            // 
            // employeeNameRadioButton
            // 
            this.employeeNameRadioButton.AutoSize = true;
            this.employeeNameRadioButton.Location = new Point(152, 39);
            this.employeeNameRadioButton.Name = "employeeNameRadioButton";
            this.employeeNameRadioButton.Size = new Size(57, 19);
            this.employeeNameRadioButton.TabIndex = 27;
            this.employeeNameRadioButton.Text = "Name";
            this.employeeNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeFnameTextBox
            // 
            this.employeeFnameTextBox.Location = new Point(288, 38);
            this.employeeFnameTextBox.Name = "employeeFnameTextBox";
            this.employeeFnameTextBox.Size = new Size(156, 23);
            this.employeeFnameTextBox.TabIndex = 26;
            // 
            // employeePhoneRadioButton
            // 
            this.employeePhoneRadioButton.AutoSize = true;
            this.employeePhoneRadioButton.Location = new Point(348, 10);
            this.employeePhoneRadioButton.Name = "employeePhoneRadioButton";
            this.employeePhoneRadioButton.Size = new Size(109, 19);
            this.employeePhoneRadioButton.TabIndex = 25;
            this.employeePhoneRadioButton.Text = "Phone Number:";
            this.employeePhoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeePhoneTextBox
            // 
            this.employeePhoneTextBox.Location = new Point(457, 8);
            this.employeePhoneTextBox.Name = "employeePhoneTextBox";
            this.employeePhoneTextBox.Size = new Size(137, 23);
            this.employeePhoneTextBox.TabIndex = 24;
            // 
            // employeeNumTextBox
            // 
            this.employeeNumTextBox.Location = new Point(258, 8);
            this.employeeNumTextBox.Name = "employeeNumTextBox";
            this.employeeNumTextBox.Size = new Size(84, 23);
            this.employeeNumTextBox.TabIndex = 23;
            // 
            // employeeNumRadioButton
            // 
            this.employeeNumRadioButton.AutoSize = true;
            this.employeeNumRadioButton.Checked = true;
            this.employeeNumRadioButton.Location = new Point(152, 10);
            this.employeeNumRadioButton.Name = "employeeNumRadioButton";
            this.employeeNumRadioButton.Size = new Size(108, 19);
            this.employeeNumRadioButton.TabIndex = 22;
            this.employeeNumRadioButton.TabStop = true;
            this.employeeNumRadioButton.Text = "Employee num:";
            this.employeeNumRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new Point(6, 37);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new Size(135, 25);
            this.deleteEmployeeButton.TabIndex = 12;
            this.deleteEmployeeButton.Text = "Delete Employee ";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += this.deleteEmployeeButton_Click;
            // 
            // adminTableButton
            // 
            this.adminTableButton.Location = new Point(52, 32);
            this.adminTableButton.Margin = new Padding(3, 2, 3, 2);
            this.adminTableButton.Name = "adminTableButton";
            this.adminTableButton.Size = new Size(106, 26);
            this.adminTableButton.TabIndex = 13;
            this.adminTableButton.Text = "Admin Tools";
            this.adminTableButton.UseVisualStyleBackColor = true;
            this.adminTableButton.Click += this.adminTableButton_Click;
            // 
            // MainScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.adminTableButton);
            Controls.Add(this.dashboardTabs);
            Controls.Add(this.employeeDisplay);
            Controls.Add(this.logoutButton);
            Controls.Add(this.label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainScreenForm";
            Text = "MainScreenForm";
            ((System.ComponentModel.ISupportInitialize)this.customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.employeeGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.employeeBindingSource).EndInit();
            this.dashboardTabs.ResumeLayout(false);
            this.customersTab.ResumeLayout(false);
            this.customersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.customerGridView).EndInit();
            this.furnitureTabpage.ResumeLayout(false);
            this.furnitureTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.furnitureGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.furnitureBindingSource).EndInit();
            this.employeesTab.ResumeLayout(false);
            this.employeesTab.PerformLayout();
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