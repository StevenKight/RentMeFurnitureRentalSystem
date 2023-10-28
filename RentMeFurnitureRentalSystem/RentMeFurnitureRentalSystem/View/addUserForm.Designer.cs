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
            components = new System.ComponentModel.Container();
            usernameLabel = new Label();
            addDialogHeading = new Label();
            usernameInput = new TextBox();
            passwordLabel = new Label();
            passwordInput = new TextBox();
            label5 = new Label();
            firstnameInput = new TextBox();
            lastnameInput = new TextBox();
            label6 = new Label();
            genderComboBox = new ComboBox();
            label7 = new Label();
            phoneInput = new TextBox();
            dobTimePicker = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cityInput = new TextBox();
            streetAdressInput = new TextBox();
            zipcodeInput = new TextBox();
            stateComboBox = new ComboBox();
            roleLabel = new Label();
            roleComboBox = new ComboBox();
            cancelButton = new Button();
            addButton = new Button();
            label4 = new Label();
            emailInput = new TextBox();
            emailLabel = new Label();
            addUserError = new ErrorProvider(components);
            showPasswordCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)addUserError).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(13, 62);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // addDialogHeading
            // 
            addDialogHeading.AutoSize = true;
            addDialogHeading.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addDialogHeading.Location = new Point(128, 9);
            addDialogHeading.Name = "addDialogHeading";
            addDialogHeading.Size = new Size(133, 32);
            addDialogHeading.TabIndex = 1;
            addDialogHeading.Text = "Add Dialog";
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(84, 59);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(127, 23);
            usernameInput.TabIndex = 2;
            usernameInput.Validating += textInput_Validating;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(228, 62);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(294, 59);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(127, 23);
            passwordInput.TabIndex = 4;
            passwordInput.UseSystemPasswordChar = true;
            passwordInput.Validating += textInput_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 111);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 6;
            label5.Text = "Lname";
            // 
            // firstnameInput
            // 
            firstnameInput.Location = new Point(84, 109);
            firstnameInput.Name = "firstnameInput";
            firstnameInput.Size = new Size(127, 23);
            firstnameInput.TabIndex = 7;
            firstnameInput.Validating += textInput_Validating;
            // 
            // lastnameInput
            // 
            lastnameInput.Location = new Point(294, 109);
            lastnameInput.Name = "lastnameInput";
            lastnameInput.Size = new Size(127, 23);
            lastnameInput.TabIndex = 8;
            lastnameInput.Validating += textInput_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 190);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 9;
            label6.Text = "Gender";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(84, 188);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(127, 23);
            genderComboBox.TabIndex = 11;
            genderComboBox.Validating += genderComboBox_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(245, 147);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 11;
            label7.Text = "Phone";
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(294, 145);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(127, 23);
            phoneInput.TabIndex = 10;
            phoneInput.Validating += phoneInput_Validating;
            // 
            // dobTimePicker
            // 
            dobTimePicker.Format = DateTimePickerFormat.Short;
            dobTimePicker.Location = new Point(294, 187);
            dobTimePicker.Name = "dobTimePicker";
            dobTimePicker.Size = new Size(127, 23);
            dobTimePicker.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(233, 190);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 14;
            label8.Text = "Birthday";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 232);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 15;
            label9.Text = "Street";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(251, 279);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 16;
            label10.Text = "State";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 279);
            label11.Name = "label11";
            label11.Size = new Size(28, 15);
            label11.TabIndex = 17;
            label11.Text = "City";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(233, 232);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 18;
            label12.Text = "Zip";
            // 
            // cityInput
            // 
            cityInput.Location = new Point(84, 277);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(127, 23);
            cityInput.TabIndex = 20;
            cityInput.Validating += textInput_Validating;
            // 
            // streetAdressInput
            // 
            streetAdressInput.Location = new Point(84, 230);
            streetAdressInput.Name = "streetAdressInput";
            streetAdressInput.Size = new Size(127, 23);
            streetAdressInput.TabIndex = 19;
            streetAdressInput.Validating += textInput_Validating;
            // 
            // zipcodeInput
            // 
            zipcodeInput.Location = new Point(294, 230);
            zipcodeInput.Name = "zipcodeInput";
            zipcodeInput.Size = new Size(127, 23);
            zipcodeInput.TabIndex = 21;
            zipcodeInput.Validating += zipcodeInput_Validating;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(294, 277);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(127, 23);
            stateComboBox.TabIndex = 22;
            stateComboBox.Validating += stateComboBox_Validating;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(149, 320);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(30, 15);
            roleLabel.TabIndex = 23;
            roleLabel.Text = "Role_name";
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(188, 318);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(112, 23);
            roleComboBox.TabIndex = 24;
            roleComboBox.Validating += roleComboBox_Validating;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(38, 354);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 23);
            cancelButton.TabIndex = 26;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(294, 354);
            addButton.Name = "addButton";
            addButton.Size = new Size(127, 23);
            addButton.TabIndex = 25;
            addButton.Text = "Add Employee";
            addButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 111);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "Fname";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(84, 147);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(127, 23);
            emailInput.TabIndex = 9;
            emailInput.Validating += emailInput_Validating;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(35, 149);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email";
            // 
            // addUserError
            // 
            addUserError.ContainerControl = this;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(294, 84);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(108, 19);
            showPasswordCheckBox.TabIndex = 28;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // addUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 394);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(dobTimePicker);
            Controls.Add(emailInput);
            Controls.Add(emailLabel);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(roleComboBox);
            Controls.Add(roleLabel);
            Controls.Add(stateComboBox);
            Controls.Add(zipcodeInput);
            Controls.Add(streetAdressInput);
            Controls.Add(cityInput);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(phoneInput);
            Controls.Add(label7);
            Controls.Add(genderComboBox);
            Controls.Add(label6);
            Controls.Add(lastnameInput);
            Controls.Add(firstnameInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(passwordInput);
            Controls.Add(passwordLabel);
            Controls.Add(usernameInput);
            Controls.Add(addDialogHeading);
            Controls.Add(usernameLabel);
            Name = "addUserForm";
            Text = "Add User";
            ((System.ComponentModel.ISupportInitialize)addUserError).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private CheckBox showPasswordCheckBox;
    }
}