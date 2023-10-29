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
            deleteCustomerButton = new Button();
            employeesTab = new TabPage();
            deleteEmployeeButton = new Button();
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
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).BeginInit();
            dashboardTabs.SuspendLayout();
            customersTab.SuspendLayout();
            employeesTab.SuspendLayout();
            furnitureTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)furnitureGridView).BeginInit();
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
            customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // employeeGridView
            // 
            employeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // dashboardTabs
            // 
            dashboardTabs.Controls.Add(customersTab);
            dashboardTabs.Controls.Add(employeesTab);
            dashboardTabs.Controls.Add(furnitureTabpage);
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
            furnitureGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            furnitureGridView.Location = new Point(146, 37);
            furnitureGridView.MultiSelect = false;
            furnitureGridView.Name = "furnitureGridView";
            furnitureGridView.ReadOnly = true;
            furnitureGridView.RowTemplate.Height = 25;
            furnitureGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            furnitureGridView.Size = new Size(614, 289);
            furnitureGridView.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)employeeGridView).EndInit();
            dashboardTabs.ResumeLayout(false);
            customersTab.ResumeLayout(false);
            employeesTab.ResumeLayout(false);
            furnitureTabpage.ResumeLayout(false);
            furnitureTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)furnitureGridView).EndInit();
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
    }
}