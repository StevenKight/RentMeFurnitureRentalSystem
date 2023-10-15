namespace RentMeFurnitureRentalSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginButton = new Button();
            loginErrorProvider = new ErrorProvider(components);
            errorTextBox = new TextBox();
            showPasswordCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)loginErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(94, 95);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(148, 23);
            usernameInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(94, 149);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(148, 23);
            passwordInput.TabIndex = 1;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 98);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 152);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 49);
            label3.Name = "label3";
            label3.Size = new Size(162, 19);
            label3.TabIndex = 4;
            label3.Text = "Rent Me Employee Login";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(72, 217);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(132, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginErrorProvider
            // 
            loginErrorProvider.ContainerControl = this;
            // 
            // errorTextBox
            // 
            errorTextBox.BackColor = SystemColors.Control;
            errorTextBox.BorderStyle = BorderStyle.None;
            errorTextBox.ForeColor = Color.Red;
            errorTextBox.Location = new Point(29, 69);
            errorTextBox.Name = "errorTextBox";
            errorTextBox.ReadOnly = true;
            errorTextBox.Size = new Size(213, 16);
            errorTextBox.TabIndex = 6;
            errorTextBox.Text = "Username or password invalid";
            errorTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(94, 178);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(108, 19);
            showPasswordCheckBox.TabIndex = 7;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 272);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(errorTextBox);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)loginErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button loginButton;
        private ErrorProvider loginErrorProvider;
        private TextBox errorTextBox;
        private CheckBox showPasswordCheckBox;
    }
}