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
        var login = new Login
        {
            Username = employee.Username,
            Password = employee.Password
        };

        if (!LoginDal.CreateLogin(login)) // TODO: Make procedure/function for creating employee and login
        {
            return false;
        }

        using var connection = new MySqlConnection(Connection.ConnectionString);
        try
        {
            connection.Execute(QueryStrings.CreateEmployee, employee);
            return true;
        }
        catch (Exception exception)
        {
            LoginDal.DeleteLogin(login);
            return false;
        }
    }

    public static bool DeleteEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.DeleteEmployee, employee);

        connection.Close();

        var login = new Login
        {
            Username = employee.Username,
            Password = employee.Password
        };

        if (!LoginDal.DeleteLogin(login)) // TODO: Make procedure/function for deleting employee and login
        {
            return false;
        }

        return affected > 0;
    }

    public static Employee GetEmployeeFromUsername(string username)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Employee>(QueryStrings.GetByEmployeeUsername, new { username });
        var employee = result.First();
        return employee;
    }

    public static bool UpdateEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.UpdateEmployee, employee);

        return affected > 0;
    }

    #endregion
}