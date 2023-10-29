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
            addEmployeeButton = new Button();
            label1 = new Label();
            addCustomerButton = new Button();
            logoutButton = new Button();
            employeeDisplay = new TextBox();
            customerGridView = new DataGridView();
            customerBindingSource = new BindingSource(components);
            employeeGridView = new DataGridView();
            employeeBindingSource3 = new BindingSource(components);
            employeeBindingSource2 = new BindingSource(components);
            employeeBindingSource1 = new BindingSource(components);
            dashboardTabs = new TabControl();
            customersTab = new TabPage();
            employeesTab = new TabPage();
            rentButton = new Button();
            employeeBindingSource = new BindingSource(components);
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
            fullnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            employeeNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).BeginInit();
            dashboardTabs.SuspendLayout();
            customersTab.SuspendLayout();
            employeesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
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
            label1.Location = new Point(248, 16);
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
            customerGridView.RowTemplate.Height = 25;
            customerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerGridView.Size = new Size(617, 341);
            customerGridView.TabIndex = 10;
            customerGridView.RowStateChanged += customerGridView_RowStateChanged;
            customerGridView.MouseDoubleClick += customerGridView_MouseDoubleClick;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // employeeGridView
            // 
            employeeGridView.AutoGenerateColumns = false;
            employeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeGridView.Columns.AddRange(new DataGridViewColumn[] { fullnameDataGridViewTextBoxColumn1, employeeNumDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, fnameDataGridViewTextBoxColumn1, lnameDataGridViewTextBoxColumn1, dobDataGridViewTextBoxColumn1, genderDataGridViewTextBoxColumn1, phoneDataGridViewTextBoxColumn1, addressDataGridViewTextBoxColumn1, cityDataGridViewTextBoxColumn1, stateDataGridViewTextBoxColumn1, zipDataGridViewTextBoxColumn1, emailDataGridViewTextBoxColumn1, rolenameDataGridViewTextBoxColumn });
            employeeGridView.DataSource = employeeBindingSource3;
            employeeGridView.Location = new Point(146, 6);
            employeeGridView.Name = "employeeGridView";
            employeeGridView.ReadOnly = true;
            employeeGridView.RowHeadersVisible = false;
            employeeGridView.RowTemplate.Height = 25;
            employeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeGridView.Size = new Size(617, 341);
            employeeGridView.TabIndex = 11;
            employeeGridView.RowStateChanged += employeeGridView_RowStateChanged;
            employeeGridView.MouseDoubleClick += employeeGridView_MouseDoubleClick;
            // 
            // employeeBindingSource3
            // 
            employeeBindingSource3.DataSource = typeof(model.Employee);
            // 
            // employeeBindingSource2
            // 
            employeeBindingSource2.DataSource = typeof(model.Employee);
            // 
            // employeeBindingSource1
            // 
            employeeBindingSource1.DataSource = typeof(model.Employee);
            // 
            // dashboardTabs
            // 
            dashboardTabs.Controls.Add(customersTab);
            dashboardTabs.Controls.Add(employeesTab);
            dashboardTabs.Location = new Point(12, 57);
            dashboardTabs.Name = "dashboardTabs";
            dashboardTabs.SelectedIndex = 0;
            dashboardTabs.Size = new Size(777, 381);
            dashboardTabs.TabIndex = 12;
            // 
            // customersTab
            // 
            customersTab.Controls.Add(addCustomerButton);
            customersTab.Controls.Add(customerGridView);
            customersTab.Location = new Point(4, 24);
            customersTab.Name = "customersTab";
            customersTab.Padding = new Padding(3);
            customersTab.Size = new Size(769, 353);
            customersTab.TabIndex = 0;
            customersTab.Text = "Customers";
            customersTab.UseVisualStyleBackColor = true;
            // 
            // employeesTab
            // 
            employeesTab.Controls.Add(employeeGridView);
            employeesTab.Controls.Add(addEmployeeButton);
            employeesTab.Location = new Point(4, 24);
            employeesTab.Name = "employeesTab";
            employeesTab.Padding = new Padding(3);
            employeesTab.Size = new Size(769, 353);
            employeesTab.TabIndex = 1;
            employeesTab.Text = "Employees";
            employeesTab.UseVisualStyleBackColor = true;
            // 
            // rentButton
            // 
            rentButton.Location = new Point(22, 28);
            rentButton.Name = "rentButton";
            rentButton.Size = new Size(134, 23);
            rentButton.TabIndex = 13;
            rentButton.Text = "Rent Out Furniture";
            rentButton.UseVisualStyleBackColor = true;
            rentButton.Click += rentButton_Click;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(model.Employee);
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
            // fullnameDataGridViewTextBoxColumn1
            // 
            fullnameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fullnameDataGridViewTextBoxColumn1.DataPropertyName = "Fullname";
            fullnameDataGridViewTextBoxColumn1.HeaderText = "Fullname";
            fullnameDataGridViewTextBoxColumn1.Name = "fullnameDataGridViewTextBoxColumn1";
            fullnameDataGridViewTextBoxColumn1.ReadOnly = true;
            fullnameDataGridViewTextBoxColumn1.Width = 81;
            // 
            // employeeNumDataGridViewTextBoxColumn
            // 
            employeeNumDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNum";
            employeeNumDataGridViewTextBoxColumn.HeaderText = "EmployeeNum";
            employeeNumDataGridViewTextBoxColumn.Name = "employeeNumDataGridViewTextBoxColumn";
            employeeNumDataGridViewTextBoxColumn.ReadOnly = true;
            employeeNumDataGridViewTextBoxColumn.Visible = false;
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
            // MainScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rentButton);
            Controls.Add(dashboardTabs);
            Controls.Add(employeeDisplay);
            Controls.Add(logoutButton);
            Controls.Add(label1);
            Name = "MainScreenForm";
            Text = "MainScreenForm";
            ((System.ComponentModel.ISupportInitialize)customerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).EndInit();
            dashboardTabs.ResumeLayout(false);
            customersTab.ResumeLayout(false);
            employeesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
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
        private BindingSource employeeBindingSource1;
        private BindingSource employeeBindingSource2;
        private BindingSource employeeBindingSource3;
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
    }
}