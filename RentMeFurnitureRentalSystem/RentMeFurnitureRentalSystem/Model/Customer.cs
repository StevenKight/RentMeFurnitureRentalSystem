using MySql.Data.MySqlClient;

namespace RentMeFurnitureRentalSystem.Model;

public class Customer
{
    #region Properties

    public string Fullname => this.Fname + " " + this.Lname;

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

    #region Methods

    public void FillCommand(MySqlCommand query)
    {
        query.Parameters.Add("@fname", MySqlDbType.VarChar).Value = Fname;
        query.Parameters.Add("@lname", MySqlDbType.VarChar).Value = Lname;
        query.Parameters.Add("@dob", MySqlDbType.DateTime).Value = Dob;
        query.Parameters.Add("@gender", MySqlDbType.VarChar).Value = Gender;
        query.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
        query.Parameters.Add("@phone", MySqlDbType.VarChar).Value = Phone;
        query.Parameters.Add("@address", MySqlDbType.VarChar).Value = Address;
        query.Parameters.Add("@city", MySqlDbType.VarChar).Value = City;
        query.Parameters.Add("@state", MySqlDbType.VarChar).Value = State;
        query.Parameters.Add("@zip", MySqlDbType.VarChar).Value = Zip;
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

        Fname = reader.GetString(nameOrdinal);
        Lname = reader.GetString(lnameOrdinal);
        Dob = reader.GetDateTime(dobOrdinal);
        Gender = reader.GetString(genderOrdinal);
        Email = reader.GetString(emailOrdinal);
        Phone = reader.GetString(phoneOrdinal);
        Address = reader.GetString(addressOrdinal);
        City = reader.GetString(cityOrdinal);
        State = reader.GetString(stateOrdinal);
        Zip = reader.GetString(zipOrdinal);
        Register_date = reader.GetDateTime(registerDateOrdinal);
    }

    #endregion
}