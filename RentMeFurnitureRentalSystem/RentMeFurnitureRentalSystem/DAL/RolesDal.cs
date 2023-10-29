using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.DAL;

public class RolesDal
{
    #region Methods

    public static IList<string> GetRoles()
    {
        var roles = new List<string>();

        using var connection = new MySqlConnection(Connection.ConnectionString);
        var roleResult = connection.Query<Role>(QueryStrings.GetRoles);

        foreach (var role in roleResult)
        {
            roles.Add(role.Name);
        }

        return roles;
    }

    #endregion
}