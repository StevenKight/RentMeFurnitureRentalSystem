using RentMeFurnitureRentalSystem.DAL;

namespace RentMeFurnitureRentalSystem.view
{

    public partial class DayToDayReportForm : Form
    {
        #region Properties
        
        public DataGridViewCell SelectedCell { get; set; }
        #endregion
        public DayToDayReportForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method returns the user to the admin tool selector form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnButton_Click(object sender, EventArgs e)
        {
            var tableForm = new AdminToolSelectorForm();
            tableForm.Show();
            Close();

        }
        /// <summary>
        /// This method submits the report and displays the results in the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                int amountOfColumns = this.returnsDataGridView.ColumnCount - 1;
                this.returnsDataGridView.Columns[amountOfColumns].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.returnsDataGridView.RowHeadersVisible = false;

            }

            if (rentalResults != null)
            {
                this.rentalsDataGridView.DataSource = rentalResults;
                int amountOfColumns = this.rentalsDataGridView.ColumnCount - 1;
                this.rentalsDataGridView.Columns[amountOfColumns].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.rentalsDataGridView.RowHeadersVisible = false;
            }

        }
        /// <summary>
        /// displays the rental items in the data grid view when the user double clicks on a row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rentalsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rental_id = this.rentalsDataGridView.Rows[e.RowIndex].Cells["Rental_id"].Value;
            var rentalItems = ReportDAL.GetRentalReportBySelectedRow((int)rental_id);
            this.itemsDataGridView.DataSource = rentalItems;

            int amountOfColumns = this.itemsDataGridView.ColumnCount - 1;
            this.itemsDataGridView.Columns[amountOfColumns].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.itemsDataGridView.RowHeadersVisible = false;

            this.selectedRentalIdTextbox.Clear();
            this.selectedRentalIdTextbox.Text = rental_id.ToString();

            this.selectedLabel.Text = "Rental Id:";

        }
        /// <summary>
        /// sets the selected cell to the cell that the user clicks on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rentalsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectedCell = this.rentalsDataGridView.CurrentCell;

        }
        /// <summary>
        ///  sets the selected cell to the cell that the user clicks on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectedCell = this.returnsDataGridView.CurrentCell;
        }
        /// <summary>
        /// displays the return items in the data grid view when the user double clicks on a row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var return_id = this.returnsDataGridView.Rows[e.RowIndex].Cells["Return_id"].Value;
            var rentalItems = ReportDAL.GetReturnReportBySelectedRow((int)return_id);
            this.itemsDataGridView.DataSource = rentalItems;

            int amountOfColumns = this.itemsDataGridView.ColumnCount - 1;
            this.itemsDataGridView.Columns[amountOfColumns].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.itemsDataGridView.RowHeadersVisible = false;

            this.selectedRentalIdTextbox.Clear();
            this.selectedRentalIdTextbox.Text = return_id.ToString();

            this.selectedLabel.Text = "Return Id:";
        }
    }
}
