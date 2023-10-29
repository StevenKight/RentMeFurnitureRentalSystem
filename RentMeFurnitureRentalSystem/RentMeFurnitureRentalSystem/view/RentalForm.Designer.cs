namespace RentMeFurnitureRentalSystem.view
{
    partial class RentalForm
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
            addDialogHeading = new Label();
            cancelButton = new Button();
            submitButton = new Button();
            userDataGridView = new DataGridView();
            fullnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            zipDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registerdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // addDialogHeading
            // 
            addDialogHeading.AutoSize = true;
            addDialogHeading.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addDialogHeading.Location = new Point(293, 31);
            addDialogHeading.Name = "addDialogHeading";
            addDialogHeading.Size = new Size(80, 32);
            addDialogHeading.TabIndex = 1;
            addDialogHeading.Text = "Rental";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(174, 311);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 23);
            cancelButton.TabIndex = 26;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(372, 311);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(127, 23);
            submitButton.TabIndex = 25;
            submitButton.Text = "Submit Rental";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // userDataGridView
            // 
            userDataGridView.AutoGenerateColumns = false;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Columns.AddRange(new DataGridViewColumn[] { fullnameDataGridViewTextBoxColumn, fnameDataGridViewTextBoxColumn, lnameDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, zipDataGridViewTextBoxColumn, registerdateDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            userDataGridView.DataSource = customerBindingSource;
            userDataGridView.Location = new Point(12, 105);
            userDataGridView.MultiSelect = false;
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersVisible = false;
            userDataGridView.RowTemplate.Height = 25;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGridView.Size = new Size(300, 192);
            userDataGridView.TabIndex = 27;
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
            fnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            lnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            dobDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.Width = 66;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "State";
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.Visible = false;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            zipDataGridViewTextBoxColumn.Visible = false;
            // 
            // registerdateDataGridViewTextBoxColumn
            // 
            registerdateDataGridViewTextBoxColumn.DataPropertyName = "Register_date";
            registerdateDataGridViewTextBoxColumn.HeaderText = "Register_date";
            registerdateDataGridViewTextBoxColumn.Name = "registerdateDataGridViewTextBoxColumn";
            registerdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // furnitureGridView
            // 
            furnitureGridView.AllowUserToAddRows = false;
            furnitureGridView.AllowUserToDeleteRows = false;
            furnitureGridView.AutoGenerateColumns = false;
            furnitureGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            furnitureGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            furnitureGridView.Columns.AddRange(new DataGridViewColumn[] { furnitureidDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categorynameDataGridViewTextBoxColumn, stylenameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, rentalrateDataGridViewTextBoxColumn, finerateDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            furnitureGridView.DataSource = furnitureBindingSource;
            furnitureGridView.Location = new Point(318, 105);
            furnitureGridView.MultiSelect = false;
            furnitureGridView.Name = "furnitureGridView";
            furnitureGridView.RowHeadersVisible = false;
            furnitureGridView.RowTemplate.Height = 25;
            furnitureGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            furnitureGridView.Size = new Size(339, 192);
            furnitureGridView.TabIndex = 28;
            furnitureGridView.CellContentClick += furnitureGridView_CellContentClick;
            // 
            // furnitureidDataGridViewTextBoxColumn
            // 
            furnitureidDataGridViewTextBoxColumn.DataPropertyName = "Furniture_id";
            furnitureidDataGridViewTextBoxColumn.HeaderText = "Furniture_id";
            furnitureidDataGridViewTextBoxColumn.Name = "furnitureidDataGridViewTextBoxColumn";
            furnitureidDataGridViewTextBoxColumn.ReadOnly = true;
            furnitureidDataGridViewTextBoxColumn.Visible = false;
            furnitureidDataGridViewTextBoxColumn.Width = 76;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 64;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            categorynameDataGridViewTextBoxColumn.DataPropertyName = "Category_name";
            categorynameDataGridViewTextBoxColumn.HeaderText = "Category";
            categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            categorynameDataGridViewTextBoxColumn.Width = 80;
            // 
            // stylenameDataGridViewTextBoxColumn
            // 
            stylenameDataGridViewTextBoxColumn.DataPropertyName = "Style_name";
            stylenameDataGridViewTextBoxColumn.HeaderText = "Style";
            stylenameDataGridViewTextBoxColumn.Name = "stylenameDataGridViewTextBoxColumn";
            stylenameDataGridViewTextBoxColumn.ReadOnly = true;
            stylenameDataGridViewTextBoxColumn.Width = 57;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Visible = false;
            descriptionDataGridViewTextBoxColumn.Width = 92;
            // 
            // rentalrateDataGridViewTextBoxColumn
            // 
            rentalrateDataGridViewTextBoxColumn.DataPropertyName = "Rental_rate";
            rentalrateDataGridViewTextBoxColumn.HeaderText = "Rate";
            rentalrateDataGridViewTextBoxColumn.Name = "rentalrateDataGridViewTextBoxColumn";
            rentalrateDataGridViewTextBoxColumn.ReadOnly = true;
            rentalrateDataGridViewTextBoxColumn.Width = 55;
            // 
            // finerateDataGridViewTextBoxColumn
            // 
            finerateDataGridViewTextBoxColumn.DataPropertyName = "Fine_rate";
            finerateDataGridViewTextBoxColumn.HeaderText = "Fine Rate";
            finerateDataGridViewTextBoxColumn.Name = "finerateDataGridViewTextBoxColumn";
            finerateDataGridViewTextBoxColumn.ReadOnly = true;
            finerateDataGridViewTextBoxColumn.Visible = false;
            finerateDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // furnitureBindingSource
            // 
            furnitureBindingSource.DataSource = typeof(model.Furniture);
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(70, 83);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(188, 16);
            textBox1.TabIndex = 29;
            textBox1.Text = "Please Select a Member to Rent to";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(382, 83);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(217, 16);
            textBox2.TabIndex = 30;
            textBox2.Text = "Please Select Furniture and Qty to Rent";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // RentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 364);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(furnitureGridView);
            Controls.Add(userDataGridView);
            Controls.Add(submitButton);
            Controls.Add(cancelButton);
            Controls.Add(addDialogHeading);
            Name = "RentalForm";
            Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label addDialogHeading;
        private Button cancelButton;
        private Button submitButton;
        private DataGridView userDataGridView;
        private DataGridView furnitureGridView;
        private TextBox textBox2;
        private TextBox textBox1;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registerdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
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