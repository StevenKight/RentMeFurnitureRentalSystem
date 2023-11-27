namespace RentMeFurnitureRentalSystem.Model;

/// <summary>
///     The class which represents the rental item
/// </summary>
public class RentalItem
{
    #region Properties

    public int RentalId { get; set; }
    public int ReturnId { get; set; }
    public int MemberId { get; set; }
    public int EmployeeNum { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DueDate { get; set; }
    public int FurnitureId { get; set; }
    public int Quantity { get; set; }

    #endregion
}