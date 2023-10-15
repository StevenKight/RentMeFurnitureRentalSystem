using MySql.Data.MySqlClient;

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

    #region Methods

    public void FillCommand(MySqlCommand query)
    {
        query.Parameters.Add("@fname", MySqlDbType.VarChar).Value = this.Firstname;
        query.Parameters.Add("@lname", MySqlDbType.VarChar).Value = this.Lastname;
        query.Parameters.Add("@dob", MySqlDbType.DateTime).Value = this.Birthday;
        query.Parameters.Add("@gender", MySqlDbType.VarChar).Value = this.Gender;
        query.Parameters.Add("@email", MySqlDbType.VarChar).Value = this.Email;
        query.Parameters.Add("@phone", MySqlDbType.VarChar).Value = this.Phone;
        query.Parameters.Add("@address", MySqlDbType.VarChar).Value = this.StreetAddress;
        query.Parameters.Add("@city", MySqlDbType.VarChar).Value = this.City;
        query.Parameters.Add("@state", MySqlDbType.VarChar).Value = this.State;
        query.Parameters.Add("@zip", MySqlDbType.VarChar).Value = this.Zipcode;
    }

    public void SelectCommand(MySqlDataReader reader)
    {
        var nameOrdinal = reader.GetOrdinal("fname");
        var lnameOrdinal = reader.GetOrdinal("lname");
        var dobOrdinal = reader.GetOrdinal("dob");
        var genderOrdinal = reader.GetOrdinal("gender");
        var emailOrdinal = reader.GetOrdinal("email");
        var phoneOrdinal = reader.GetOrdinal("phone");
        var addressOrdinal = reader.GetOrdinal("address");
        var cityOrdinal = reader.GetOrdinal("city");
        var stateOrdinal = reader.GetOrdinal("state");
        var zipOrdinal = reader.GetOrdinal("zip");
        var registerDateOrdinal = reader.GetOrdinal("register_date");

        this.Firstname = reader.GetString(nameOrdinal);
        this.Lastname = reader.GetString(lnameOrdinal);
        this.Birthday = reader.GetDateTime(dobOrdinal);
        this.Gender = reader.GetString(genderOrdinal);
        this.Email = reader.GetString(emailOrdinal);
        this.Phone = reader.GetString(phoneOrdinal);
        this.StreetAddress = reader.GetString(addressOrdinal);
        this.City = reader.GetString(cityOrdinal);
        this.State = reader.GetString(stateOrdinal);
        this.Zipcode = reader.GetString(zipOrdinal);
        this.RegistrationDate = reader.GetDateTime(registerDateOrdinal);
    }

    #endregion
}