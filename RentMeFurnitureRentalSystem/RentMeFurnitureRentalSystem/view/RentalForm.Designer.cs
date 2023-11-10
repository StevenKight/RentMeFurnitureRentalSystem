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
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.furnitureGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StyleRadioButton = new System.Windows.Forms.RadioButton();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.IdRadioButton = new System.Windows.Forms.RadioButton();
            this.furnitureSearchTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.categoryRadioButton = new System.Windows.Forms.RadioButton();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.furnitureSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(71, 546);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 31);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(297, 546);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(145, 31);
            this.submitButton.TabIndex = 25;
            this.submitButton.Text = "Submit Rental";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // furnitureGridView
            // 
            this.furnitureGridView.AllowUserToAddRows = false;
            this.furnitureGridView.AllowUserToDeleteRows = false;
            this.furnitureGridView.AutoGenerateColumns = false;
            this.furnitureGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.furnitureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.furnitureGridView.DataSource = this.furnitureBindingSource;
            this.furnitureGridView.Location = new System.Drawing.Point(14, 207);
            this.furnitureGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.furnitureGridView.MultiSelect = false;
            this.furnitureGridView.Name = "furnitureGridView";
            this.furnitureGridView.RowHeadersVisible = false;
            this.furnitureGridView.RowHeadersWidth = 51;
            this.furnitureGridView.RowTemplate.Height = 25;
            this.furnitureGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.furnitureGridView.Size = new System.Drawing.Size(491, 256);
            this.furnitureGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Furniture_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Furniture_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 78;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Category_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 98;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Style_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Style";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 92;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rental_rate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 68;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fine_rate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fine_rate";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 79;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(RentMeFurnitureRentalSystem.model.Furniture);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(14, 79);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(491, 27);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Please Enter a Quantity of Each Furniture to be Rented";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTextBox.Location = new System.Drawing.Point(14, 13);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(491, 54);
            this.titleTextBox.TabIndex = 31;
            this.titleTextBox.Text = "Rent to <USER>";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(94, 492);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(167, 27);
            this.textBox3.TabIndex = 32;
            this.textBox3.Text = "Select a Due Date:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(267, 487);
            this.dueDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(146, 34);
            this.dueDateDateTimePicker.TabIndex = 33;
            // 
            // StyleRadioButton
            // 
            this.StyleRadioButton.AutoSize = true;
            this.StyleRadioButton.Location = new System.Drawing.Point(267, 121);
            this.StyleRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StyleRadioButton.Name = "StyleRadioButton";
            this.StyleRadioButton.Size = new System.Drawing.Size(62, 24);
            this.StyleRadioButton.TabIndex = 37;
            this.StyleRadioButton.Text = "Style";
            this.StyleRadioButton.UseVisualStyleBackColor = true;
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(335, 120);
            this.styleComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(108, 28);
            this.styleComboBox.TabIndex = 36;
            // 
            // IdRadioButton
            // 
            this.IdRadioButton.AutoSize = true;
            this.IdRadioButton.Checked = true;
            this.IdRadioButton.Location = new System.Drawing.Point(75, 121);
            this.IdRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdRadioButton.Name = "IdRadioButton";
            this.IdRadioButton.Size = new System.Drawing.Size(105, 24);
            this.IdRadioButton.TabIndex = 35;
            this.IdRadioButton.TabStop = true;
            this.IdRadioButton.Text = "Furniture Id";
            this.IdRadioButton.UseVisualStyleBackColor = true;
            // 
            // furnitureSearchTextBox
            // 
            this.furnitureSearchTextBox.Location = new System.Drawing.Point(186, 121);
            this.furnitureSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.furnitureSearchTextBox.Name = "furnitureSearchTextBox";
            this.furnitureSearchTextBox.Size = new System.Drawing.Size(75, 27);
            this.furnitureSearchTextBox.TabIndex = 34;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(387, 160);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(56, 31);
            this.resetButton.TabIndex = 41;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // categoryRadioButton
            // 
            this.categoryRadioButton.AutoSize = true;
            this.categoryRadioButton.Location = new System.Drawing.Point(75, 163);
            this.categoryRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryRadioButton.Name = "categoryRadioButton";
            this.categoryRadioButton.Size = new System.Drawing.Size(90, 24);
            this.categoryRadioButton.TabIndex = 40;
            this.categoryRadioButton.Text = "Category";
            this.categoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(171, 162);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 28);
            this.categoryComboBox.TabIndex = 39;
            // 
            // furnitureSearchButton
            // 
            this.furnitureSearchButton.Location = new System.Drawing.Point(311, 160);
            this.furnitureSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.furnitureSearchButton.Name = "furnitureSearchButton";
            this.furnitureSearchButton.Size = new System.Drawing.Size(65, 31);
            this.furnitureSearchButton.TabIndex = 38;
            this.furnitureSearchButton.Text = "Search";
            this.furnitureSearchButton.UseVisualStyleBackColor = true;
            this.furnitureSearchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 599);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.categoryRadioButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.furnitureSearchButton);
            this.Controls.Add(this.StyleRadioButton);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.IdRadioButton);
            this.Controls.Add(this.furnitureSearchTextBox);
            this.Controls.Add(this.dueDateDateTimePicker);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.furnitureGridView);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RentalForm";
            this.Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)(this.furnitureGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button cancelButton;
        private Button submitButton;
        private DataGridView furnitureGridView;
        private TextBox textBox2;
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
        private DataGridViewTextBoxColumn furnitureidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stylenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentalrateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finerateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private TextBox textBox3;
        private TextBox titleTextBox;
        private DateTimePicker dueDateDateTimePicker;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BindingSource furnitureBindingSource;
        private RadioButton StyleRadioButton;
        private ComboBox styleComboBox;
        private RadioButton IdRadioButton;
        private TextBox furnitureSearchTextBox;
        private Button resetButton;
        private RadioButton categoryRadioButton;
        private ComboBox categoryComboBox;
        private Button furnitureSearchButton;
    }
}