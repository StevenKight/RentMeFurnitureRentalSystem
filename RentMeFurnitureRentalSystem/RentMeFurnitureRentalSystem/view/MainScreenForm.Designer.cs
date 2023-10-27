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
            this.furnitureTabpage = new System.Windows.Forms.TabPage();
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
            this.customerGridView.Location = new System.Drawing.Point(146, 6);
            this.customerGridView.MultiSelect = false;
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersVisible = false;
            this.customerGridView.RowTemplate.Height = 25;
            this.customerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGridView.Size = new System.Drawing.Size(617, 341);
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
            // furnitureTabpage
            // 
            this.furnitureTabpage.Controls.Add(this.addFurnitureButton);
            this.furnitureTabpage.Controls.Add(this.furnitureGridView);
            this.furnitureTabpage.Location = new System.Drawing.Point(4, 24);
            this.furnitureTabpage.Name = "furnitureTabpage";
            this.furnitureTabpage.Size = new System.Drawing.Size(769, 353);
            this.furnitureTabpage.TabIndex = 2;
            this.furnitureTabpage.Text = "Furniture";
            this.furnitureTabpage.UseVisualStyleBackColor = true;
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
            this.furnitureGridView.Location = new System.Drawing.Point(146, 6);
            this.furnitureGridView.Name = "furnitureGridView";
            this.furnitureGridView.RowTemplate.Height = 25;
            this.furnitureGridView.Size = new System.Drawing.Size(617, 341);
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
            this.furnitureTabpage.ResumeLayout(false);
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
    }
}