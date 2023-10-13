using MySql.Data.MySqlClient;

namespace RentMeFurnitureRentalSystem.DAL;

public class RolesDal
{
    #region Methods

    public static IList<string> GetRoles()
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

    #endregion
}