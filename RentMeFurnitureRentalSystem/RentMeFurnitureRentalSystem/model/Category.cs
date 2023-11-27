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

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj == this) return true;
        if (obj.GetType() != typeof(Style))
            return false;

        return this.Name.Equals(((Style)obj).Name);
    }

    #endregion
}