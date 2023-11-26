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
using String = System.String;

namespace RentMeFurnitureRentalSystem.view
{
    public partial class AdminTableForm : Form
    {
        public AdminTableForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var sql = this.sqlTextArea.Text;

            if (String.IsNullOrEmpty(sql))
            {
                MessageBox.Show("Please enter Text");
                return;
            }

            var result = AdminSQLDAL.ReadStatement(sql);

            if (result != null)
            {
                this.resultDataView.DataSource = result;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.sqlTextArea.Clear();
        }

        private void returnScreenButton_Click(object sender, EventArgs e)
        {
            var tableForm = new AdminToolSelectorForm();


            
            tableForm.StartPosition = FormStartPosition.Manual;
            tableForm.Left = Left + (Width - tableForm.Width) / 2;
            tableForm.Top = Top + (Height - tableForm.Height) / 2;
            tableForm.Show();
            Close();


        }
    }
}
