namespace RentMeFurnitureRentalSystem.view
{
    partial class DayToDayReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            fromDatePicker = new DateTimePicker();
            toDatePicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            submitButton = new Button();
            clearButton = new Button();
            itemsDataGridView = new DataGridView();
            returnButton = new Button();
            reportTabControl = new TabControl();
            rentalTabPage = new TabPage();
            rentalsDataGridView = new DataGridView();
            returnsTabPage = new TabPage();
            returnsDataGridView = new DataGridView();
            selectedLabel = new Label();
            selectedRentalIdTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).BeginInit();
            reportTabControl.SuspendLayout();
            rentalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rentalsDataGridView).BeginInit();
            returnsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(405, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 54);
            label1.TabIndex = 0;
            label1.Text = "Reports";
            // 
            // fromDatePicker
            // 
            fromDatePicker.Location = new Point(197, 96);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(200, 23);
            fromDatePicker.TabIndex = 1;
            // 
            // toDatePicker
            // 
            toDatePicker.Location = new Point(470, 98);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(200, 23);
            toDatePicker.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 100);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 100);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 4;
            label3.Text = "To:";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(813, 96);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(732, 96);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // itemsDataGridView
            // 
            itemsDataGridView.AllowUserToAddRows = false;
            itemsDataGridView.AllowUserToDeleteRows = false;
            itemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsDataGridView.Location = new Point(508, 152);
            itemsDataGridView.MultiSelect = false;
            itemsDataGridView.Name = "itemsDataGridView";
            itemsDataGridView.ReadOnly = true;
            itemsDataGridView.RowTemplate.Height = 25;
            itemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemsDataGridView.Size = new Size(380, 252);
            itemsDataGridView.TabIndex = 8;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(813, 12);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(75, 23);
            returnButton.TabIndex = 9;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // reportTabControl
            // 
            reportTabControl.Controls.Add(rentalTabPage);
            reportTabControl.Controls.Add(returnsTabPage);
            reportTabControl.Location = new Point(12, 128);
            reportTabControl.Name = "reportTabControl";
            reportTabControl.SelectedIndex = 0;
            reportTabControl.Size = new Size(490, 280);
            reportTabControl.TabIndex = 10;
            reportTabControl.SelectedIndexChanged += reportTabControl_SelectedIndexChanged;
            // 
            // rentalTabPage
            // 
            rentalTabPage.Controls.Add(rentalsDataGridView);
            rentalTabPage.Location = new Point(4, 24);
            rentalTabPage.Name = "rentalTabPage";
            rentalTabPage.Padding = new Padding(3);
            rentalTabPage.Size = new Size(482, 252);
            rentalTabPage.TabIndex = 0;
            rentalTabPage.Text = "Rentals";
            rentalTabPage.UseVisualStyleBackColor = true;
            // 
            // rentalsDataGridView
            // 
            rentalsDataGridView.AllowUserToAddRows = false;
            rentalsDataGridView.AllowUserToDeleteRows = false;
            rentalsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentalsDataGridView.Location = new Point(0, 0);
            rentalsDataGridView.MultiSelect = false;
            rentalsDataGridView.Name = "rentalsDataGridView";
            rentalsDataGridView.ReadOnly = true;
            rentalsDataGridView.RowTemplate.Height = 25;
            rentalsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rentalsDataGridView.Size = new Size(482, 252);
            rentalsDataGridView.TabIndex = 0;
            rentalsDataGridView.CellClick += rentalsDataGridView_CellClick;
            // 
            // returnsTabPage
            // 
            returnsTabPage.Controls.Add(returnsDataGridView);
            returnsTabPage.Location = new Point(4, 24);
            returnsTabPage.Name = "returnsTabPage";
            returnsTabPage.Padding = new Padding(3);
            returnsTabPage.Size = new Size(482, 252);
            returnsTabPage.TabIndex = 1;
            returnsTabPage.Text = "Returns";
            returnsTabPage.UseVisualStyleBackColor = true;
            // 
            // returnsDataGridView
            // 
            returnsDataGridView.AllowUserToAddRows = false;
            returnsDataGridView.AllowUserToDeleteRows = false;
            returnsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returnsDataGridView.Location = new Point(0, 0);
            returnsDataGridView.MultiSelect = false;
            returnsDataGridView.Name = "returnsDataGridView";
            returnsDataGridView.ReadOnly = true;
            returnsDataGridView.RowTemplate.Height = 25;
            returnsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            returnsDataGridView.Size = new Size(482, 252);
            returnsDataGridView.TabIndex = 0;
            returnsDataGridView.CellClick += returnsDataGridView_CellClick;
            // 
            // selectedLabel
            // 
            selectedLabel.AutoSize = true;
            selectedLabel.Location = new Point(508, 131);
            selectedLabel.Name = "selectedLabel";
            selectedLabel.Size = new Size(175, 15);
            selectedLabel.TabIndex = 11;
            selectedLabel.Text = "Please select a item on the left...";
            // 
            // selectedRentalIdTextbox
            // 
            selectedRentalIdTextbox.BackColor = SystemColors.Control;
            selectedRentalIdTextbox.BorderStyle = BorderStyle.None;
            selectedRentalIdTextbox.Location = new Point(570, 131);
            selectedRentalIdTextbox.Name = "selectedRentalIdTextbox";
            selectedRentalIdTextbox.Size = new Size(100, 16);
            selectedRentalIdTextbox.TabIndex = 12;
            // 
            // DayToDayReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(selectedLabel);
            Controls.Add(selectedRentalIdTextbox);
            Controls.Add(reportTabControl);
            Controls.Add(returnButton);
            Controls.Add(itemsDataGridView);
            Controls.Add(clearButton);
            Controls.Add(submitButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(toDatePicker);
            Controls.Add(fromDatePicker);
            Controls.Add(label1);
            Name = "DayToDayReportForm";
            Text = "DayToDayReportForm";
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).EndInit();
            reportTabControl.ResumeLayout(false);
            rentalTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rentalsDataGridView).EndInit();
            returnsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)returnsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker fromDatePicker;
        private DateTimePicker toDatePicker;
        private Label label2;
        private Label label3;
        private Button submitButton;
        private Button clearButton;
        private DataGridView itemsDataGridView;
        private Button returnButton;
        private TabControl reportTabControl;
        private TabPage rentalTabPage;
        private TabPage returnsTabPage;
        private DataGridView rentalsDataGridView;
        private DataGridView returnsDataGridView;
        private Label selectedLabel;
        private TextBox selectedRentalIdTextbox;
    }
}