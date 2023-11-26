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
    /// <summary>
    /// The DAL for the report
    /// </summary>
    public class ReportDAL
    {
        /// <summary>
        /// Get the report for the return
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Get the report for the rentals
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Get rental report by selected row
        /// </summary>
        /// <param name="rentalId"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Get return report by selected row
        /// </summary>
        /// <param name="returnId"></param>
        /// <returns></returns>
        public static DataTable GetReturnReportBySelectedRow(int returnId)
        {
            try
            {
                using var connection = new MySqlConnection(Connection.ConnectionString);
                var dataTable = new DataTable();
                using (var reader = connection.ExecuteReader(QueryStrings.GetReturnReportBySelected,
                           new { returnId = returnId }))
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
