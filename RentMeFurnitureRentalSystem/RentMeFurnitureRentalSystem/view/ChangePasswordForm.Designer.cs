namespace RentMeFurnitureRentalSystem.View
{
    partial class ChangePasswordForm
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
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(140, 137);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(164, 23);
            this.EmployeeIdTextBox.TabIndex = 2;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(140, 195);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(164, 23);
            this.NewPasswordTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(140, 84);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(164, 23);
            this.usernameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Change Password";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(218, 260);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(86, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 310);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox EmployeeIdTextBox;
        private TextBox NewPasswordTextBox;
        private TextBox usernameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button submitButton;
    }
}