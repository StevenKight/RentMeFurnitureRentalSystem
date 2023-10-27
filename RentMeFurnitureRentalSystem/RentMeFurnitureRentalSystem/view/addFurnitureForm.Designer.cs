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
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(73, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(310, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // fineRateTextBox
            // 
            this.fineRateTextBox.Location = new System.Drawing.Point(283, 222);
            this.fineRateTextBox.Name = "fineRateTextBox";
            this.fineRateTextBox.Size = new System.Drawing.Size(121, 23);
            this.fineRateTextBox.TabIndex = 1;
            // 
            // rentalRateTextBox
            // 
            this.rentalRateTextBox.Location = new System.Drawing.Point(84, 222);
            this.rentalRateTextBox.Name = "rentalRateTextBox";
            this.rentalRateTextBox.Size = new System.Drawing.Size(100, 23);
            this.rentalRateTextBox.TabIndex = 2;
            // 
            // descriptionTextArea
            // 
            this.descriptionTextArea.Location = new System.Drawing.Point(55, 323);
            this.descriptionTextArea.Multiline = true;
            this.descriptionTextArea.Name = "descriptionTextArea";
            this.descriptionTextArea.Size = new System.Drawing.Size(326, 95);
            this.descriptionTextArea.TabIndex = 3;
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(55, 151);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(121, 23);
            this.styleComboBox.TabIndex = 4;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(283, 151);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 23);
            this.categoryComboBox.TabIndex = 5;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(21, 48);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 15);
            this.name.TabIndex = 6;
            this.name.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Style:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rental Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fine Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description:";
            // 
            // addFurnitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
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
    }
}