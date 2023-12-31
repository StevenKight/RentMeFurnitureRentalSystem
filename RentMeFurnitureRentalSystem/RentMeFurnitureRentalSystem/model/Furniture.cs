﻿namespace RentMeFurnitureRentalSystem.Model;

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

        return this.Furniture_id == ((Furniture)obj).Furniture_id;
    }

    #endregion

    #region properties

    public int Furniture_id { get; set; }
    public int RentalId { get; set; }
    public string Name { get; set; }
    public string Category_name { get; set; }
    public string Style_name { get; set; }
    public string Description { get; set; }
    public decimal Rental_rate { get; set; }
    public decimal Fine_rate { get; set; }
    public int Quantity { get; set; }
    public int DisplayQuantity { get; set; }

    #endregion
}