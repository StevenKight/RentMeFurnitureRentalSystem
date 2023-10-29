using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.DAL;

public class CustomerDal
{
    #region Methods

    public static List<Customer> GetAllCustomers()
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Customer>(QueryStrings.GetCustomers);


        return results.ToList();
    }

    public static IList<Customer> GetCustomerByMemberID(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Customer>(QueryStrings.GetCustomerByMemberId,new {id = id});

        return results.ToList();
    }

    public static IList<Customer> GetCustomerByPhone(string phone)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Customer>(QueryStrings.GetCustomerByPhone, new { phone = phone });

        return results.ToList();
    }

    public static IList<Customer> GetCustomerByName(string firstName, string lastName)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Customer>(QueryStrings.GetCustomerByName, new { fname = firstName, lname = lastName });

        return results.ToList();
    }
    public static bool CreateCustomer(Customer newCustomer)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        try
        {
            connection.Execute(QueryStrings.CreateCustomer, new
            {
                fname = newCustomer.Fname,
                lname = newCustomer.Lname,
                gender = newCustomer.Gender,
                email = newCustomer.Email,
                phone = newCustomer.Phone,
                dob = newCustomer.Dob,
                address = newCustomer.Address,
                city = newCustomer.City,
                state = newCustomer.State,
                zip = newCustomer.Zip
            });
            return true;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
            return false;
        }
    }
    
    #endregion
}