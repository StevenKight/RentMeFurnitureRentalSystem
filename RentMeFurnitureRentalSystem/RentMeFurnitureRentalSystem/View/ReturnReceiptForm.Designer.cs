using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.View
{
    partial class ReturnReceiptForm
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.itemCountTextBox = new System.Windows.Forms.TextBox();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureGridView = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rental_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureGridView)).BeginInit();
            this.SuspendLayout();
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
            this.titleTextBox.Location = new System.Drawing.Point(12, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(430, 43);
            this.titleTextBox.TabIndex = 31;
            this.titleTextBox.Text = "Return <ID> for <USER>";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalTextBox.Location = new System.Drawing.Point(12, 80);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(430, 36);
            this.totalTextBox.TabIndex = 32;
            this.totalTextBox.Text = "Fine: $<TOTAL>";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemCountTextBox
            // 
            this.itemCountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.itemCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemCountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemCountTextBox.Location = new System.Drawing.Point(12, 134);
            this.itemCountTextBox.Name = "itemCountTextBox";
            this.itemCountTextBox.ReadOnly = true;
            this.itemCountTextBox.Size = new System.Drawing.Size(430, 22);
            this.itemCountTextBox.TabIndex = 33;
            this.itemCountTextBox.Text = "<ITEM_COUNT> item(s):";
            this.itemCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(Furniture);
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
            this.Rental_id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.furnitureGridView.DataSource = this.furnitureBindingSource;
            this.furnitureGridView.Location = new System.Drawing.Point(12, 162);
            this.furnitureGridView.MultiSelect = false;
            this.furnitureGridView.Name = "furnitureGridView";
            this.furnitureGridView.RowHeadersVisible = false;
            this.furnitureGridView.RowHeadersWidth = 51;
            this.furnitureGridView.RowTemplate.Height = 25;
            this.furnitureGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.furnitureGridView.Size = new System.Drawing.Size(430, 206);
            this.furnitureGridView.TabIndex = 34;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(165, 377);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(127, 23);
            this.submitButton.TabIndex = 35;
            this.submitButton.Text = "Close";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Furniture_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 42;
            // 
            // Rental_id
            // 
            this.Rental_id.DataPropertyName = "Rental_id";
            this.Rental_id.HeaderText = "Rental Id";
            this.Rental_id.Name = "Rental_id";
            this.Rental_id.ReadOnly = true;
            this.Rental_id.Width = 78;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 64;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Category_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Style_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Style";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 57;
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
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 55;
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
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ReturnReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 411);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.furnitureGridView);
            this.Controls.Add(this.itemCountTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "ReturnReceiptForm";
            this.Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button cancelButton;
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
        private DataGridViewTextBoxColumn Rental_id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}