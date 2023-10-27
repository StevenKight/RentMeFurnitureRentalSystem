using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMeFurnitureRentalSystem.model
{
    public class Category
    {
        #region properties

        public string Name { get; set; }

        #endregion

        #region methods

        public override string ToString()
        {
            return this.Name;
        }

        #endregion
    }
}
