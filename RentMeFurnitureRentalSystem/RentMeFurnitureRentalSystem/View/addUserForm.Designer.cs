namespace RentMeFurnitureRentalSystem.view
{
    partial class addUserForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addDialogHeading = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstnameInput = new System.Windows.Forms.TextBox();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.dobTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.streetAdressInput = new System.Windows.Forms.TextBox();
            this.zipcodeInput = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addUserError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addUserError)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(15, 83);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // addDialogHeading
            // 
            this.addDialogHeading.AutoSize = true;
            this.addDialogHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDialogHeading.Location = new System.Drawing.Point(146, 12);
            this.addDialogHeading.Name = "addDialogHeading";
            this.addDialogHeading.Size = new System.Drawing.Size(167, 41);
            this.addDialogHeading.TabIndex = 1;
            this.addDialogHeading.Text = "Add Dialog";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(96, 79);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(145, 27);
            this.usernameInput.TabIndex = 2;
            this.usernameInput.Validating += new System.ComponentModel.CancelEventHandler(this.textInput_Validating);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(260, 83);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(336, 79);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(145, 27);
            this.passwordInput.TabIndex = 4;
            this.passwordInput.Validating += new System.ComponentModel.CancelEventHandler(this.textInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lastname";
            // 
            // firstnameInput
            // 
            this.firstnameInput.Location = new System.Drawing.Point(96, 132);
            this.firstnameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstnameInput.Name = "firstnameInput";
            this.firstnameInput.Size = new System.Drawing.Size(145, 27);
            this.firstnameInput.TabIndex = 7;
            this.firstnameInput.Validating += new System.ComponentModel.CancelEventHandler(this.textInput_Validating);
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(336, 132);
            this.lastnameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(145, 27);
            this.lastnameInput.TabIndex = 8;
            this.lastnameInput.Validating += new System.ComponentModel.CancelEventHandler(this.textInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(96, 251);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(64, 28);
            this.genderComboBox.TabIndex = 11;
            this.genderComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.genderComboBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone";
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(336, 193);
            this.phoneInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(145, 27);
            this.phoneInput.TabIndex = 10;
            this.phoneInput.Validating += new System.ComponentModel.CancelEventHandler(this.phoneInput_Validating);
            // 
            // dobTimePicker
            // 
            this.dobTimePicker.Location = new System.Drawing.Point(236, 249);
            this.dobTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dobTimePicker.Name = "dobTimePicker";
            this.dobTimePicker.Size = new System.Drawing.Size(245, 27);
            this.dobTimePicker.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Birthday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Street";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Zipcode";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(336, 307);
            this.cityInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(145, 27);
            this.cityInput.TabIndex = 20;
            this.cityInput.Validating += new System.ComponentModel.CancelEventHandler(this.textInput_Validating);
            // 
            // streetAdressInput
            // 
            this.streetAdressInput.Location = new System.Drawing.Point(96, 307);
            this.streetAdressInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.streetAdressInput.Name = "streetAdressInput";
            this.streetAdressInput.Size = new System.Drawing.Size(145, 27);
            this.streetAdressInput.TabIndex = 19;
            this.streetAdressInput.Validating += new System.ComponentModel.CancelEventHandler(this.textInput_Validating);
            // 
            // zipcodeInput
            // 
            this.zipcodeInput.Location = new System.Drawing.Point(96, 369);
            this.zipcodeInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zipcodeInput.Name = "zipcodeInput";
            this.zipcodeInput.Size = new System.Drawing.Size(145, 27);
            this.zipcodeInput.TabIndex = 21;
            this.zipcodeInput.Validating += new System.ComponentModel.CancelEventHandler(this.textInput_Validating);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(336, 369);
            this.stateComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(145, 28);
            this.stateComboBox.TabIndex = 22;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateComboBox_Validating);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(178, 427);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(39, 20);
            this.roleLabel.TabIndex = 23;
            this.roleLabel.Text = "Role";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(223, 424);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(110, 28);
            this.roleComboBox.TabIndex = 24;
            this.roleComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.roleComboBox_Validating);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(43, 472);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 31);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(336, 472);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(145, 31);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add Employee";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Firstname";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(96, 196);
            this.emailInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(145, 27);
            this.emailInput.TabIndex = 9;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(40, 199);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 20);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email";
            // 
            // addUserError
            // 
            this.addUserError.ContainerControl = this;
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 525);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipcodeInput);
            this.Controls.Add(this.streetAdressInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dobTimePicker);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastnameInput);
            this.Controls.Add(this.firstnameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.addDialogHeading);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addUserForm";
            this.Text = "Add User";
            ((System.ComponentModel.ISupportInitialize)(this.addUserError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label usernameLabel;
        private Label addDialogHeading;
        private TextBox usernameInput;
        private Label passwordLabel;
        private TextBox passwordInput;
        private Label label5;
        private TextBox firstnameInput;
        private TextBox lastnameInput;
        private Label label6;
        private ComboBox genderComboBox;
        private Label label7;
        private TextBox phoneInput;
        private DateTimePicker dobTimePicker;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox cityInput;
        private TextBox streetAdressInput;
        private TextBox zipcodeInput;
        private ComboBox stateComboBox;
        private Label roleLabel;
        private ComboBox roleComboBox;
        private Button cancelButton;
        private Button addButton;
        private Label label4;
        private TextBox emailInput;
        private Label emailLabel;
        private ErrorProvider addUserError;
    }
}