namespace RentMeFurnitureRentalSystem.model;

public class Furniture
{
    #region properties

    public int Furniture_id { get; set; }
    public string Name { get; set; }
    public string Category_name { get; set; }
    public string Style_name { get; set; }
    public string Description { get; set; }
    public decimal Rental_rate { get; set; }
    public decimal Fine_rate { get; set; }
    public int Quantity { get; set; }

    #endregion
}