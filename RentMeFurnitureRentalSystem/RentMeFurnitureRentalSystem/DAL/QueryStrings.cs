namespace RentMeFurnitureRentalSystem.DAL;

public static class QueryStrings
{
    #region Roles

    public const string GetRoles = "select * from role";

    #endregion

    #region Customer

    public const string GetCustomers = "select * from customer";

    public const string CreateCustomer = "INSERT INTO `customer`(`fname`,`lname`,`dob`,`gender`,`email`,`phone`,`address`,`city`,`state`,`zip`)" +
                                         "VALUES (@fname, @lname, @dob, @gender, @email, @phone, @address, @city, @state, @zip);";
    #endregion

    #region Login

    public const string GetLoginByName = "select * from login where username=@username";

    public const string CreateLogin = "insert into login(username,password) values(@username,@password)";

    #endregion

    #region Employee

    public const string GetEmployees = "Select * from employee";

    public const string CreateEmployee =
        "insert into employee(username,fname,lname,gender,phone,email,dob,address,city,state,zip,role_name) values(@Username,@Fname,@Lname,@Gender,@Phone,@Email,@Dob,@Address,@City,@State,@Zip,@Role_name)";

    public const string GetByEmployeeUsername = "select * from employee where username=@username";

    #endregion

    #region Furniture

    public const string GetFurniture = "select * from furniture";

    #endregion
}