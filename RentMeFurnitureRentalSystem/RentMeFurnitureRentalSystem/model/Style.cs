using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentMeFurnitureRentalSystem.model
{
    public class Style
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
