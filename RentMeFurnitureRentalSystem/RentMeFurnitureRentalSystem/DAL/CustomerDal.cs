using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.DAL;

public class CustomerDal
{
    #region Methods

    public static List<Customer> GetAllCustomers()
    {
        var customerList = new List<Customer>();

        using var connection = new MySqlConnection(Connection.ConnectionString);

        var query = "SELECT * FROM customer";
        connection.Open();

        using var adapter = new MySqlDataAdapter(query, connection);

        using var command = new MySqlCommand(query, connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var customer = new Customer();
            customer.SelectCommand(reader);
            customerList.Add(customer);
        }

        return customerList;
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