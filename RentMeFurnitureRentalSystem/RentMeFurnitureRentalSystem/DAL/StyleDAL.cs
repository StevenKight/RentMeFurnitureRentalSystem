using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL
{
    public class StyleDAL
    {
        #region methods

        public IList<Style> GetStyles()
        {
            var styles = new List<Style>();

            using var connection = new MySqlConnection(Connection.ConnectionString);

            var result = connection.Query<Style>(QueryStrings.GetStyles);

            foreach (Style style in result)
            {
                styles.Add(style);
            }

            return styles;
        }

        #endregion
    }
}
