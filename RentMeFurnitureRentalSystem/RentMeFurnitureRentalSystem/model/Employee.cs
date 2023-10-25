﻿using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.DAL;

namespace RentMeFurnitureRentalSystem.model;

public class Employee
{
    #region Properties

    public int EmployeeNum { get; set; }
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

    #region Methods

    public void FillCommand(MySqlCommand query)
    {
        query.Parameters.Add("@username", MySqlDbType.VarChar).Value = this.Username;
        query.Parameters.Add("@password", MySqlDbType.VarChar).Value = this.Password;
        query.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = this.Fname;
        query.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = this.Lname;
        query.Parameters.Add("@gender", MySqlDbType.VarChar).Value = this.Gender;
        query.Parameters.Add("@phone", MySqlDbType.VarChar).Value = this.Phone;
        query.Parameters.Add("@email", MySqlDbType.VarChar).Value = this.Email;
        query.Parameters.Add("@dob", MySqlDbType.VarChar).Value = this.Dob.ToString("yyyy-MM-dd");
        query.Parameters.Add("@address", MySqlDbType.VarChar).Value = this.Address;
        query.Parameters.Add("@city", MySqlDbType.VarChar).Value = this.City;
        query.Parameters.Add("@state", MySqlDbType.VarChar).Value = this.State;
        query.Parameters.Add("@zipcode", MySqlDbType.VarChar).Value = this.Zip;
        query.Parameters.Add("@role_name", MySqlDbType.VarChar).Value = this.Role_name;
    }

    public void SelectCommand(MySqlDataReader reader)
    {
        var idOrdinal = reader.GetOrdinal("employee_num");
        var usernameOrdinal = reader.GetOrdinal("username");
        var nameOrdinal = reader.GetOrdinal("fname");
        var lnameOrdinal = reader.GetOrdinal("lname");
        var genderOrdinal = reader.GetOrdinal("gender");
        var emailOrdinal = reader.GetOrdinal("email");
        var phoneOrdinal = reader.GetOrdinal("phone");
        var dobOrdinal = reader.GetOrdinal("dob");
        var addressOrdinal = reader.GetOrdinal("address");
        var cityOrdinal = reader.GetOrdinal("city");
        var stateOrdinal = reader.GetOrdinal("state");
        var zipOrdinal = reader.GetOrdinal("zip");
        var roleOrdinal = reader.GetOrdinal("role_name");

        this.EmployeeNum = reader.GetInt16(idOrdinal);
        this.Username = reader.GetString(usernameOrdinal);
        this.Fname = reader.GetString(nameOrdinal);
        this.Lname = reader.GetString(lnameOrdinal);
        this.Gender = reader.GetString(genderOrdinal);
        this.Email = reader.GetString(emailOrdinal);
        this.Phone = reader.GetString(phoneOrdinal);
        this.Address = reader.GetString(addressOrdinal);
        this.City = reader.GetString(cityOrdinal);
        this.State = reader.GetString(stateOrdinal);
        this.Zip = reader.GetString(zipOrdinal);
        this.Role_name = reader.GetString(roleOrdinal);
        this.Dob = reader.GetDateTime(dobOrdinal);

        var login = LoginDal.CheckLogin(this.Username);
        this.Password = login.Password;
    }

    #endregion
}