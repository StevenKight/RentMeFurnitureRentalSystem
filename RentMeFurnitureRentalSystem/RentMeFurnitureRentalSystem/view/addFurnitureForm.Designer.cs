namespace RentMeFurnitureRentalSystem.View
{
    partial class AddFurnitureForm
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
            this.nameTextBox = new TextBox();
            this.fineRateTextBox = new TextBox();
            this.rentalRateTextBox = new TextBox();
            this.descriptionTextArea = new TextBox();
            this.styleComboBox = new ComboBox();
            this.categoryComboBox = new ComboBox();
            this.name = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.cancelButton = new Button();
            this.addButton = new Button();
            this.addFurnitureError = new ErrorProvider(this.components);
            this.quantiyNumber = new NumericUpDown();
            this.label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)this.addFurnitureError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.quantiyNumber).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new Point(84, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new Size(310, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // fineRateTextBox
            // 
            this.fineRateTextBox.Location = new Point(278, 135);
            this.fineRateTextBox.Name = "fineRateTextBox";
            this.fineRateTextBox.Size = new Size(121, 23);
            this.fineRateTextBox.TabIndex = 4;
            // 
            // rentalRateTextBox
            // 
            this.rentalRateTextBox.Location = new Point(89, 135);
            this.rentalRateTextBox.Name = "rentalRateTextBox";
            this.rentalRateTextBox.Size = new Size(100, 23);
            this.rentalRateTextBox.TabIndex = 3;
            // 
            // descriptionTextArea
            // 
            this.descriptionTextArea.Location = new Point(62, 239);
            this.descriptionTextArea.Multiline = true;
            this.descriptionTextArea.Name = "descriptionTextArea";
            this.descriptionTextArea.Size = new Size(326, 95);
            this.descriptionTextArea.TabIndex = 6;
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new Point(89, 81);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new Size(100, 23);
            this.styleComboBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new Point(278, 81);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new Size(121, 23);
            this.categoryComboBox.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new Point(36, 30);
            this.name.Name = "name";
            this.name.Size = new Size(42, 15);
            this.name.TabIndex = 6;
            this.name.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(48, 84);
            this.label1.Name = "label1";
            this.label1.Size = new Size(35, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Style:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(214, 84);
            this.label2.Name = "label2";
            this.label2.Size = new Size(58, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new Size(69, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rental Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(214, 138);
            this.label4.Name = "label4";
            this.label4.Size = new Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fine Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(62, 221);
            this.label5.Name = "label5";
            this.label5.Size = new Size(70, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new Point(78, 351);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += this.cancelButton_Click;
            // 
            // addButton
            // 
            this.addButton.Location = new Point(272, 351);
            this.addButton.Name = "addButton";
            this.addButton.Size = new Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += this.addButton_Click;
            // 
            // addFurnitureError
            // 
            this.addFurnitureError.ContainerControl = this;
            // 
            // quantiyNumber
            // 
            this.quantiyNumber.Location = new Point(182, 182);
            this.quantiyNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.quantiyNumber.Name = "quantiyNumber";
            this.quantiyNumber.Size = new Size(120, 23);
            this.quantiyNumber.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(120, 184);
            this.label6.Name = "label6";
            this.label6.Size = new Size(56, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantity:";
            // 
            // addFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 390);
            Controls.Add(this.label6);
            Controls.Add(this.quantiyNumber);
            Controls.Add(this.addButton);
            Controls.Add(this.cancelButton);
            Controls.Add(this.label5);
            Controls.Add(this.label4);
            Controls.Add(this.label3);
            Controls.Add(this.label2);
            Controls.Add(this.label1);
            Controls.Add(this.name);
            Controls.Add(this.categoryComboBox);
            Controls.Add(this.styleComboBox);
            Controls.Add(this.descriptionTextArea);
            Controls.Add(this.rentalRateTextBox);
            Controls.Add(this.fineRateTextBox);
            Controls.Add(this.nameTextBox);
            Name = "AddFurnitureForm";
            Text = "addFurnitureForm";
            ((System.ComponentModel.ISupportInitialize)this.addFurnitureError).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.quantiyNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
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