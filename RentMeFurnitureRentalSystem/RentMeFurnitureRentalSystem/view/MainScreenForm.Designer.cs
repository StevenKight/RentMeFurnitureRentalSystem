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
            addEmployeeButton = new Button();
            label1 = new Label();
            addCustomerButton = new Button();
            logoutButton = new Button();
            employeeDisplay = new TextBox();
            customerGridView = new DataGridView();
            employeeGridView = new DataGridView();
            dashboardTabs = new TabControl();
            customersTab = new TabPage();
            employeesTab = new TabPage();
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).BeginInit();
            dashboardTabs.SuspendLayout();
            customersTab.SuspendLayout();
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
            logoutButton.Location = new Point(599, 28);
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
            employeeDisplay.Location = new Point(680, 32);
            employeeDisplay.Margin = new Padding(3, 2, 3, 2);
            employeeDisplay.Name = "employeeDisplay";
            employeeDisplay.Size = new Size(109, 16);
            employeeDisplay.TabIndex = 7;
            employeeDisplay.Text = "USER";
            employeeDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // customerGridView
            // 
            customerGridView.AllowUserToAddRows = false;
            customerGridView.AllowUserToDeleteRows = false;
            customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // employeeGridView
            // 
            employeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // MainScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dashboardTabs);
            Controls.Add(employeeDisplay);
            Controls.Add(logoutButton);
            Controls.Add(label1);
            Name = "MainScreenForm";
            Text = "MainScreenForm";
            ((System.ComponentModel.ISupportInitialize)customerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).EndInit();
            dashboardTabs.ResumeLayout(false);
            customersTab.ResumeLayout(false);
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
    }
}