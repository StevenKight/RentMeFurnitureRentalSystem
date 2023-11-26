using System.Diagnostics;
using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;
using System.Transactions;
using RentMeFurnitureRentalSystem.Utils;
using System.Data;

namespace RentMeFurnitureRentalSystem.DAL;
/// <summary>
///  login DAL class
/// </summary>
public class LoginDal
{
    #region Methods
    /// <summary>
    /// Create login in the database
    /// </summary>
    /// <param name="login"></param>
    /// <param name="transaction"></param>
    /// <returns></returns>
    public static bool CreateLogin(Login login, MySqlConnection? transaction = null)
    {
        if (string.IsNullOrWhiteSpace(login.Username) || string.IsNullOrWhiteSpace(login.Password))
        {
            return false;
        }

        using var connection = transaction ?? new MySqlConnection(Connection.ConnectionString);
        if (transaction == null)
        {
            connection.Open();
        }

        try
        {
            
            connection.Execute(QueryStrings.CreateLogin, new { username = login.Username, password = PasswordHasher.HashPassword(login.Password) });
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    /// <summary>
    /// delete login in the database
    /// </summary>
    /// <param name="login"></param>
    /// <param name="transaction"></param>
    /// <returns></returns>
    public static bool DeleteLogin(Login login, MySqlConnection? transaction = null)
    {
        using var connection = transaction ?? new MySqlConnection(Connection.ConnectionString);

        if (transaction == null)
        {
            connection.Open();
        }

        var affected = connection.Execute(QueryStrings.DeleteLogin, login);

        return affected > 0;
    }
    /// <summary>
    /// check login in the database
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public static Login CheckLogin(string username)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var loginResult = connection.Query<Login>(QueryStrings.GetLoginByName, new { username });

        return loginResult.ElementAt(0);
    }
    /// <summary>
    /// change login in the database
    /// </summary>
    /// <param name="username"></param>
    /// <param name="id"></param>
    /// <param name="newPassword"></param>
    /// <returns></returns>
    public static bool ChangeLogin(string username, int id, string newPassword)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        try
        {
            var parameters = new
            {
                inputUsername = username,
                inputId = id,
                newPassword = newPassword
            };
            var result = connection.Execute(QueryStrings.ChangeLogin,parameters,commandType: CommandType.StoredProcedure);
            return result > 0;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }

    }
    #endregion
}