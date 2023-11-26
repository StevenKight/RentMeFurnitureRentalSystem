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
    public partial class DayToDayReportForm : Form
    {
        public DayToDayReportForm()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            var tableForm = new AdminToolSelectorForm();

            tableForm.StartPosition = FormStartPosition.Manual;
            tableForm.Left = Left + (Width - tableForm.Width) / 2;
            tableForm.Top = Top + (Height - tableForm.Height) / 2;
            tableForm.Show();
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.rentalsDataGridView.Columns.Clear();
            this.returnsDataGridView.Columns.Clear();

            var fromDate = this.fromDatePicker.Value;
            var toDate = this.toDatePicker.Value;

            var rentalResults = ReportDAL.GetRentalReport(fromDate, toDate);
            var returnResults = ReportDAL.GetReturnReport(fromDate, toDate);

            if (returnResults != null)
            {
                this.returnsDataGridView.DataSource = returnResults;
            }

            if (rentalResults != null)
            {
                this.rentalsDataGridView.DataSource = rentalResults;
            }

        }
    }
}
