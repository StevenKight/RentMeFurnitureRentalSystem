using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMeFurnitureRentalSystem.DAL;

namespace RentMeFurnitureRentalSystem.view
{
    public partial class addFurnitureForm : Form
    {
        public addFurnitureForm()
        {
            InitializeComponent();
            this.populateStyleComboBox();
        }

        private void populateStyleComboBox()
        {
            this.styleComboBox.Items.Clear();
            var styleDal = new StyleDAL();
            var styleList = styleDal.GetStyles();
            this.styleComboBox.DataSource = styleList;
        }
    }
}
