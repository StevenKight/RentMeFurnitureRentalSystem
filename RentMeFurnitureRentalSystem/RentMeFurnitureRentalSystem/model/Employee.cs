﻿using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.DAL;

namespace RentMeFurnitureRentalSystem.model;

public class Employee
{
    #region Properties

    public int EmployeeNum { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Gender { get; set; }
    public string Phone { get; set; }
    public DateTime Dob { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }

    #endregion
}