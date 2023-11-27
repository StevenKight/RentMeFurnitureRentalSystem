using System.ComponentModel;
using System.Text.RegularExpressions;
using RentMeFurnitureRentalSystem.DAL;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.View;

/// <summary>
///     The form for adding furniture
/// </summary>
public partial class AddFurnitureForm : Form
{
    #region Data members

    /// <summary>
    ///     Regex for validating rental and fine rates
    /// </summary>
    public const string Rentalandfinerateregex =
        @"(?:^[1-9]([0-9]+)?(?:\.[0-9]{1,2})?$)|(?:^(?:0)$)|(?:^[0-9]\.[0-9](?:[0-9])?$)";

    private readonly Furniture furniture;

    #endregion

    #region Constructors

    /// <summary>
    ///     Creates a new instance of the add furniture form
    /// </summary>
    public AddFurnitureForm()
    {
        this.InitializeComponent();
        AutoValidate = AutoValidate.EnableAllowFocusChange;
        this.populateStyleComboBox();
        this.populateCategoryComboBox();
        this.setValidation();
    }

    /// <summary>
    ///     Creates a new instance of the add furniture form
    /// </summary>
    /// <param name="furniture">The furniture to update</param>
    public AddFurnitureForm(Furniture furniture)
    {
        this.furniture = furniture;

        this.InitializeComponent();
        AutoValidate = AutoValidate.EnableAllowFocusChange;

        this.populateStyleComboBox();
        this.populateCategoryComboBox();
        this.setValidation();

        this.fillForm();
    }

    #endregion

    #region Methods

    private void populateStyleComboBox()
    {
        this.styleComboBox.Items.Clear();
        var styleList = StyleDal.GetStyles();
        this.styleComboBox.DataSource = styleList;
    }

    private void populateCategoryComboBox()
    {
        this.categoryComboBox.Items.Clear();
        var categoryList = CategoryDal.GetCategories();
        this.categoryComboBox.DataSource = categoryList;
    }

    private void setValidation()
    {
        this.rentalRateTextBox.Validating += this.rentalRate_Validating;
        this.fineRateTextBox.Validating += this.fineRate_Validating;
        this.nameTextBox.Validating += this.nameTextbox_Validating;
        this.descriptionTextArea.Validating += this.descriptionTextArea_Validating;
    }

    private void fillForm()
    {
        this.addButton.Text = "Update";

        this.rentalRateTextBox.Text = this.furniture.RentalRate.ToString();
        this.fineRateTextBox.Text = this.furniture.FineRate.ToString();
        this.nameTextBox.Text = this.furniture.Name;
        this.descriptionTextArea.Text = this.furniture.Description;
        this.quantiyNumber.Value = this.furniture.Quantity;

        var styles = this.styleComboBox.Items.Cast<Style>().ToList();
        var categories = this.categoryComboBox.Items.Cast<Category>().ToList();

        var style = styles.FirstOrDefault(x => this.furniture.StyleName.Equals(x.Name));
        var category = categories.FirstOrDefault(x => this.furniture.CategoryName.Equals(x.Name));

        var styleIndex = styles.IndexOf(style ?? styles[0]);
        var categoryIndex = categories.IndexOf(category ?? categories[0]);

        this.styleComboBox.SelectedIndex = styleIndex;
        this.categoryComboBox.SelectedIndex = categoryIndex;
    }

    private void rentalRate_Validating(object sender, CancelEventArgs e)
    {
        var value = this.rentalRateTextBox.Text;
        if (!Regex.IsMatch(value, Rentalandfinerateregex))
        {
            e.Cancel = true;
            this.addFurnitureError.SetError(this.rentalRateTextBox,
                "Rental rate must be a positive decimal or integer");
        }
        else
        {
            e.Cancel = false;
            this.addFurnitureError.SetError(this.rentalRateTextBox, "");
        }
    }

    private void fineRate_Validating(object sender, CancelEventArgs e)
    {
        var value = this.fineRateTextBox.Text;

        if (!Regex.IsMatch(value, Rentalandfinerateregex))
        {
            e.Cancel = true;
            this.addFurnitureError.SetError(this.fineRateTextBox, "Fine rate must be a positive decimal or integer");
        }
        else
        {
            e.Cancel = false;
            this.addFurnitureError.SetError(this.fineRateTextBox, "");
        }
    }

    private void nameTextbox_Validating(object sender, CancelEventArgs e)
    {
        var value = this.nameTextBox.Text;
        if (string.IsNullOrWhiteSpace(value))
        {
            e.Cancel = true;
            this.addFurnitureError.SetError(this.nameTextBox, "Name cannot be empty");
        }
        else
        {
            e.Cancel = false;
            this.addFurnitureError.SetError(this.nameTextBox, "");
        }
    }

    private void descriptionTextArea_Validating(object sender, CancelEventArgs e)
    {
        var value = this.descriptionTextArea.Text;
        if (string.IsNullOrWhiteSpace(value))
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
        if (!ValidateChildren(ValidationConstraints.Enabled))
        {
            MessageBox.Show("Please fix errors before submitting");
            return;
        }

        var furniture = new Furniture
        {
            Name = this.nameTextBox.Text,
            Description = this.descriptionTextArea.Text,
            CategoryName = this.categoryComboBox.Text,
            StyleName = this.styleComboBox.Text,
            RentalRate = decimal.Parse(this.rentalRateTextBox.Text),
            FineRate = decimal.Parse(this.fineRateTextBox.Text),
            Quantity = int.Parse(this.quantiyNumber.Text)
        };

        if (this.furniture == null) // Add new furniture
        {
            if (!FurnitureDal.CreateFurniture(furniture))
            {
                MessageBox.Show("Error creating furniture");
            }
            else
            {
                MessageBox.Show("Created furniture");
            }
        }
        else // Update existing furniture
        {
            furniture.FurnitureId = this.furniture.FurnitureId;

            if (!FurnitureDal.UpdateFurniture(furniture))
            {
                MessageBox.Show("Error updating furniture");
            }
            else
            {
                MessageBox.Show("Updated furniture");
            }
        }

        Close();
    }

    #endregion
}