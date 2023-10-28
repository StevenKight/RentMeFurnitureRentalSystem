namespace RentMeFurnitureRentalSystem.view
{
    partial class addFurnitureForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.fineRateTextBox = new System.Windows.Forms.TextBox();
            this.rentalRateTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextArea = new System.Windows.Forms.TextBox();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addFurnitureError = new System.Windows.Forms.ErrorProvider(this.components);
            this.quantiyNumber = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addFurnitureError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiyNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(60, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(310, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // fineRateTextBox
            // 
            this.fineRateTextBox.Location = new System.Drawing.Point(283, 152);
            this.fineRateTextBox.Name = "fineRateTextBox";
            this.fineRateTextBox.Size = new System.Drawing.Size(121, 23);
            this.fineRateTextBox.TabIndex = 1;
            // 
            // rentalRateTextBox
            // 
            this.rentalRateTextBox.Location = new System.Drawing.Point(84, 152);
            this.rentalRateTextBox.Name = "rentalRateTextBox";
            this.rentalRateTextBox.Size = new System.Drawing.Size(100, 23);
            this.rentalRateTextBox.TabIndex = 2;
            // 
            // descriptionTextArea
            // 
            this.descriptionTextArea.Location = new System.Drawing.Point(55, 303);
            this.descriptionTextArea.Multiline = true;
            this.descriptionTextArea.Name = "descriptionTextArea";
            this.descriptionTextArea.Size = new System.Drawing.Size(326, 95);
            this.descriptionTextArea.TabIndex = 3;
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(55, 81);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(121, 23);
            this.styleComboBox.TabIndex = 4;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(283, 81);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 23);
            this.categoryComboBox.TabIndex = 5;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 15);
            this.name.TabIndex = 6;
            this.name.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Style:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rental Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fine Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(55, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(283, 415);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addFurnitureError
            // 
            this.addFurnitureError.ContainerControl = this;
            // 
            // quantiyNumber
            // 
            this.quantiyNumber.Location = new System.Drawing.Point(157, 223);
            this.quantiyNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantiyNumber.Name = "quantiyNumber";
            this.quantiyNumber.Size = new System.Drawing.Size(120, 23);
            this.quantiyNumber.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantity:";
            // 
            // addFurnitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantiyNumber);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.descriptionTextArea);
            this.Controls.Add(this.rentalRateTextBox);
            this.Controls.Add(this.fineRateTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "addFurnitureForm";
            this.Text = "addFurnitureForm";
            ((System.ComponentModel.ISupportInitialize)(this.addFurnitureError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiyNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private TextBox fineRateTextBox;
        private TextBox rentalRateTextBox;
        private TextBox descriptionTextArea;
        private ComboBox styleComboBox;
        private ComboBox categoryComboBox;
        private Label name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button cancelButton;
        private Button addButton;
        private ErrorProvider addFurnitureError;
        private Label label6;
        private NumericUpDown quantiyNumber;
    }
}