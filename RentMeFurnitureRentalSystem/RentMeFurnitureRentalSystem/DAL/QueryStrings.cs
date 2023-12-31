﻿namespace RentMeFurnitureRentalSystem.DAL;

/// <summary>
///     Query strings for all the queries used in the application
/// </summary>
public static class QueryStrings
{
    #region Data members

    #region Roles

    public const string GetRoles = "select * from role";

    #endregion

    #region Style

    public const string GetStyles = "select * from style";

    #endregion

    #region Category

    public const string GetCategories = "select * from category";

    #endregion

    #endregion

    #region Customer

    public const string GetCustomerById = "select * from customer where member_id=@Id";

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

    public const string ChangeLogin = "ChangePassword";

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

    public const string GetEmployeeByEmployeeNum = "select * from Employee where employee_num=@id";

    public const string GetEmployeeByPhone = "select * from Employee where phone=@phone";

    public const string GetEmployeeByName = "select * from Employee where fname=@fname and lname=@lname";

    #endregion

    #region Furniture

    public const string GetFurniture = "select * from furniture";

    public const string GetRentableFurniture = "select * from furniture where quantity > 0";

    public const string GetFurnitureById = "select * from furniture where furniture_id=@id";

    public const string GetFurnitureByCategory = "select * from furniture where category_name=@category";

    public const string GetFurnitureByRental = "CALL GetReturnableItems(@Rental_id, @Member_id)";

    public const string GetFurnitureByStyle = "select * from furniture where style_name=@style";

    public const string GetRentableFurnitureById = "select * from furniture where furniture_id=@id and quantity > 0";

    public const string GetRentableFurnitureByCategory =
        "select * from furniture where category_name=@category and quantity > 0";

    public const string GetRentableFurnitureByStyle =
        "select * from furniture where style_name=@style and quantity > 0";

    public const string CreateFurniture =
        "insert into furniture(category_name,style_name,`name`,`description`,rental_rate,fine_rate,quantity) values(@Category_name,@Style_name,@Name,@Description,@Rental_rate,@Fine_rate,@Quantity)";

    public const string DeleteFurniture = "DELETE FROM furniture WHERE furniture_id=@Furniture_id";

    public const string UpdateFurniture = "UPDATE furniture " +
                                          "SET `category_name` = @Category_name, " +
                                          "`style_name` = @Style_name, " +
                                          "`name` = @Name, " +
                                          "`description` = @Description, " +
                                          "`rental_rate` = @Rental_rate, " +
                                          "`fine_rate` = @Fine_rate, " +
                                          "`quantity` = @Quantity " +
                                          "WHERE `furniture_id` = @Furniture_id";

    #endregion

    #region Rental

    public const string GetRentalById = "select * from `rental` where rental_id=@Id";

    public const string GetReturnById = "select * from `return` where return_id=@Id";

    public const string GetRentalItems = "select furniture.furniture_id, furniture.category_name, furniture.style_name, furniture.`name`, " +
                                         "furniture.`description`, furniture.rental_rate, rental_item.rental_id, rental_item.quantity " +
                                         "from `rental_item`,`furniture` " +
                                         "where `rental_item`.furniture_id=`furniture`.furniture_id " +
                                         "AND `rental_item`.rental_id=@Id";

    public const string GetRentalTotal = "SELECT SUM(`furniture`.rental_rate * `rental_item`.quantity) " +
                                         "FROM `rental_item`, `furniture` " +
                                         "WHERE `rental_item`.furniture_id=`furniture`.furniture_id " +
                                         "AND `rental_item`.rental_id = @Id " +
                                         "GROUP BY `rental_item`.rental_id";

    public const string GetRentalByMember = "select * from `rental` where member_id=@Member_id";

    public const string GetReturnItems = "select furniture.furniture_id, furniture.category_name, furniture.style_name, furniture.`name`, " +
                                         "furniture.`description`, furniture.rental_rate, return_item.return_id, return_item.quantity " +
                                         "from `return_item`,`furniture` " +
                                         "where `return_item`.furniture_id=`furniture`.furniture_id " +
                                         "AND `return_item`.return_id=@Id";

    public const string GetReturnFineTotal =
        "SELECT SUM(`furniture`.rental_rate * `return_item`.quantity) AS fine_total " +
        "FROM `return_item`, `furniture`, `rental` " +
        "WHERE `return_item`.furniture_id=`furniture`.furniture_id " +
        "AND `return_item`.rental_id=`rental`.rental_id " +
        "AND `return_item`.return_id = @Id " +
        "AND `rental`.due_date < NOW() " +
        "GROUP BY `return_item`.return_id";

    #endregion

    #region Report

    public const string GetReturnReport =
        "SELECT * FROM `return` WHERE `return`.return_date BETWEEN @fromDate AND @toDate";

    public const string GetRentalReport = "SELECT * FROM rental WHERE start_date BETWEEN @fromDate AND @toDate";

    public const string GetRentalReportBySelected = @"
   SELECT 
        rental_item.furniture_id, rental_item.quantity, furniture.`name`
    FROM
        rental
            INNER JOIN
        rental_item ON rental.rental_id = rental_item.rental_id
            INNER JOIN
        furniture ON furniture.furniture_id = rental_item.furniture_id
    WHERE
        rental.rental_id = @rentalId";

    public const string GetReturnReportBySelected =
        "select `return_item`.furniture_id, `return_item`.quantity, furniture.`name` from `return` inner join `return_item` on `return`.return_id = `return_item`.return_id inner join furniture ON furniture.furniture_id = `return_item`.furniture_id where `return`.return_id=@returnID";

    #endregion
}