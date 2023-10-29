﻿namespace RentMeFurnitureRentalSystem.DAL;

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

    public const string GetFurnitureById = "select * from furniture where furniture_id=@id";

    public const string GetFurnitureByCategory = "select * from furniture where category_name=@category";

    public const string GetFurnitureByStyle = "select * from furniture where style_name=@style";

    public const string CreateFurniture =
        "insert into furniture(category_name,style_name,`name`,`description`,rental_rate,fine_rate,quantity) values(@Category,@Style,@Name,@Description,@Rental_rate,@Fine_rate,@Quantity)";

    #endregion
}