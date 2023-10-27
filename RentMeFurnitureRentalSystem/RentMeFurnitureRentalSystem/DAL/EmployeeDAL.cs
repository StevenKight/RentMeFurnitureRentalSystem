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

        foreach (var employee in result) employees.Add(employee);
        return employees;
    }

    public static bool CreateEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        try
        {
            connection.Execute(QueryStrings.CreateEmployee, new
            {
                employee.Username,
                Firstname = employee.Fname,
                Lastname = employee.Lname,
                employee.Gender,
                employee.Phone,
                employee.Email,
                employee.Dob,
                employee.Address,
                employee.City,
                employee.State,
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

        var result = connection.Query<Employee>(QueryStrings.GetByEmployeeUsername, new { username });
        var employee = result.First();
        return employee;
    }

    #endregion
}