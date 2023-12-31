﻿namespace RentMeFurnitureRentalSystem.Model;

/// <summary>
///     Customer class which represents a customer
/// </summary>
public class Customer
{
    #region Properties

    public string Fullname => this.Fname + " " + this.Lname;

    public int Member_id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public DateTime Dob { get; set; }
    public string Gender { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public DateTime Register_date { get; set; }

    #endregion
}