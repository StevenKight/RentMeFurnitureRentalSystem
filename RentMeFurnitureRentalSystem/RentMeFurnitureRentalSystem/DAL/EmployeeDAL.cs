using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;

// FIXME: Document all methods and code
public class EmployeeDal
{
    #region Methods

    public static List<Employee> GetAllEmployees()
    {
        var employees = new List<Employee>();

        using var connection = new MySqlConnection(Connection.ConnectionString);

        // FIXME: Use a separate constants file for queries
        var query = "SELECT * FROM employee";
        connection.Open();

        using var adapter = new MySqlDataAdapter(query, connection);

        using var command = new MySqlCommand(query, connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var employee = SelectCommand(reader);
            employees.Add(employee);
        }

        return employees;
    }

    public static bool CreateEmployee(Employee employee)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        connection.Open();

        var query =
            "insert into employee(username,fname,lname,gender,phone,email,dob,address,city,state,zip,role_name) values(@username,@firstname,@lastname,@gender,@phone,@email,@dob,@address,@city,@state,@zipcode,@role_name)";
        var command = new MySqlCommand(query, connection);

        FillCommand(command, employee);

        try
        {
            var rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static Employee GetEmployeeFromUsername(string username)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        var employee = new Employee();
        connection.Open();

        var query =
            "Select * from employee where username=@username";

        try
        {
            var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                employee = SelectCommand(reader);
            }
        }
        catch (Exception e)
        {
            // FIXME: Remove console output in DAL and Model (pass exceptions to UI for catching)
            Console.WriteLine("Error: " + e.Message);
        }

        return employee;
    }

    public static void FillCommand(MySqlCommand query, Employee employee)
    {
        query.Parameters.Add("@username", MySqlDbType.VarChar).Value = employee.Username;
        query.Parameters.Add("@password", MySqlDbType.VarChar).Value = employee.Password;
        query.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = employee.Firstname;
        query.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = employee.Lastname;
        query.Parameters.Add("@gender", MySqlDbType.VarChar).Value = employee.Gender;
        query.Parameters.Add("@phone", MySqlDbType.VarChar).Value = employee.Phone;
        query.Parameters.Add("@email", MySqlDbType.VarChar).Value = employee.Email;
        query.Parameters.Add("@dob", MySqlDbType.VarChar).Value = employee.Dob.ToString("yyyy-MM-dd");
        query.Parameters.Add("@address", MySqlDbType.VarChar).Value = employee.Address;
        query.Parameters.Add("@city", MySqlDbType.VarChar).Value = employee.City;
        query.Parameters.Add("@state", MySqlDbType.VarChar).Value = employee.State;
        query.Parameters.Add("@zipcode", MySqlDbType.VarChar).Value = employee.Zipcode;
        query.Parameters.Add("@role_name", MySqlDbType.VarChar).Value = employee.Role;
    }

    public static Employee SelectCommand(MySqlDataReader reader)
    {
        var employee = new Employee();

        var idOrdinal = reader.GetOrdinal("employee_num");
        var usernameOrdinal = reader.GetOrdinal("username");
        var nameOrdinal = reader.GetOrdinal("fname");
        var lnameOrdinal = reader.GetOrdinal("lname");
        var genderOrdinal = reader.GetOrdinal("gender");
        var emailOrdinal = reader.GetOrdinal("email");
        var phoneOrdinal = reader.GetOrdinal("phone");
        var dobOrdinal = reader.GetOrdinal("dob");
        var addressOrdinal = reader.GetOrdinal("address");
        var cityOrdinal = reader.GetOrdinal("city");
        var stateOrdinal = reader.GetOrdinal("state");
        var zipOrdinal = reader.GetOrdinal("zip");
        var roleOrdinal = reader.GetOrdinal("role_name");

        employee.EmployeeNum = reader.GetInt16(idOrdinal);
        employee.Username = reader.GetString(usernameOrdinal);
        employee.Firstname = reader.GetString(nameOrdinal);
        employee.Lastname = reader.GetString(lnameOrdinal);
        employee.Gender = reader.GetString(genderOrdinal);
        employee.Email = reader.GetString(emailOrdinal);
        employee.Phone = reader.GetString(phoneOrdinal);
        employee.Address = reader.GetString(addressOrdinal);
        employee.City = reader.GetString(cityOrdinal);
        employee.State = reader.GetString(stateOrdinal);
        employee.Zipcode = reader.GetString(zipOrdinal);
        employee.Role = reader.GetString(roleOrdinal);
        employee.Dob = reader.GetDateTime(dobOrdinal);

        var login = LoginDal.CheckLogin(employee.Username);
        employee.Password = login.Password;

        return employee;
    }

    #endregion
}