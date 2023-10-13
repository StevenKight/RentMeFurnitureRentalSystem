using Microsoft.VisualBasic.Logging;
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

    public Employee GetEmployeeFromUsername(string username)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        var employee = new Employee();
        connection.Open();

        var query =
            "Select * from employee where username=@username";
       
        try
        {
            var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    employee.EmployeeNum = reader.GetInt32(0);
                    employee.Username = reader.GetString(1);
                    employee.Password = reader.GetString(2);
                    employee.Firstname = reader.GetString(3);
                    employee.Lastname = reader.GetString(4);
                    employee.Gender = reader.GetString(5);
                    employee.Phone = reader.GetString(6);
                    employee.email = reader.GetString(7);
                    employee.Dob = reader.GetDateTime(8);
                    employee.Address = reader.GetString(9);
                    employee.City = reader.GetString(10);
                    employee.State = reader.GetString(11);
                    employee.Zipcode = reader.GetString(12);
                    employee.Role = reader.GetString(13);

                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

        return employee;
    }

    #endregion
}