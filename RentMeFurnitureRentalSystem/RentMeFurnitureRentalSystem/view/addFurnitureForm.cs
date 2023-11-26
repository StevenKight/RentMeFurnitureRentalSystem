using System.ComponentModel;
using System.Text.RegularExpressions;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.view;
/// <summary>
/// The form for adding furniture
/// </summary>
public partial class addFurnitureForm : Form
{
    #region Data members
    /// <summary>
    /// Regex for validating rental and fine rates
    /// </summary>
    public const string RENTALANDFINERATEREGEX =
        @"(?:^[1-9]([0-9]+)?(?:\.[0-9]{1,2})?$)|(?:^(?:0)$)|(?:^[0-9]\.[0-9](?:[0-9])?$)";

    #endregion
    /// <summary>
    /// Creates a new instance of the add furniture form
    /// </summary>
    public addFurnitureForm()
    {
        InitializeComponent();
        AutoValidate = AutoValidate.EnableAllowFocusChange;
        populateStyleComboBox();
        populateCategoryComboBox();
        setValidation();
    }

    private void populateStyleComboBox()
    {
        styleComboBox.Items.Clear();
        var styleList = StyleDAL.GetStyles();
        styleComboBox.DataSource = styleList;
    }

    private void populateCategoryComboBox()
    {
        categoryComboBox.Items.Clear();
        var CategoryList = CategoryDAL.GetCategories();
        categoryComboBox.DataSource = CategoryList;
    }

    private void setValidation()
    {
        rentalRateTextBox.Validating += rentalRate_Validating;
        fineRateTextBox.Validating += fineRate_Validating;
        nameTextBox.Validating += nameTextbox_Validating;
        descriptionTextArea.Validating += descriptionTextArea_Validating;
    }

    private void rentalRate_Validating(object sender, CancelEventArgs e)
    {
        var value = rentalRateTextBox.Text;
        if (!Regex.IsMatch(value, RENTALANDFINERATEREGEX))
        {
            e.Cancel = true;
            addFurnitureError.SetError(rentalRateTextBox, "Rental rate must be a positive decimal or integer");
        }
        else
        {
            e.Cancel = false;
            addFurnitureError.SetError(rentalRateTextBox, "");
        }
    }

    private void fineRate_Validating(object sender, CancelEventArgs e)
    {
        var value = fineRateTextBox.Text;

        if (!Regex.IsMatch(value, RENTALANDFINERATEREGEX))
        {
            e.Cancel = true;
            addFurnitureError.SetError(fineRateTextBox, "Fine rate must be a positive decimal or integer");
        }
        else
        {
            e.Cancel = false;
            addFurnitureError.SetError(fineRateTextBox, "");
        }
    }

    private void nameTextbox_Validating(object sender, CancelEventArgs e)
    {
        var value = nameTextBox.Text;
        if (string.IsNullOrWhiteSpace(value))
        {
            e.Cancel = true;
            addFurnitureError.SetError(nameTextBox, "Name cannot be empty");
        }
        else
        {
            e.Cancel = false;
            addFurnitureError.SetError(nameTextBox, "");
        }
    }

    private void descriptionTextArea_Validating(object sender, CancelEventArgs e)
    {
        var value = descriptionTextArea.Text;
        if (string.IsNullOrWhiteSpace(value))
        {
            e.Cancel = true;
            addFurnitureError.SetError(descriptionTextArea, "Name cannot be empty");
        }
        else
        {
            e.Cancel = false;
            addFurnitureError.SetError(descriptionTextArea, "");
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        AutoValidate = AutoValidate.Disable;
        Close();

    }

    private void addButton_Click(object sender, EventArgs e)
    {
        if (!ValidateChildren(ValidationConstraints.Enabled))
        {
            MessageBox.Show("Please fix errors before submitting");
            return;
        }

        var furniture = new Furniture
        {
            Name = nameTextBox.Text,
            Description = descriptionTextArea.Text,
            Category_name = categoryComboBox.Text,
            Style_name = styleComboBox.Text,
            Rental_rate = decimal.Parse(rentalRateTextBox.Text),
            Fine_rate = decimal.Parse(fineRateTextBox.Text),
            Quantity = int.Parse(quantiyNumber.Text)
        };


        if (!FurnitureDAL.CreateFurniture(furniture))
            MessageBox.Show("Error creating furniture");
        else
            MessageBox.Show("Created furniture");
        this.Close();
    }
}