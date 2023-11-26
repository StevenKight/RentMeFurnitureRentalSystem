﻿using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;
using System.Data.Common;
using System.Transactions;

namespace RentMeFurnitureRentalSystem.DAL;
/// <summary>
///  EmployeeDal class that communicates with the database
/// </summary>
public class EmployeeDal
{
    #region Methods
    /// <summary>
    /// Gets all the employees from the database
    /// </summary>
    /// <returns></returns>
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
    /// <summary>
    /// Creates an employee in the database
    /// </summary>
    /// <param name="employee"></param>
    /// <returns></returns>
    public static bool CreateEmployee(Employee employee)
    {
        var login = new Login
        {
            Username = employee.Username,
            Password = employee.Password
        };

        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        if (!LoginDal.CreateLogin(login, connection))
        {
            return false;
        }

        var affected = connection.Execute(QueryStrings.CreateEmployee, employee);

        return affected > 0;
    }
    /// <summary>
    /// Deletes an employee from the database
    /// </summary>
    /// <param name="employee"></param>
    /// <returns></returns>
    public static bool DeleteEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();
            
        var affected = connection.Execute(QueryStrings.DeleteEmployee, employee);

        var login = new Login
        {
            Username = employee.Username,
            Password = employee.Password
        };

        if (!LoginDal.DeleteLogin(login))
        {
            return false;
        }
        return affected > 0;
    }
    /// <summary>
    /// Get an employee from the database by their username
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public static Employee GetEmployeeFromUsername(string username)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Employee>(QueryStrings.GetByEmployeeUsername, new { username });
        var employee = result.First();
        return employee;
    }
    /// <summary>
    /// Updates an employee in the database
    /// </summary>
    /// <param name="employee"></param>
    /// <returns></returns>
    public static bool UpdateEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.UpdateEmployee, employee);

        return affected > 0;
    }

    #endregion
}