using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;
using System.Transactions;

namespace RentMeFurnitureRentalSystem.DAL;

public class LoginDal
{
    #region Methods

    public static bool CreateLogin(Login login, MySqlTransaction transaction)
    {
        if (string.IsNullOrWhiteSpace(login.Username) || string.IsNullOrWhiteSpace(login.Password))
        {
            return false;
        }

        using var connection = transaction?.Connection ?? new MySqlConnection(Connection.ConnectionString);
        if (transaction == null)
        {
            connection.Open();
        }

        try
        {
            connection.Execute(QueryStrings.CreateLogin, new { username = login.Username, password = login.Password }, transaction);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool DeleteLogin(Login login, MySqlTransaction transaction = null)
    {
        using var connection = transaction?.Connection ?? new MySqlConnection(Connection.ConnectionString);

        if (transaction == null)
        {
            connection.Open();
        }

        var affected = connection.Execute(QueryStrings.DeleteLogin, login, transaction);

        return affected > 0;
    }

    public static Login CheckLogin(string username)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var loginResult = connection.Query<Login>(QueryStrings.GetLoginByName, new { username });

        return loginResult.ElementAt(0);
    }

    #endregion
}