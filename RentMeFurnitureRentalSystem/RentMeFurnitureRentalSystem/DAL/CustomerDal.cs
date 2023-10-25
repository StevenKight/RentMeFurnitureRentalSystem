using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.DAL;

public class CustomerDal
{
    #region Methods

    public static List<Customer> GetAllCustomers()
    {
        var customers = new List<Customer>();

        using var connection = new MySqlConnection(Connection.ConnectionString);

        

        return customers;
    }

    public static bool CreateCustomer(Customer newCustomer)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var query =
            "INSERT INTO `customer`(`fname`,`lname`,`dob`,`gender`,`email`,`phone`,`address`,`city`,`state`,`zip`)" +
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

    #endregion
}