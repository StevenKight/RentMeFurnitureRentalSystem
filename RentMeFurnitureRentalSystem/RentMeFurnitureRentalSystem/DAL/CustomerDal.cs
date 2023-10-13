using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RentMeFurnitureRentalSystem.DAL
{
    public class CustomerDal
    {
        public static bool CreateCustomer(Customer newCustomer)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString);

            var query = "INSERT INTO `customer`(`fname`,`lname`,`dob`,`gender`,`email`,`phone`,`address`,`city`,`state`,`zip`)" +
                           "VALUES (@fname, @lname, @dob, @gender, @email, @phone, @address, @city, @state, @zip);";
            connection.Open();

            using var command = new MySqlCommand(query, connection);
            newCustomer.FillCommand(command);

            try
            {
                var affected = command.ExecuteNonQuery();

                return affected >= 1;
            }
            catch 
            {
                return false;
            }
        }
    }
}
