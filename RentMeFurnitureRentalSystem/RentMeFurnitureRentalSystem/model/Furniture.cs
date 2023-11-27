namespace RentMeFurnitureRentalSystem.Model;

/// <summary>
///     furniture class that represents a furniture in the database
/// </summary>
public class Furniture
{
    #region Methods

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (obj.GetType() != typeof(Furniture))
        {
            return false;
        }

        return this.FurnitureId == ((Furniture)obj).FurnitureId;
    }

    #endregion

    #region properties

    public int FurnitureId { get; set; }
    public int RentalId { get; set; }
    public string Name { get; set; }
    public string CategoryName { get; set; }
    public string StyleName { get; set; }
    public string Description { get; set; }
    public decimal RentalRate { get; set; }
    public decimal FineRate { get; set; }
    public int Quantity { get; set; }
    public int DisplayQuantity { get; set; }

    #endregion
}