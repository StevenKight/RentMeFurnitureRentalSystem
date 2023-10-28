using MySql.Data.MySqlClient;
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
        query.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username;
        query.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
        query.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = Fname;
        query.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = Lname;
        query.Parameters.Add("@gender", MySqlDbType.VarChar).Value = Gender;
        query.Parameters.Add("@phone", MySqlDbType.VarChar).Value = Phone;
        query.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
        query.Parameters.Add("@dob", MySqlDbType.VarChar).Value = Dob.ToString("yyyy-MM-dd");
        query.Parameters.Add("@address", MySqlDbType.VarChar).Value = Address;
        query.Parameters.Add("@city", MySqlDbType.VarChar).Value = City;
        query.Parameters.Add("@state", MySqlDbType.VarChar).Value = State;
        query.Parameters.Add("@zipcode", MySqlDbType.VarChar).Value = Zip;
        query.Parameters.Add("@role_name", MySqlDbType.VarChar).Value = Role_name;
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

        EmployeeNum = reader.GetInt16(idOrdinal);
        Username = reader.GetString(usernameOrdinal);
        Fname = reader.GetString(nameOrdinal);
        Lname = reader.GetString(lnameOrdinal);
        Gender = reader.GetString(genderOrdinal);
        Email = reader.GetString(emailOrdinal);
        Phone = reader.GetString(phoneOrdinal);
        Address = reader.GetString(addressOrdinal);
        City = reader.GetString(cityOrdinal);
        State = reader.GetString(stateOrdinal);
        Zip = reader.GetString(zipOrdinal);
        Role_name = reader.GetString(roleOrdinal);
        Dob = reader.GetDateTime(dobOrdinal);

        var login = LoginDal.CheckLogin(Username);
        Password = login.Password;
    }

    #endregion
}