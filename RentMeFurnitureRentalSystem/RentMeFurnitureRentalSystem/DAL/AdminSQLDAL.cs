using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace RentMeFurnitureRentalSystem.DAL;

/// <summary>
///     The DAL for the admin table page
/// </summary>
public class AdminSqldal
{
    #region Methods

    /// <summary>
    ///     Executes a SQL statement that returns the results of the query
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public static DataTable ReadStatement(string sql)
    {
        try
        {
            using var connection = new MySqlConnection(Connection.ConnectionString);
            connection.Open();

            var dataTable = new DataTable();
            using (var reader = connection.ExecuteReader(sql))
            {
                dataTable.Load(reader);
            }

            return dataTable;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error executing SQL: " + ex.Message);
            return null;
        }
    }

    #endregion
}