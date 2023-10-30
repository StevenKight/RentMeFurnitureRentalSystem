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
            components = new System.ComponentModel.Container();
            nameTextBox = new TextBox();
            fineRateTextBox = new TextBox();
            rentalRateTextBox = new TextBox();
            descriptionTextArea = new TextBox();
            styleComboBox = new ComboBox();
            categoryComboBox = new ComboBox();
            name = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cancelButton = new Button();
            addButton = new Button();
            addFurnitureError = new ErrorProvider(components);
            quantiyNumber = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)addFurnitureError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantiyNumber).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(84, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(310, 23);
            nameTextBox.TabIndex = 0;
            // 
            // fineRateTextBox
            // 
            fineRateTextBox.Location = new Point(278, 135);
            fineRateTextBox.Name = "fineRateTextBox";
            fineRateTextBox.Size = new Size(121, 23);
            fineRateTextBox.TabIndex = 4;
            // 
            // rentalRateTextBox
            // 
            rentalRateTextBox.Location = new Point(89, 135);
            rentalRateTextBox.Name = "rentalRateTextBox";
            rentalRateTextBox.Size = new Size(100, 23);
            rentalRateTextBox.TabIndex = 3;
            // 
            // descriptionTextArea
            // 
            descriptionTextArea.Location = new Point(62, 239);
            descriptionTextArea.Multiline = true;
            descriptionTextArea.Name = "descriptionTextArea";
            descriptionTextArea.Size = new Size(326, 95);
            descriptionTextArea.TabIndex = 6;
            // 
            // styleComboBox
            // 
            styleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            styleComboBox.FormattingEnabled = true;
            styleComboBox.Location = new Point(89, 81);
            styleComboBox.Name = "styleComboBox";
            styleComboBox.Size = new Size(100, 23);
            styleComboBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(278, 81);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(121, 23);
            categoryComboBox.TabIndex = 2;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(36, 30);
            name.Name = "name";
            name.Size = new Size(42, 15);
            name.TabIndex = 6;
            name.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 84);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 7;
            label1.Text = "Style:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 84);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 138);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 9;
            label3.Text = "Rental Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 138);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Fine Rate:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 221);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 11;
            label5.Text = "Description:";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(78, 351);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(272, 351);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // addFurnitureError
            // 
            addFurnitureError.ContainerControl = this;
            // 
            // quantiyNumber
            // 
            quantiyNumber.Location = new Point(182, 182);
            quantiyNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantiyNumber.Name = "quantiyNumber";
            quantiyNumber.Size = new Size(120, 23);
            quantiyNumber.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 184);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 15;
            label6.Text = "Quantity:";
            // 
            // addFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 390);
            Controls.Add(label6);
            Controls.Add(quantiyNumber);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(categoryComboBox);
            Controls.Add(styleComboBox);
            Controls.Add(descriptionTextArea);
            Controls.Add(rentalRateTextBox);
            Controls.Add(fineRateTextBox);
            Controls.Add(nameTextBox);
            Name = "addFurnitureForm";
            Text = "addFurnitureForm";
            ((System.ComponentModel.ISupportInitialize)addFurnitureError).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantiyNumber).EndInit();
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