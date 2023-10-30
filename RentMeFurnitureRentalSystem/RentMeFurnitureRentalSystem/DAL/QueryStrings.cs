namespace RentMeFurnitureRentalSystem.DAL;

public static class QueryStrings
{

    #region Roles

    public const string GetRoles = "select * from role";

    #endregion

    #region Style

    public const string GetStyles = "select * from style";

    #endregion

    #region Category

    public const string GetCategories = "select * from category";

    #endregion

    #region Customer

    public const string GetCustomers = "select * from customer";

    public const string CreateCustomer =
        "INSERT INTO `customer`(`fname`,`lname`,`dob`,`gender`,`email`,`phone`,`address`,`city`,`state`,`zip`)" +
        "VALUES (@Fname, @Lname, @Dob, @Gender, @Email, @Phone, @Address, @City, @State, @Zip);";

    public const string DeleteCustomer = "DELETE FROM `customer` WHERE member_id=@Member_id;";

    public const string UpdateCustomer = "UPDATE `customer`" +
                                         "SET `fname` = @Fname," +
                                         "`lname` = @Lname," +
                                         "`dob` = @Dob," +
                                         "`gender` = @Gender," +
                                         "`email` = @Email," +
                                         "`phone` = @Phone," +
                                         "`address` = @Address," +
                                         "`city` = @City," +
                                         "`state` = @State," +
                                         "`zip` = @Zip " +
                                         "WHERE `member_id` = @Member_id;";

    public const string GetCustomerByMemberId = "select * from customer where member_id=@id";

    public const string GetCustomerByPhone = "select * from customer where phone=@phone";

    public const string GetCustomerByName = "select * from customer where fname=@fname and lname=@lname";
    #endregion

    #region Login

    public const string GetLoginByName = "select * from login where username=@Username";

    public const string CreateLogin = "insert into login(username,password) values(@Username,@Password)";

    public const string DeleteLogin = "DELETE FROM login WHERE username=@Username;";

    #endregion

    #region Employee

    public const string GetEmployees = "Select * from employee";

    public const string CreateEmployee =
        "insert into employee(username,fname,lname,gender,phone,email,dob,address,city,state,zip,role_name) " +
        "values(@Username,@Fname,@Lname,@Gender,@Phone,@Email,@Dob,@Address,@City,@State,@Zip,@Role_name)";

    public const string GetByEmployeeUsername = "select * from employee where username=@Username";

    public const string DeleteEmployee = "DELETE FROM employee WHERE employee_num=@Employee_num;";

    public const string UpdateEmployee = "UPDATE `employee`" +
                                         "SET `fname` = @Fname," +
                                         "`lname` = @Lname," +
                                         "`dob` = @Dob," +
                                         "`gender` = @Gender," +
                                         "`email` = @Email," +
                                         "`phone` = @Phone," +
                                         "`address` = @Address," +
                                         "`city` = @City," +
                                         "`state` = @State," +
                                         "`zip` = @Zip," +
                                         "`role_name` = @Role_name " +
                                         "WHERE `employee_num` = @Employee_num;";

    #endregion

    #region Furniture

    public const string GetFurniture = "select * from furniture";

    public const string GetFurnitureById = "select * from furniture where furniture_id=@id";

    public const string GetFurnitureByCategory = "select * from furniture where category_name=@category";

    public const string GetFurnitureByStyle = "select * from furniture where style_name=@style";

    public const string CreateFurniture =
        "insert into furniture(category_name,style_name,`name`,`description`,rental_rate,fine_rate,quantity) values(@Category,@Style,@Name,@Description,@Rental_rate,@Fine_rate,@Quantity)";

    #endregion
}