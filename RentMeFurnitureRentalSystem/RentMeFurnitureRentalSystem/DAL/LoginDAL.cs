using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;

public class LoginDal
{
    #region Methods

    public static bool CreateLogin(Login login)
    {
        if (string.IsNullOrWhiteSpace(login.Username) || string.IsNullOrWhiteSpace(login.Password))
        {
            return false;
        }

        using var connection = new MySqlConnection(Connection.ConnectionString);
        try
        {
           
            connection.Execute(QueryStrings.CreateLogin, new { username = login.Username, password = login.Password });
            return true; 
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static Login CheckLogin(string username)
    {
        
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var loginResult = connection.Query<Login>(QueryStrings.GetLoginByName, new { username });
        

        return loginResult.ElementAt(0);
    }

    #endregion
}