namespace RentMeFurnitureRentalSystem.View
{
    partial class AddUserForm
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
            this.usernameLabel = new Label();
            this.usernameInput = new TextBox();
            this.passwordLabel = new Label();
            this.passwordInput = new TextBox();
            this.label5 = new Label();
            this.firstnameInput = new TextBox();
            this.lastnameInput = new TextBox();
            this.label6 = new Label();
            this.genderComboBox = new ComboBox();
            this.label7 = new Label();
            this.phoneInput = new TextBox();
            this.dobTimePicker = new DateTimePicker();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.label11 = new Label();
            this.label12 = new Label();
            this.cityInput = new TextBox();
            this.streetAdressInput = new TextBox();
            this.zipcodeInput = new TextBox();
            this.stateComboBox = new ComboBox();
            this.roleLabel = new Label();
            this.roleComboBox = new ComboBox();
            this.cancelButton = new Button();
            this.addButton = new Button();
            this.label4 = new Label();
            this.emailInput = new TextBox();
            this.emailLabel = new Label();
            this.addUserError = new ErrorProvider(this.components);
            this.showPasswordCheckBox = new CheckBox();
            this.addDialogHeading = new TextBox();
            ((System.ComponentModel.ISupportInitialize)this.addUserError).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new Point(13, 62);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new Size(60, 15);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new Point(84, 59);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new Size(127, 23);
            this.usernameInput.TabIndex = 2;
            this.usernameInput.TextChanged += this.input_TextChanged;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new Point(228, 62);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new Size(57, 15);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new Point(294, 59);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new Size(127, 23);
            this.passwordInput.TabIndex = 4;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.TextChanged += this.input_TextChanged;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(226, 111);
            this.label5.Name = "label5";
            this.label5.Size = new Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lastname";
            // 
            // firstnameInput
            // 
            this.firstnameInput.Location = new Point(84, 109);
            this.firstnameInput.Name = "firstnameInput";
            this.firstnameInput.Size = new Size(127, 23);
            this.firstnameInput.TabIndex = 7;
            this.firstnameInput.TextChanged += this.input_TextChanged;
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new Point(294, 109);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new Size(127, 23);
            this.lastnameInput.TabIndex = 8;
            this.lastnameInput.TextChanged += this.input_TextChanged;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(29, 190);
            this.label6.Name = "label6";
            this.label6.Size = new Size(45, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new Point(84, 188);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new Size(127, 23);
            this.genderComboBox.TabIndex = 11;
            this.genderComboBox.TextChanged += this.input_TextChanged;
            this.genderComboBox.Validating += this.genderComboBox_Validating;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new Point(245, 147);
            this.label7.Name = "label7";
            this.label7.Size = new Size(41, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone";
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new Point(294, 145);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new Size(127, 23);
            this.phoneInput.TabIndex = 10;
            this.phoneInput.TextChanged += this.input_TextChanged;
            this.phoneInput.Validating += this.phoneInput_Validating;
            // 
            // dobTimePicker
            // 
            this.dobTimePicker.Format = DateTimePickerFormat.Short;
            this.dobTimePicker.Location = new Point(294, 187);
            this.dobTimePicker.Name = "dobTimePicker";
            this.dobTimePicker.Size = new Size(127, 23);
            this.dobTimePicker.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new Point(233, 190);
            this.label8.Name = "label8";
            this.label8.Size = new Size(51, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Birthday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new Point(37, 232);
            this.label9.Name = "label9";
            this.label9.Size = new Size(37, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Street";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new Point(251, 279);
            this.label10.Name = "label10";
            this.label10.Size = new Size(33, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new Point(49, 279);
            this.label11.Name = "label11";
            this.label11.Size = new Size(28, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new Point(233, 232);
            this.label12.Name = "label12";
            this.label12.Size = new Size(50, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Zipcode";
            // 
            // cityInput
            // 
            this.cityInput.Location = new Point(84, 277);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new Size(127, 23);
            this.cityInput.TabIndex = 20;
            this.cityInput.TextChanged += this.input_TextChanged;
            // 
            // streetAdressInput
            // 
            this.streetAdressInput.Location = new Point(84, 230);
            this.streetAdressInput.Name = "streetAdressInput";
            this.streetAdressInput.Size = new Size(127, 23);
            this.streetAdressInput.TabIndex = 19;
            this.streetAdressInput.TextChanged += this.input_TextChanged;
            // 
            // zipcodeInput
            // 
            this.zipcodeInput.Location = new Point(294, 230);
            this.zipcodeInput.Name = "zipcodeInput";
            this.zipcodeInput.Size = new Size(127, 23);
            this.zipcodeInput.TabIndex = 21;
            this.zipcodeInput.TextChanged += this.input_TextChanged;
            this.zipcodeInput.Validating += this.zipcodeInput_Validating;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new Point(294, 277);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new Size(127, 23);
            this.stateComboBox.TabIndex = 22;
            this.stateComboBox.TextChanged += this.input_TextChanged;
            this.stateComboBox.Validating += this.stateComboBox_Validating;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new Point(149, 320);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new Size(30, 15);
            this.roleLabel.TabIndex = 23;
            this.roleLabel.Text = "Role";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new Point(188, 318);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new Size(112, 23);
            this.roleComboBox.TabIndex = 24;
            this.roleComboBox.TextChanged += this.input_TextChanged;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new Point(38, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new Size(120, 23);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += this.cancelButton_Click;
            // 
            // addButton
            // 
            this.addButton.Location = new Point(294, 354);
            this.addButton.Name = "addButton";
            this.addButton.Size = new Size(127, 23);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add Employee";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(15, 111);
            this.label4.Name = "label4";
            this.label4.Size = new Size(59, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Firstname";
            // 
            // emailInput
            // 
            this.emailInput.Location = new Point(84, 147);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new Size(127, 23);
            this.emailInput.TabIndex = 9;
            this.emailInput.TextChanged += this.input_TextChanged;
            this.emailInput.Validating += this.emailInput_Validating;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new Point(35, 149);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new Size(36, 15);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email";
            // 
            // addUserError
            // 
            this.addUserError.ContainerControl = this;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new Point(294, 84);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new Size(108, 19);
            this.showPasswordCheckBox.TabIndex = 28;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += this.showPasswordCheckBox_CheckedChanged;
            // 
            // addDialogHeading
            // 
            this.addDialogHeading.BackColor = SystemColors.Control;
            this.addDialogHeading.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            this.addDialogHeading.Location = new Point(12, 12);
            this.addDialogHeading.Name = "addDialogHeading";
            this.addDialogHeading.ReadOnly = true;
            this.addDialogHeading.Size = new Size(417, 39);
            this.addDialogHeading.TabIndex = 29;
            this.addDialogHeading.Text = "Add Dialog";
            this.addDialogHeading.TextAlign = HorizontalAlignment.Center;
            // 
            // addUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 394);
            Controls.Add(this.addDialogHeading);
            Controls.Add(this.showPasswordCheckBox);
            Controls.Add(this.dobTimePicker);
            Controls.Add(this.emailInput);
            Controls.Add(this.emailLabel);
            Controls.Add(this.addButton);
            Controls.Add(this.cancelButton);
            Controls.Add(this.roleComboBox);
            Controls.Add(this.roleLabel);
            Controls.Add(this.stateComboBox);
            Controls.Add(this.zipcodeInput);
            Controls.Add(this.streetAdressInput);
            Controls.Add(this.cityInput);
            Controls.Add(this.label12);
            Controls.Add(this.label11);
            Controls.Add(this.label10);
            Controls.Add(this.label9);
            Controls.Add(this.label8);
            Controls.Add(this.phoneInput);
            Controls.Add(this.label7);
            Controls.Add(this.genderComboBox);
            Controls.Add(this.label6);
            Controls.Add(this.lastnameInput);
            Controls.Add(this.firstnameInput);
            Controls.Add(this.label5);
            Controls.Add(this.label4);
            Controls.Add(this.passwordInput);
            Controls.Add(this.passwordLabel);
            Controls.Add(this.usernameInput);
            Controls.Add(this.usernameLabel);
            Name = "AddUserForm";
            Text = "Add User";
            ((System.ComponentModel.ISupportInitialize)this.addUserError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
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
        private CheckBox showPasswordCheckBox;
        private TextBox addDialogHeading;
    }
}