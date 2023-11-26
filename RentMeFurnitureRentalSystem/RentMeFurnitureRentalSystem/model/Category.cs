namespace RentMeFurnitureRentalSystem.model;
/// <summary>
/// The category class which represents a category of furniture
/// </summary>
public class Category
{
    #region properties

    public string Name { get; set; }

    #endregion

    #region methods

    public override string ToString()
    {
        return Name;
    }

    #endregion
}