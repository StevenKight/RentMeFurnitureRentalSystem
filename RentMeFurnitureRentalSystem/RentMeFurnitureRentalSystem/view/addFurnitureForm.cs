using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMeFurnitureRentalSystem.DAL;

namespace RentMeFurnitureRentalSystem.view
{
    public partial class addFurnitureForm : Form
    {
        #region Data members

        public const string RENTALANDFINERATEREGEX = @"(?:^[1-9]([0-9]+)?(?:\.[0-9]{1,2})?$)|(?:^(?:0)$)|(?:^[0-9]\.[0-9](?:[0-9])?$)";

        #endregion

        public addFurnitureForm()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.populateStyleComboBox();
            this.populateCategoryComboBox();
            this.setValidation();
        }

        private void populateStyleComboBox()
        {
            this.styleComboBox.Items.Clear();
            var styleList = StyleDAL.GetStyles();
            this.styleComboBox.DataSource = styleList;
        }

        private void populateCategoryComboBox()
        {
            this.categoryComboBox.Items.Clear();
            var CategoryList = CategoryDAL.GetCategories();
            this.categoryComboBox.DataSource = CategoryList;
        }

        private void setValidation()
        {
            this.rentalRateTextBox.Validating += rentalRate_Validating;
            this.fineRateTextBox.Validating += fineRate_Validating;
            this.nameTextBox.Validating += nameTextbox_Validating;
            this.descriptionTextArea.Validating += descriptionTextArea_Validating;
        }
        private void rentalRate_Validating(object sender, CancelEventArgs e)
        {
            var value = this.rentalRateTextBox.Text;
            if(!Regex.IsMatch(value, RENTALANDFINERATEREGEX))
            {
                e.Cancel = true;
                this.addFurnitureError.SetError(this.rentalRateTextBox,"Rental rate must be a positive decimal or integer");
            }
            else
            {
                e.Cancel = false;
                this.addFurnitureError.SetError(this.rentalRateTextBox,"");
            }
        }

        private void fineRate_Validating(Object sender, CancelEventArgs e)
        {
            var value = this.fineRateTextBox.Text;

            if (!Regex.IsMatch(value, RENTALANDFINERATEREGEX))
            {
                e.Cancel = true;
                this.addFurnitureError.SetError(this.fineRateTextBox,"Fine rate must be a positive decimal or integer");
            }
            else
            {
                e.Cancel = false;
                this.addFurnitureError.SetError(this.fineRateTextBox, "");
            }
        }

        private void nameTextbox_Validating(Object sender, CancelEventArgs e)
        {
            var value = this.nameTextBox.Text;
            if (String.IsNullOrWhiteSpace(value))
            {
                e.Cancel = true;
                this.addFurnitureError.SetError(this.nameTextBox,"Name cannot be empty");
            }
            else
            {
                e.Cancel = false;
                this.addFurnitureError.SetError(this.nameTextBox,"");
            }
        }

        private void descriptionTextArea_Validating(object sender, CancelEventArgs e)
        {
            var value = this.descriptionTextArea.Text;
            if (String.IsNullOrWhiteSpace(value))
            {
                e.Cancel = true;
                this.addFurnitureError.SetError(this.descriptionTextArea, "Name cannot be empty");
            }
            else
            {
                e.Cancel = false;
                this.addFurnitureError.SetError(this.descriptionTextArea, "");
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please fix errors before submitting");
                return;
            }
            
            Close();
        }
    }
}
