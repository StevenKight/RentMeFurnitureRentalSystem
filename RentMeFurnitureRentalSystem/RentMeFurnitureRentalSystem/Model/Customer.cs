namespace RentMeFurnitureRentalSystem.Model;

public class Customer
{
    #region Properties

    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime Birthday { get; set; }
    public string Gender { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }
    public DateTime RegistrationDate { get; set; }

    #endregion
}