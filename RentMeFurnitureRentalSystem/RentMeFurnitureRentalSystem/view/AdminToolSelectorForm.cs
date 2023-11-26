using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMeFurnitureRentalSystem.view
{
    public partial class AdminToolSelectorForm : Form
    {
        public AdminToolSelectorForm()
        {
            InitializeComponent();
        }

        private void adminSQLTableButton_Click(object sender, EventArgs e)
        {
            var tableForm = new AdminTableForm();
            tableForm.StartPosition = FormStartPosition.Manual;
            tableForm.Left = Left + (Width - tableForm.Width) / 2;
            tableForm.Top = Top + (Height - tableForm.Height) / 2;
            tableForm.ShowDialog();
            Close();
        }
    }
}
