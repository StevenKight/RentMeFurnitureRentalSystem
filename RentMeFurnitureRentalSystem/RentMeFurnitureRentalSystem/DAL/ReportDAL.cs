using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace RentMeFurnitureRentalSystem.DAL
{
    public class ReportDAL
    {
        public static DataTable GetReturnReport(DateTime from, DateTime to)
        {
            try
            {
                using var connection = new MySqlConnection(Connection.ConnectionString);
              
                var dataTable = new DataTable();
                using (var reader = connection.ExecuteReader(QueryStrings.GetReturnReport,
                           new { fromDate = from.ToString("yyyy-MM-dd"), toDate = to.ToString("yyyy-MM-dd") }))
                {
                    dataTable.Load(reader);
                }
                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public static DataTable GetRentalReport(DateTime from, DateTime to)
        {
            try
            {
                using var connection = new MySqlConnection(Connection.ConnectionString);
                var dataTable = new DataTable();
                using (var reader = connection.ExecuteReader(QueryStrings.GetRentalReport,
                           new { fromDate = from.ToString("yyyy-MM-dd"), toDate = to.ToString("yyyy-MM-dd") }))
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public static DataTable GetRentalReportBySelectedRow(int rentalId)
        {
            try
            {
                using var connection = new MySqlConnection(Connection.ConnectionString);
                var dataTable = new DataTable();
                using (var reader = connection.ExecuteReader(QueryStrings.GetRentalReportBySelected,
                           new { rentalId = rentalId }))
                {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
    }
}
