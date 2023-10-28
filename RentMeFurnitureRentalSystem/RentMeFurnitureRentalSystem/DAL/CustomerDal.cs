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


        using var command = new MySqlCommand(query, connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var customer = new Customer();
            customer.SelectCommand(reader);
            customerList.Add(customer);
        }

        return customerList;
        return customerList;
        return customerList;
        return customerList;
        return customerList;
        return customerList;
        return customerList;
        return customerList;
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
                zip = newCustomer.Zip,
                
            });
            return true;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
            return false;
        }
    }

    public static void FillCommand(MySqlCommand query, Customer customer)
    {
        query.Parameters.Add("@fname", MySqlDbType.VarChar).Value = customer.Firstname;
        query.Parameters.Add("@lname", MySqlDbType.VarChar).Value = customer.Lastname;
        query.Parameters.Add("@dob", MySqlDbType.DateTime).Value = customer.Birthday;
        query.Parameters.Add("@gender", MySqlDbType.VarChar).Value = customer.Gender;
        query.Parameters.Add("@email", MySqlDbType.VarChar).Value = customer.Email;
        query.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customer.Phone;
        query.Parameters.Add("@address", MySqlDbType.VarChar).Value = customer.StreetAddress;
        query.Parameters.Add("@city", MySqlDbType.VarChar).Value = customer.City;
        query.Parameters.Add("@state", MySqlDbType.VarChar).Value = customer.State;
        query.Parameters.Add("@zip", MySqlDbType.VarChar).Value = customer.Zipcode;
    }

    public static Customer SelectCommand(MySqlDataReader reader)
    {
        var customer = new Customer();

        var nameOrdinal = reader.GetOrdinal("fname");
        var lnameOrdinal = reader.GetOrdinal("lname");
        var dobOrdinal = reader.GetOrdinal("dob");
        var genderOrdinal = reader.GetOrdinal("gender");
        var emailOrdinal = reader.GetOrdinal("email");
        var phoneOrdinal = reader.GetOrdinal("phone");
        var addressOrdinal = reader.GetOrdinal("address");
        var cityOrdinal = reader.GetOrdinal("city");
        var stateOrdinal = reader.GetOrdinal("state");
        var zipOrdinal = reader.GetOrdinal("zip");
        var registerDateOrdinal = reader.GetOrdinal("register_date");

        customer.Firstname = reader.GetString(nameOrdinal);
        customer.Lastname = reader.GetString(lnameOrdinal);
        customer.Birthday = reader.GetDateTime(dobOrdinal);
        customer.Gender = reader.GetString(genderOrdinal);
        customer.Email = reader.GetString(emailOrdinal);
        customer.Phone = reader.GetString(phoneOrdinal);
        customer.StreetAddress = reader.GetString(addressOrdinal);
        customer.City = reader.GetString(cityOrdinal);
        customer.State = reader.GetString(stateOrdinal);
        customer.Zipcode = reader.GetString(zipOrdinal);
        customer.RegistrationDate = reader.GetDateTime(registerDateOrdinal);

        return customer;
    }

    #endregion
}