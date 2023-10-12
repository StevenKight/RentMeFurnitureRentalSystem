using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL
{
    public class LoginDAL
    {
        public bool CreateLogin(Login login)
        {
            if(login.Username.Equals("") || login.Password.Equals(""))
            {
                return false;
            }
            using var connection = new MySqlConnection(Connection.ConnectionString);

            connection.Open();

            var query = "insert into login(username,password) values(@username,@password)";

            var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = login.Username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = login.Password;

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

       
            
        
    }
}
