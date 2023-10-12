using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMeFurnitureRentalSystem.DAL
{
    public class RolesDal
    {
        public IList<string> GetRoles()
        {
            var roles = new List<string>();
            using var connection = new MySqlConnection(Connection.ConnectionString);

            connection.Open();

            var query = "select * from role";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var roleName = reader.GetString(0);
                        roles.Add(roleName);
                    }
                }
            }
            return roles;
        }
    }
}
