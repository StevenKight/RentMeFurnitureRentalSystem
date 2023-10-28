namespace RentMeFurnitureRentalSystem.model;

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