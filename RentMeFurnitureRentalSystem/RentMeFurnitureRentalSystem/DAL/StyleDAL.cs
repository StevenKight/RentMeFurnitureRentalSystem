using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;
/// <summary>
/// StyleDAL is responsible for handling all database access for the Style class
/// </summary>
public class StyleDAL
{
    #region methods
    /// <summary>
    /// Get all styles from the database
    /// </summary>
    /// <returns></returns>
    public static IList<Style> GetStyles()
    {
        var styles = new List<Style>();

        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Style>(QueryStrings.GetStyles);

        foreach (var style in result) styles.Add(style);

        return styles;
    }

    #endregion
}