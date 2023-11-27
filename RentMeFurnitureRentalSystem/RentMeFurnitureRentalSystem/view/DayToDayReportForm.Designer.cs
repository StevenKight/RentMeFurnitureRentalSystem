namespace RentMeFurnitureRentalSystem.View
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.label1 = new Label();
            this.fromDatePicker = new DateTimePicker();
            this.toDatePicker = new DateTimePicker();
            this.label2 = new Label();
            this.label3 = new Label();
            this.submitButton = new Button();
            this.clearButton = new Button();
            this.itemsDataGridView = new DataGridView();
            this.returnButton = new Button();
            this.reportTabControl = new TabControl();
            this.rentalTabPage = new TabPage();
            this.rentalsDataGridView = new DataGridView();
            this.returnsTabPage = new TabPage();
            this.returnsDataGridView = new DataGridView();
            this.selectedLabel = new Label();
            this.selectedRentalIdTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)this.itemsDataGridView).BeginInit();
            this.reportTabControl.SuspendLayout();
            this.rentalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.rentalsDataGridView).BeginInit();
            this.returnsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.returnsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            this.label1.Location = new Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(159, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new Point(197, 96);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new Size(200, 23);
            this.fromDatePicker.TabIndex = 1;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new Point(470, 98);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new Size(200, 23);
            this.toDatePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(153, 100);
            this.label2.Name = "label2";
            this.label2.Size = new Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(442, 100);
            this.label3.Name = "label3";
            this.label3.Size = new Size(22, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new Point(813, 96);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += this.submitButton_Click;
            // 
            // clearButton
            // 
            this.clearButton.Location = new Point(732, 96);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Location = new Point(508, 152);
            this.itemsDataGridView.MultiSelect = false;
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowTemplate.Height = 25;
            this.itemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.itemsDataGridView.Size = new Size(380, 252);
            this.itemsDataGridView.TabIndex = 8;
            // 
            // returnButton
            // 
            this.returnButton.Location = new Point(813, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new Size(75, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += this.returnButton_Click;
            // 
            // reportTabControl
            // 
            this.reportTabControl.Controls.Add(this.rentalTabPage);
            this.reportTabControl.Controls.Add(this.returnsTabPage);
            this.reportTabControl.Location = new Point(12, 128);
            this.reportTabControl.Name = "reportTabControl";
            this.reportTabControl.SelectedIndex = 0;
            this.reportTabControl.Size = new Size(490, 280);
            this.reportTabControl.TabIndex = 10;
            this.reportTabControl.SelectedIndexChanged += this.reportTabControl_SelectedIndexChanged;
            // 
            // rentalTabPage
            // 
            this.rentalTabPage.Controls.Add(this.rentalsDataGridView);
            this.rentalTabPage.Location = new Point(4, 24);
            this.rentalTabPage.Name = "rentalTabPage";
            this.rentalTabPage.Padding = new Padding(3);
            this.rentalTabPage.Size = new Size(482, 252);
            this.rentalTabPage.TabIndex = 0;
            this.rentalTabPage.Text = "Rentals";
            this.rentalTabPage.UseVisualStyleBackColor = true;
            // 
            // rentalsDataGridView
            // 
            this.rentalsDataGridView.AllowUserToAddRows = false;
            this.rentalsDataGridView.AllowUserToDeleteRows = false;
            this.rentalsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalsDataGridView.Location = new Point(0, 0);
            this.rentalsDataGridView.MultiSelect = false;
            this.rentalsDataGridView.Name = "rentalsDataGridView";
            this.rentalsDataGridView.ReadOnly = true;
            this.rentalsDataGridView.RowTemplate.Height = 25;
            this.rentalsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.rentalsDataGridView.Size = new Size(482, 252);
            this.rentalsDataGridView.TabIndex = 0;
            this.rentalsDataGridView.CellClick += this.rentalsDataGridView_CellClick;
            // 
            // returnsTabPage
            // 
            this.returnsTabPage.Controls.Add(this.returnsDataGridView);
            this.returnsTabPage.Location = new Point(4, 24);
            this.returnsTabPage.Name = "returnsTabPage";
            this.returnsTabPage.Padding = new Padding(3);
            this.returnsTabPage.Size = new Size(482, 252);
            this.returnsTabPage.TabIndex = 1;
            this.returnsTabPage.Text = "Returns";
            this.returnsTabPage.UseVisualStyleBackColor = true;
            // 
            // returnsDataGridView
            // 
            this.returnsDataGridView.AllowUserToAddRows = false;
            this.returnsDataGridView.AllowUserToDeleteRows = false;
            this.returnsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnsDataGridView.Location = new Point(0, 0);
            this.returnsDataGridView.MultiSelect = false;
            this.returnsDataGridView.Name = "returnsDataGridView";
            this.returnsDataGridView.ReadOnly = true;
            this.returnsDataGridView.RowTemplate.Height = 25;
            this.returnsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.returnsDataGridView.Size = new Size(482, 252);
            this.returnsDataGridView.TabIndex = 0;
            this.returnsDataGridView.CellClick += this.returnsDataGridView_CellClick;
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new Point(508, 131);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new Size(175, 15);
            this.selectedLabel.TabIndex = 11;
            this.selectedLabel.Text = "Please select a item on the left...";
            // 
            // selectedRentalIdTextbox
            // 
            this.selectedRentalIdTextbox.BackColor = SystemColors.Control;
            this.selectedRentalIdTextbox.BorderStyle = BorderStyle.None;
            this.selectedRentalIdTextbox.Location = new Point(570, 131);
            this.selectedRentalIdTextbox.Name = "selectedRentalIdTextbox";
            this.selectedRentalIdTextbox.Size = new Size(100, 16);
            this.selectedRentalIdTextbox.TabIndex = 12;
            // 
            // DayToDayReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(this.selectedLabel);
            Controls.Add(this.selectedRentalIdTextbox);
            Controls.Add(this.reportTabControl);
            Controls.Add(this.returnButton);
            Controls.Add(this.itemsDataGridView);
            Controls.Add(this.clearButton);
            Controls.Add(this.submitButton);
            Controls.Add(this.label3);
            Controls.Add(this.label2);
            Controls.Add(this.toDatePicker);
            Controls.Add(this.fromDatePicker);
            Controls.Add(this.label1);
            Name = "DayToDayReportForm";
            Text = "DayToDayReportForm";
            ((System.ComponentModel.ISupportInitialize)this.itemsDataGridView).EndInit();
            this.reportTabControl.ResumeLayout(false);
            this.rentalTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.rentalsDataGridView).EndInit();
            this.returnsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.returnsDataGridView).EndInit();
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