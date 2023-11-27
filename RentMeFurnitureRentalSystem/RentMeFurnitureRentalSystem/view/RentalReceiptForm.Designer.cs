namespace RentMeFurnitureRentalSystem.view
{
    partial class RentalReceiptForm
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
            dueDateTextBox = new TextBox();
            errorProvider = new ErrorProvider(components);
            titleTextBox = new TextBox();
            totalTextBox = new TextBox();
            itemCountTextBox = new TextBox();
            furnitureBindingSource = new BindingSource(components);
            furnitureGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            submitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureGridView).BeginInit();
            SuspendLayout();
            // 
            // dueDateTextBox
            // 
            dueDateTextBox.BackColor = SystemColors.Control;
            dueDateTextBox.BorderStyle = BorderStyle.None;
            dueDateTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dueDateTextBox.Location = new Point(12, 106);
            dueDateTextBox.Name = "dueDateTextBox";
            dueDateTextBox.ReadOnly = true;
            dueDateTextBox.Size = new Size(430, 22);
            dueDateTextBox.TabIndex = 30;
            dueDateTextBox.Text = "All items due by <DUE_DATE>";
            dueDateTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = SystemColors.Control;
            titleTextBox.BorderStyle = BorderStyle.None;
            titleTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            titleTextBox.Location = new Point(12, 12);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.ReadOnly = true;
            titleTextBox.Size = new Size(430, 43);
            titleTextBox.TabIndex = 31;
            titleTextBox.Text = "Rental <ID> for <USER>";
            titleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // totalTextBox
            // 
            totalTextBox.BackColor = SystemColors.Control;
            totalTextBox.BorderStyle = BorderStyle.None;
            totalTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            totalTextBox.Location = new Point(12, 61);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(430, 36);
            totalTextBox.TabIndex = 32;
            totalTextBox.Text = "Total: $<TOTAL>";
            totalTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // itemCountTextBox
            // 
            itemCountTextBox.BackColor = SystemColors.Control;
            itemCountTextBox.BorderStyle = BorderStyle.None;
            itemCountTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemCountTextBox.Location = new Point(12, 134);
            itemCountTextBox.Name = "itemCountTextBox";
            itemCountTextBox.ReadOnly = true;
            itemCountTextBox.Size = new Size(430, 22);
            itemCountTextBox.TabIndex = 33;
            itemCountTextBox.Text = "<ITEM_COUNT> item(s):";
            itemCountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // furnitureBindingSource
            // 
            furnitureBindingSource.DataSource = typeof(model.Furniture);
            // 
            // furnitureGridView
            // 
            furnitureGridView.AllowUserToAddRows = false;
            furnitureGridView.AllowUserToDeleteRows = false;
            furnitureGridView.AutoGenerateColumns = false;
            furnitureGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            furnitureGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            furnitureGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            furnitureGridView.DataSource = furnitureBindingSource;
            furnitureGridView.Location = new Point(12, 162);
            furnitureGridView.MultiSelect = false;
            furnitureGridView.Name = "furnitureGridView";
            furnitureGridView.RowHeadersVisible = false;
            furnitureGridView.RowHeadersWidth = 51;
            furnitureGridView.RowTemplate.Height = 25;
            furnitureGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            furnitureGridView.Size = new Size(430, 206);
            furnitureGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Furniture_id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 42;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 64;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.DataPropertyName = "Category_name";
            dataGridViewTextBoxColumn3.HeaderText = "Category";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.DataPropertyName = "Style_name";
            dataGridViewTextBoxColumn4.HeaderText = "Style";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 57;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            dataGridViewTextBoxColumn5.HeaderText = "Description";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 92;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.DataPropertyName = "Rental_rate";
            dataGridViewTextBoxColumn6.HeaderText = "Rate";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 55;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Fine_rate";
            dataGridViewTextBoxColumn7.HeaderText = "Fine_rate";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Visible = false;
            dataGridViewTextBoxColumn7.Width = 79;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn8.HeaderText = "Quantity";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(165, 377);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(127, 23);
            submitButton.TabIndex = 35;
            submitButton.Text = "Close";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += closeButton_Click;
            // 
            // RentalReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 411);
            Controls.Add(submitButton);
            Controls.Add(furnitureGridView);
            Controls.Add(itemCountTextBox);
            Controls.Add(totalTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(dueDateTextBox);
            Name = "RentalReceiptForm";
            Text = "Rental Receipt";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelButton;
        private TextBox dueDateTextBox;
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
        private TextBox textBox3;
        private TextBox titleTextBox;
        private TextBox totalTextBox;
        private DateTimePicker dueDateDateTimePicker;
        private TextBox itemCountTextBox;
        private DataGridView furnitureGridView;
        private Button submitButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}