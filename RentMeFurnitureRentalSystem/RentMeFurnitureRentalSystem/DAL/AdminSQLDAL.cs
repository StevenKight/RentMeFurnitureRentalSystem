using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySqlX.XDevAPI.Common;

namespace RentMeFurnitureRentalSystem.DAL
{
    /// <summary>
    /// The DAL for the admin table page
    /// </summary>
    public class AdminSQLDAL
    {
        /// <summary>
        /// Executes a SQL statement that returns the results of the query
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


    }
}
