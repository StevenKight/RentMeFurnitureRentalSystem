using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;

public class EmployeeDal
{
    #region Methods

    public static List<Employee> GetAllEmployees()
    {
        var employees = new List<Employee>();

        using var connection = new MySqlConnection(Connection.ConnectionString);

        var query = "SELECT * FROM employee";
        connection.Open();

        using var adapter = new MySqlDataAdapter(query, connection);

        using var command = new MySqlCommand(query, connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var employee = new Employee();
            employee.SelectCommand(reader);
            employees.Add(employee);
        }

        return employees;
    }

    public static bool CreateEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        connection.Open();

        var query =
            "insert into employee(username,fname,lname,gender,phone,email,dob,address,city,state,zip,role_name) values(@username,@firstname,@lastname,@gender,@phone,@email,@dob,@address,@city,@state,@zipcode,@role_name)";
        var command = new MySqlCommand(query, connection);

        employee.FillCommand(command);

        try
        {
            var rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static Employee GetEmployeeFromUsername(string username)
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
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                employee.SelectCommand(reader);
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