namespace RentMeFurnitureRentalSystem.View
{
    partial class AdminToolSelectorForm
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
            this.adminSQLTableButton = new Button();
            this.dateReportButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            this.label1.Location = new Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(241, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Tools";
            // 
            // adminSQLTableButton
            // 
            this.adminSQLTableButton.Location = new Point(110, 155);
            this.adminSQLTableButton.Name = "adminSQLTableButton";
            this.adminSQLTableButton.Size = new Size(118, 23);
            this.adminSQLTableButton.TabIndex = 1;
            this.adminSQLTableButton.Text = "Admin SQL Table";
            this.adminSQLTableButton.UseVisualStyleBackColor = true;
            this.adminSQLTableButton.Click += this.adminSQLTableButton_Click;
            // 
            // dateReportButton
            // 
            this.dateReportButton.Location = new Point(110, 210);
            this.dateReportButton.Name = "dateReportButton";
            this.dateReportButton.Size = new Size(118, 23);
            this.dateReportButton.TabIndex = 2;
            this.dateReportButton.Text = "View Report";
            this.dateReportButton.UseVisualStyleBackColor = true;
            this.dateReportButton.Click += this.dateReportButton_Click;
            // 
            // AdminToolSelectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 345);
            Controls.Add(this.dateReportButton);
            Controls.Add(this.adminSQLTableButton);
            Controls.Add(this.label1);
            Name = "AdminToolSelectorForm";
            Text = "AdminToolSelectorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button adminSQLTableButton;
        private Button dateReportButton;
    }
}