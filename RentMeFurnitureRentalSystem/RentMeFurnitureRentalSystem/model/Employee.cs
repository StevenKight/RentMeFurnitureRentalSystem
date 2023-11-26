namespace RentMeFurnitureRentalSystem.model;
/// <summary>
/// Employee class that represents an employee in the database
/// </summary>
public class Employee
{
    #region Properties

    public string Fullname => this.Fname + " " + this.Lname;
    public int Employee_num { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string Gender { get; set; }
    public string Phone { get; set; }
    public DateTime Dob { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Email { get; set; }
    public string Role_name { get; set; }

    #endregion
}