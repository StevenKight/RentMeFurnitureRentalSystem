using Dapper;
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

        var result = connection.Query<Employee>(QueryStrings.GetEmployees);

        foreach (var employee in result)
        {
            employees.Add(employee);
        }
        return employees;
    }

    public static bool CreateEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        try
        {
            connection.Execute(QueryStrings.CreateEmployee, new
            {
                Username = employee.Username,
                Firstname = employee.Fname,
                Lastname = employee.Lname,
                Gender = employee.Gender,
                Phone = employee.Phone,
                Email = employee.Email,
                Dob = employee.Dob,
                Address = employee.Address,
                City = employee.City,
                State = employee.State,
                Zipcode = employee.Zip,
                Role = employee.Role_name
            });
            return true;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
            return false;
        }
    }

    public static Employee GetEmployeeFromUsername(string username)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Employee>(QueryStrings.GetByEmployeeUsername, new { username = username });
        Employee employee = result.First();
        return employee;
    }

    #endregion
}