using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;

public class FurnitureDAL
{
    public static IList<Furniture> GetFurniture()
    {
        var furnitureList = new List<Furniture>();

        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurniture);

        foreach (var furniture in result) furnitureList.Add(furniture);
        return furnitureList;
    }

    public static IList<Furniture> GetFurnitureById(int id)
    {
        var list = new List<Furniture>();

        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurnitureById,new {id = id});

        foreach (var furniture in result)
        {
            list.Add(furniture);
        }
        return list;
    }

    public static IList<Furniture> GetFurnitureByCategory(string category)
    {
        var list = new List<Furniture>();

        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurnitureByCategory, new { category });
        foreach (var furniture in result)
        {
            list.Add(furniture);
        }
        return list;
    }
    public static bool CreateFurniture(Furniture furniture)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        try
        {
            var result = connection.Execute(QueryStrings.CreateFurniture, new
            {
                Category = furniture.Category_name,
                Style = furniture.Style_name,
                furniture.Name,
                furniture.Description,
                rental_rate = furniture.Rental_rate,
                furniture.Fine_rate,
                furniture.Quantity
            });
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }
}