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
            this.label1 = new System.Windows.Forms.Label();
            this.adminSQLTableButton = new System.Windows.Forms.Button();
            this.dateReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Tools";
            // 
            // adminSQLTableButton
            // 
            this.adminSQLTableButton.Location = new System.Drawing.Point(110, 155);
            this.adminSQLTableButton.Name = "adminSQLTableButton";
            this.adminSQLTableButton.Size = new System.Drawing.Size(118, 23);
            this.adminSQLTableButton.TabIndex = 1;
            this.adminSQLTableButton.Text = "Admin SQL Table";
            this.adminSQLTableButton.UseVisualStyleBackColor = true;
            this.adminSQLTableButton.Click += new System.EventHandler(this.adminSQLTableButton_Click);
            // 
            // dateReportButton
            // 
            this.dateReportButton.Location = new System.Drawing.Point(110, 210);
            this.dateReportButton.Name = "dateReportButton";
            this.dateReportButton.Size = new System.Drawing.Size(118, 23);
            this.dateReportButton.TabIndex = 2;
            this.dateReportButton.Text = "View Report";
            this.dateReportButton.UseVisualStyleBackColor = true;
            // 
            // AdminToolSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 345);
            this.Controls.Add(this.dateReportButton);
            this.Controls.Add(this.adminSQLTableButton);
            this.Controls.Add(this.label1);
            this.Name = "AdminToolSelectorForm";
            this.Text = "AdminToolSelectorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button adminSQLTableButton;
        private Button dateReportButton;
    }
}