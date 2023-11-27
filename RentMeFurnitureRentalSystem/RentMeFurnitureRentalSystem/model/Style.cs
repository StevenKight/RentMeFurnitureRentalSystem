namespace RentMeFurnitureRentalSystem.model;
/// <summary>
/// Style class that represents a style in the database
/// </summary>
public class Style
{
    #region properties

    public string Name { get; set; }

    #endregion

    #region methods
    /// <summary>
    /// Returns the name of the style
    /// </summary>
    /// <returns></returns>
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