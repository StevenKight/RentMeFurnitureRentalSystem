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

    #endregion
}