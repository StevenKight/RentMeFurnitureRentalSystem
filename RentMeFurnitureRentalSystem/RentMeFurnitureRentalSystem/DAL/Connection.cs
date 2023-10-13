using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMeFurnitureRentalSystem.DAL
{
    public static class Connection
    {
        // TODO: Remove passwords from repo
        public static readonly string DepartmentConnectionString = "server=160.10.217.6; port=3306; " +
                                                         "uid=cs3230f23d; pwd=jpeRJUN6/<shO[JAnBk@; database=cs3230f23d;";

        public static readonly string LocalConnectionString = "server=localhost; port=3306; " +
                                                         "uid=root; pwd=8757; database=local-project;";

        public static readonly string ConnectionString = LocalConnectionString;

    }
}
