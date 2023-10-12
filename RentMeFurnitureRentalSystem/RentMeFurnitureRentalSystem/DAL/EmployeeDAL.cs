using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;

public class EmployeeDAL
{
    #region Methods

    public bool CreateEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        connection.Open();

        var query =
            "insert into employee(username,password,fname,lname,gender,phone,email,dob,address,city,state,zip,role_name) values(@username,@password,@firstname,@lastname,@gender,@phone,@email,@dob,@address,@city,@state,@zipcode,@role)";
        var command = new MySqlCommand(query, connection);

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = employee.Username;
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = employee.Password;
        command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = employee.Firstname;
        command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = employee.Lastname;
        command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = employee.Gender;
        command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = employee.Phone;
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = employee.email;
        command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = employee.Dob.ToString("yyyy-MM-dd");
        command.Parameters.Add("@address", MySqlDbType.VarChar).Value = employee.Address;
        command.Parameters.Add("@city", MySqlDbType.VarChar).Value = employee.City;
        command.Parameters.Add("@state", MySqlDbType.VarChar).Value = employee.State;
        command.Parameters.Add("@zipcode", MySqlDbType.VarChar).Value = employee.Zipcode;
        command.Parameters.Add("@role", MySqlDbType.VarChar).Value = employee.Role;

        var rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
            return true;
        }

        return false;
    }

    //public Employee GetEmployeeFromUsername(string username)
    //{

    //}

    #endregion
}