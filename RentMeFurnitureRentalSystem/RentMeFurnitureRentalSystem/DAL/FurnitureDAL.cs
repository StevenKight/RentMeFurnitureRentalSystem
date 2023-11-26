using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;
/// <summary>
/// FurnitureDAL is responsible for handling all database operations for the Furniture class
/// </summary>
public class FurnitureDAL
{
    #region Methods
    /// <summary>
    /// Get all furniture from the database
    /// </summary>
    /// <returns></returns>
    public static IList<Furniture> GetFurniture()
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurniture);
        return result.ToList();
    }
    /// <summary>
    /// Get all rentable furniture from the database
    /// </summary>
    /// <returns></returns>
    public static IList<Furniture> GetRentableFurniture()
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetRentableFurniture);
        return result.ToList();
    }
    /// <summary>
    /// get all furniture by id from the database
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static IList<Furniture> GetFurnitureById(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurnitureById, new { id });
        return result.ToList();
    }
    /// <summary>
    /// Get all furniture by category from the database
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    public static IList<Furniture> GetFurnitureByCategory(string category)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurnitureByCategory, new { category });
        return result.ToList();
    }
    /// <summary>
    /// Get all furniture by style from the database
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static IList<Furniture> GetFurnitureByStyle(string style)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurnitureByStyle, new { style });
        return result.ToList();
    }
    /// <summary>
    /// Get all rentable furniture by id from the database
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static IList<Furniture> GetRentableFurnitureById(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetRentableFurnitureById, new { id });
        return result.ToList();
    }
    /// <summary>
    /// get all rentable furniture by category from the database
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    public static IList<Furniture> GetRentableFurnitureByCategory(string category)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetRentableFurnitureByCategory, new { category });
        return result.ToList();
    }
    /// <summary>
    /// get rentable furniture by style from the database
    /// </summary>
    /// <param name="style"></param>
    /// <returns></returns>
    public static IList<Furniture> GetRentableFurnitureByStyle(string style)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var result = connection.Query<Furniture>(QueryStrings.GetRentableFurnitureByStyle, new { style });
        return result.ToList();
    }
    /// <summary>
    /// get all furniture by rental item from the database
    /// </summary>
    /// <param name="selectedRental"></param>
    /// <returns></returns>
    public static List<Furniture> GetFurnitureByRental(RentalItem selectedRental)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var result = connection.Query<Furniture>(QueryStrings.GetFurnitureByRental, new { Id = selectedRental.Rental_id, Member_id = selectedRental.Member_id });
        return result.ToList();
    }
    /// <summary>
    /// create furniture in the database
    /// </summary>
    /// <param name="furniture"></param>
    /// <returns></returns>
    public static bool CreateFurniture(Furniture furniture)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        try
        {
            var result = connection.Execute(QueryStrings.CreateFurniture, furniture);
            return result > 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    #endregion
}