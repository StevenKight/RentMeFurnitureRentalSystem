namespace RentMeFurnitureRentalSystem.view
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
            adminSQLTableButton = new Button();
            dateReportButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 54);
            label1.TabIndex = 0;
            label1.Text = "Admin Tools";
            // 
            // adminSQLTableButton
            // 
            adminSQLTableButton.Location = new Point(110, 155);
            adminSQLTableButton.Name = "adminSQLTableButton";
            adminSQLTableButton.Size = new Size(118, 23);
            adminSQLTableButton.TabIndex = 1;
            adminSQLTableButton.Text = "Admin SQL Table";
            adminSQLTableButton.UseVisualStyleBackColor = true;
            adminSQLTableButton.Click += adminSQLTableButton_Click;
            // 
            // dateReportButton
            // 
            dateReportButton.Location = new Point(110, 210);
            dateReportButton.Name = "dateReportButton";
            dateReportButton.Size = new Size(118, 23);
            dateReportButton.TabIndex = 2;
            dateReportButton.Text = "View Report";
            dateReportButton.UseVisualStyleBackColor = true;
            dateReportButton.Click += dateReportButton_Click;
            // 
            // AdminToolSelectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 345);
            Controls.Add(dateReportButton);
            Controls.Add(adminSQLTableButton);
            Controls.Add(label1);
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