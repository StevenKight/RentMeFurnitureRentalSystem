﻿namespace RentMeFurnitureRentalSystem.Model;

/// <summary>
///     The class which represents the rental item
/// </summary>
public class RentalItem
{
    #region Properties

    public int Rental_id { get; set; }
    public int Return_id { get; set; }
    public int Member_id { get; set; }
    public int Employee_num { get; set; }
    public DateTime Start_date { get; set; }
    public DateTime Due_date { get; set; }
    public int Furniture_id { get; set; }
    public int Quantity { get; set; }

    #endregion
}