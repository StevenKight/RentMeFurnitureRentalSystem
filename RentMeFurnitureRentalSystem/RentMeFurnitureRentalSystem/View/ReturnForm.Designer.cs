using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.View
{
    partial class ReturnForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cancelButton = new Button();
            submitButton = new Button();
            furnitureDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DisplayQuantity = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            furnitureBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            errorProvider = new ErrorProvider(components);
            titleTextBox = new TextBox();
            rentalsDataGridView = new DataGridView();
            rentalidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeenumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duedateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            furnitureidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentalItemBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)furnitureDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentalsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentalItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(130, 467);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 23);
            cancelButton.TabIndex = 26;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(328, 467);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(127, 23);
            submitButton.TabIndex = 25;
            submitButton.Text = "Submit Return";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // furnitureDataGridView
            // 
            furnitureDataGridView.AllowUserToAddRows = false;
            furnitureDataGridView.AllowUserToDeleteRows = false;
            furnitureDataGridView.AutoGenerateColumns = false;
            furnitureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            furnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            furnitureDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, DisplayQuantity, dataGridViewTextBoxColumn8 });
            furnitureDataGridView.DataSource = furnitureBindingSource;
            furnitureDataGridView.Location = new Point(12, 261);
            furnitureDataGridView.MultiSelect = false;
            furnitureDataGridView.Name = "furnitureDataGridView";
            furnitureDataGridView.RowHeadersVisible = false;
            furnitureDataGridView.RowHeadersWidth = 51;
            furnitureDataGridView.RowTemplate.Height = 25;
            furnitureDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            furnitureDataGridView.Size = new Size(535, 192);
            furnitureDataGridView.TabIndex = 28;
            furnitureDataGridView.CellEndEdit += furnitureDataGridView_CellEndEdit;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Furniture_id";
            dataGridViewTextBoxColumn1.HeaderText = "Furniture Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 93;
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
            // DisplayQuantity
            // 
            DisplayQuantity.DataPropertyName = "DisplayQuantity";
            DisplayQuantity.HeaderText = "Rented";
            DisplayQuantity.MinimumWidth = 6;
            DisplayQuantity.Name = "DisplayQuantity";
            DisplayQuantity.ReadOnly = true;
            DisplayQuantity.Width = 69;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn8.HeaderText = "Quantity";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(Furniture);
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 232);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(535, 22);
            textBox2.TabIndex = 30;
            textBox2.Text = "Please Enter a Quantity of Each Furniture to be Returned";
            textBox2.TextAlign = HorizontalAlignment.Center;
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
            titleTextBox.Location = new Point(12, 10);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.ReadOnly = true;
            titleTextBox.Size = new Size(535, 43);
            titleTextBox.TabIndex = 31;
            titleTextBox.Text = "Return to <USER>";
            titleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // rentalsDataGridView
            // 
            rentalsDataGridView.AllowUserToAddRows = false;
            rentalsDataGridView.AllowUserToDeleteRows = false;
            rentalsDataGridView.AutoGenerateColumns = false;
            rentalsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            rentalsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentalsDataGridView.Columns.AddRange(new DataGridViewColumn[] { rentalidDataGridViewTextBoxColumn, memberidDataGridViewTextBoxColumn, employeenumDataGridViewTextBoxColumn, startdateDataGridViewTextBoxColumn, duedateDataGridViewTextBoxColumn, furnitureidDataGridViewTextBoxColumn });
            rentalsDataGridView.DataSource = rentalItemBindingSource;
            rentalsDataGridView.Location = new Point(12, 91);
            rentalsDataGridView.MultiSelect = false;
            rentalsDataGridView.Name = "rentalsDataGridView";
            rentalsDataGridView.RowHeadersVisible = false;
            rentalsDataGridView.RowHeadersWidth = 51;
            rentalsDataGridView.RowTemplate.Height = 25;
            rentalsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rentalsDataGridView.Size = new Size(535, 134);
            rentalsDataGridView.TabIndex = 32;
            rentalsDataGridView.RowStateChanged += rentalsDataGridView_RowStateChanged;
            // 
            // rentalidDataGridViewTextBoxColumn
            // 
            rentalidDataGridViewTextBoxColumn.DataPropertyName = "Rental_id";
            rentalidDataGridViewTextBoxColumn.HeaderText = "Rental_id";
            rentalidDataGridViewTextBoxColumn.MinimumWidth = 6;
            rentalidDataGridViewTextBoxColumn.Name = "rentalidDataGridViewTextBoxColumn";
            rentalidDataGridViewTextBoxColumn.Visible = false;
            rentalidDataGridViewTextBoxColumn.Width = 61;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            memberidDataGridViewTextBoxColumn.DataPropertyName = "Member_id";
            memberidDataGridViewTextBoxColumn.HeaderText = "Member_id";
            memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            memberidDataGridViewTextBoxColumn.Visible = false;
            memberidDataGridViewTextBoxColumn.Width = 73;
            // 
            // employeenumDataGridViewTextBoxColumn
            // 
            employeenumDataGridViewTextBoxColumn.DataPropertyName = "Employee_num";
            employeenumDataGridViewTextBoxColumn.HeaderText = "Employee_num";
            employeenumDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeenumDataGridViewTextBoxColumn.Name = "employeenumDataGridViewTextBoxColumn";
            employeenumDataGridViewTextBoxColumn.Visible = false;
            employeenumDataGridViewTextBoxColumn.Width = 95;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            startdateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            startdateDataGridViewTextBoxColumn.DataPropertyName = "Start_date";
            startdateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            startdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            startdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            duedateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            duedateDataGridViewTextBoxColumn.DataPropertyName = "Due_date";
            duedateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            duedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // furnitureidDataGridViewTextBoxColumn
            // 
            furnitureidDataGridViewTextBoxColumn.DataPropertyName = "Furniture_id";
            furnitureidDataGridViewTextBoxColumn.HeaderText = "Furniture_id";
            furnitureidDataGridViewTextBoxColumn.MinimumWidth = 6;
            furnitureidDataGridViewTextBoxColumn.Name = "furnitureidDataGridViewTextBoxColumn";
            furnitureidDataGridViewTextBoxColumn.Visible = false;
            furnitureidDataGridViewTextBoxColumn.Width = 95;
            // 
            // rentalItemBindingSource
            // 
            this.rentalItemBindingSource.DataSource = typeof(RentalItem);
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 63);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(535, 22);
            textBox1.TabIndex = 33;
            textBox1.Text = "Please Select a Rental to See Items For";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 500);
            Controls.Add(textBox1);
            Controls.Add(rentalsDataGridView);
            Controls.Add(titleTextBox);
            Controls.Add(textBox2);
            Controls.Add(furnitureDataGridView);
            Controls.Add(submitButton);
            Controls.Add(cancelButton);
            Name = "ReturnForm";
            Text = "Return";
            Shown += ReturnForm_Shown;
            ((System.ComponentModel.ISupportInitialize)furnitureDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)furnitureBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentalsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentalItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelButton;
        private Button submitButton;
        private DataGridView furnitureDataGridView;
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
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stylenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentalrateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finerateDataGridViewTextBoxColumn;
        private TextBox titleTextBox;
        private BindingSource furnitureBindingSource;
        private TextBox textBox1;
        private DataGridView rentalsDataGridView;
        private BindingSource rentalItemBindingSource;
        private DataGridViewTextBoxColumn rentalidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeenumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn furnitureidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn DisplayQuantity;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}