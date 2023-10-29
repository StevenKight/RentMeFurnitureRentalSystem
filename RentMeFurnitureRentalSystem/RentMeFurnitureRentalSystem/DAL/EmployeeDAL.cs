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

        using var connection = new MySqlConnection(Connection.ConnectionString);
        using var transaction = connection.BeginTransaction();

        try
        {
            if (!LoginDal.CreateLogin(login, transaction)) // Create the login in the context of the transaction
            {
                transaction.Rollback();
                return false;
            }

            connection.Execute(QueryStrings.CreateEmployee, employee, transaction: transaction);

            transaction.Commit();
            return true;
        }
        catch (Exception exception)
        {
            transaction.Rollback();
            return false;
        }
    }

    public static bool DeleteEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        using var transaction = connection.BeginTransaction();

        try
        {
            var affected = connection.Execute(QueryStrings.DeleteEmployee, employee, transaction: transaction);

            var login = new Login
            {
                Username = employee.Username,
                Password = employee.Password
            };

            if (!LoginDal.DeleteLogin(login, transaction))
            {
                transaction.Rollback(); // Rollback the transaction if deleting the login fails
                return false;
            }

            // Commit the transaction if all operations are successful
            transaction.Commit();

            return affected > 0;
        }
        catch (Exception ex)
        {
            // Handle exceptions or errors here
            Console.WriteLine("An error occurred: " + ex.Message);
            transaction.Rollback(); // Rollback the transaction on exception
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

    public static bool UpdateEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.UpdateEmployee, employee);

        return affected > 0;
    }

    #endregion
}