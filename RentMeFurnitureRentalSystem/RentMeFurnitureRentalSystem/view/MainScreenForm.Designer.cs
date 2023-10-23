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
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.employeeDisplay = new System.Windows.Forms.TextBox();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.dashboardTabs = new System.Windows.Forms.TabControl();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.employeesTab = new System.Windows.Forms.TabPage();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.dashboardTabs.SuspendLayout();
            this.customersTab.SuspendLayout();
            this.employeesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(7, 8);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(153, 31);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee ";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rental Furniture System ";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(7, 8);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(153, 31);
            this.addCustomerButton.TabIndex = 2;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(749, 37);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(86, 31);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // employeeDisplay
            // 
            this.employeeDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.employeeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeDisplay.Location = new System.Drawing.Point(685, 15);
            this.employeeDisplay.Name = "employeeDisplay";
            this.employeeDisplay.Size = new System.Drawing.Size(213, 20);
            this.employeeDisplay.TabIndex = 7;
            this.employeeDisplay.Text = "USER";
            this.employeeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(167, 8);
            this.customerGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerGridView.MultiSelect = false;
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersVisible = false;
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.Height = 25;
            this.customerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGridView.Size = new System.Drawing.Size(705, 455);
            this.customerGridView.TabIndex = 10;
            this.customerGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.customerGridView_RowStateChanged);
            this.customerGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.customerGridView_MouseDoubleClick);
            // 
            // employeeGridView
            // 
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Location = new System.Drawing.Point(167, 8);
            this.employeeGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.ReadOnly = true;
            this.employeeGridView.RowHeadersVisible = false;
            this.employeeGridView.RowHeadersWidth = 51;
            this.employeeGridView.RowTemplate.Height = 25;
            this.employeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeGridView.Size = new System.Drawing.Size(705, 455);
            this.employeeGridView.TabIndex = 11;
            this.employeeGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.employeeGridView_RowStateChanged);
            this.employeeGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employeeGridView_MouseDoubleClick);
            // 
            // dashboardTabs
            // 
            this.dashboardTabs.Controls.Add(this.customersTab);
            this.dashboardTabs.Controls.Add(this.employeesTab);
            this.dashboardTabs.Location = new System.Drawing.Point(14, 76);
            this.dashboardTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboardTabs.Name = "dashboardTabs";
            this.dashboardTabs.SelectedIndex = 0;
            this.dashboardTabs.Size = new System.Drawing.Size(888, 508);
            this.dashboardTabs.TabIndex = 12;
            this.dashboardTabs.SelectedIndexChanged += new System.EventHandler(this.dashboardTabs_SelectedIndexChanged);
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.deleteCustomerButton);
            this.customersTab.Controls.Add(this.addCustomerButton);
            this.customersTab.Controls.Add(this.customerGridView);
            this.customersTab.Location = new System.Drawing.Point(4, 29);
            this.customersTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersTab.Size = new System.Drawing.Size(880, 475);
            this.customersTab.TabIndex = 0;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(8, 47);
            this.deleteCustomerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(153, 31);
            this.deleteCustomerButton.TabIndex = 11;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.deleteEmployeeButton);
            this.employeesTab.Controls.Add(this.employeeGridView);
            this.employeesTab.Controls.Add(this.addEmployeeButton);
            this.employeesTab.Location = new System.Drawing.Point(4, 29);
            this.employeesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesTab.Size = new System.Drawing.Size(880, 475);
            this.employeesTab.TabIndex = 1;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(8, 47);
            this.deleteEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(153, 31);
            this.deleteEmployeeButton.TabIndex = 12;
            this.deleteEmployeeButton.Text = "Delete Employee ";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.dashboardTabs);
            this.Controls.Add(this.employeeDisplay);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainScreenForm";
            this.Text = "MainScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.dashboardTabs.ResumeLayout(false);
            this.customersTab.ResumeLayout(false);
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
        private Button deleteCustomerButton;
        private Button deleteEmployeeButton;
    }
}