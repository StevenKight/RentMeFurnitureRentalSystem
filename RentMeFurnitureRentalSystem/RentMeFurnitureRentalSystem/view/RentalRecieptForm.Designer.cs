namespace RentMeFurnitureRentalSystem.view
{
    partial class RentalRecieptForm
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
            submitButton = new Button();
            dueDateTextBox = new TextBox();
            errorProvider = new ErrorProvider(components);
            titleTextBox = new TextBox();
            totalTextBox = new TextBox();
            itemCountTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(171, 376);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(127, 23);
            submitButton.TabIndex = 25;
            submitButton.Text = "Submit Rental";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // dueDateTextBox
            // 
            dueDateTextBox.BackColor = SystemColors.Control;
            dueDateTextBox.BorderStyle = BorderStyle.None;
            dueDateTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dueDateTextBox.Location = new Point(12, 103);
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
            totalTextBox.Text = "Total: <TOTAL>";
            totalTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // itemCountTextBox
            // 
            itemCountTextBox.BackColor = SystemColors.Control;
            itemCountTextBox.BorderStyle = BorderStyle.None;
            itemCountTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemCountTextBox.Location = new Point(12, 131);
            itemCountTextBox.Name = "itemCountTextBox";
            itemCountTextBox.ReadOnly = true;
            itemCountTextBox.Size = new Size(430, 22);
            itemCountTextBox.TabIndex = 33;
            itemCountTextBox.Text = "<ITEM_COUNT> item(s):";
            itemCountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // RentalRecieptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 411);
            Controls.Add(itemCountTextBox);
            Controls.Add(totalTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(dueDateTextBox);
            Controls.Add(submitButton);
            Name = "RentalRecieptForm";
            Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelButton;
        private Button submitButton;
        private DataGridView furnitureGridView;
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
    }
}