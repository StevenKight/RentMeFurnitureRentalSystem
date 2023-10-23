using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;

public class LoginDal
{
    #region Methods

    public static bool CreateLogin(Login login)
    {
        if (login.Username.Equals("") || login.Password.Equals(""))
        {
            return false;
        }

        using var connection = new MySqlConnection(Connection.ConnectionString);

        connection.Open();

        var query = "insert into login(username,password) values(@username,@password)";
        try
        {
            var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = login.Username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = login.Password;

            var rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                return true;
            }
        }
        catch (Exception)
        {
            return false;
        }

        return false;
    }

    public static Login CheckLogin(string username)
    {
        var login = new Login();
        using var connection = new MySqlConnection(Connection.ConnectionString);

        connection.Open();

        var query = "select * from login where username=@username";
        try
        {
            var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                login.Username = reader.GetString(0);
                login.Password = reader.GetString(1);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

        return login;
    }

    #endregion
}