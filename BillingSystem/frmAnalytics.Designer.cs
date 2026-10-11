namespace BillingSystem
{
    partial class frmAnalytics
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
            lblTitle = new Label();
            plotMonthlyRevenue = new ScottPlot.WinForms.FormsPlot();
            lblTotalCustomers = new Label();
            lblTotalRevenue = new Label();
            lblTotalUnpaid = new Label();
            plotPaidUnpaid = new ScottPlot.WinForms.FormsPlot();
            lblTop5Title = new Label();
            dgvTop5 = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            TotalConsumption = new DataGridViewTextBoxColumn();
            TotalBilled = new DataGridViewTextBoxColumn();
            btnCloseAnalytics = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AccessibleName = "";
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(537, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(193, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Analytics Dashboard";
            lblTitle.Click += label1_Click;
            // 
            // plotMonthlyRevenue
            // 
            plotMonthlyRevenue.Location = new Point(280, 78);
            plotMonthlyRevenue.Margin = new Padding(3, 2, 3, 2);
            plotMonthlyRevenue.Name = "plotMonthlyRevenue";
            plotMonthlyRevenue.Size = new Size(278, 308);
            plotMonthlyRevenue.TabIndex = 1;
            plotMonthlyRevenue.Load += plotMonthlyRevenue_Load;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AccessibleName = "";
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Location = new Point(429, 49);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(104, 15);
            lblTotalCustomers.TabIndex = 2;
            lblTotalCustomers.Text = "Total Customers: 0";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(558, 49);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(114, 15);
            lblTotalRevenue.TabIndex = 3;
            lblTotalRevenue.Text = "Total Revenue: ₱0.00";
            lblTotalRevenue.Click += lblTotalRevenue_Click;
            // 
            // lblTotalUnpaid
            // 
            lblTotalUnpaid.AutoSize = true;
            lblTotalUnpaid.Location = new Point(733, 49);
            lblTotalUnpaid.Name = "lblTotalUnpaid";
            lblTotalUnpaid.Size = new Size(107, 15);
            lblTotalUnpaid.TabIndex = 4;
            lblTotalUnpaid.Text = "Total Unpaid: ₱0.00";
            lblTotalUnpaid.Click += label4_Click;
            // 
            // plotPaidUnpaid
            // 
            plotPaidUnpaid.Location = new Point(639, 78);
            plotPaidUnpaid.Margin = new Padding(3, 2, 3, 2);
            plotPaidUnpaid.Name = "plotPaidUnpaid";
            plotPaidUnpaid.Size = new Size(431, 308);
            plotPaidUnpaid.TabIndex = 5;
            plotPaidUnpaid.Load += plotPaidUnpaid_Load;
            // 
            // lblTop5Title
            // 
            lblTop5Title.AutoSize = true;
            lblTop5Title.Location = new Point(385, 404);
            lblTop5Title.Name = "lblTop5Title";
            lblTop5Title.Size = new Size(187, 15);
            lblTop5Title.TabIndex = 6;
            lblTop5Title.Text = "Top 5 Customers by Consumption";
            lblTop5Title.Click += lblTop5Title_Click;
            // 
            // dgvTop5
            // 
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop5.Columns.AddRange(new DataGridViewColumn[] { FullName, TotalConsumption, TotalBilled });
            dgvTop5.Location = new Point(385, 421);
            dgvTop5.Margin = new Padding(3, 2, 3, 2);
            dgvTop5.Name = "dgvTop5";
            dgvTop5.RowHeadersWidth = 51;
            dgvTop5.Size = new Size(574, 141);
            dgvTop5.TabIndex = 7;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 200;
            // 
            // TotalConsumption
            // 
            TotalConsumption.HeaderText = "Total Consumption";
            TotalConsumption.MinimumWidth = 6;
            TotalConsumption.Name = "TotalConsumption";
            TotalConsumption.Width = 200;
            // 
            // TotalBilled
            // 
            TotalBilled.HeaderText = "Total Billed";
            TotalBilled.MinimumWidth = 6;
            TotalBilled.Name = "TotalBilled";
            TotalBilled.Width = 200;
            // 
            // btnCloseAnalytics
            // 
            btnCloseAnalytics.Location = new Point(877, 578);
            btnCloseAnalytics.Margin = new Padding(3, 2, 3, 2);
            btnCloseAnalytics.Name = "btnCloseAnalytics";
            btnCloseAnalytics.Size = new Size(82, 22);
            btnCloseAnalytics.TabIndex = 8;
            btnCloseAnalytics.Text = "Close";
            btnCloseAnalytics.UseVisualStyleBackColor = true;
            btnCloseAnalytics.Click += btnCloseAnalytics_Click;
            // 
            // frmAnalytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 611);
            Controls.Add(btnCloseAnalytics);
            Controls.Add(dgvTop5);
            Controls.Add(lblTop5Title);
            Controls.Add(plotPaidUnpaid);
            Controls.Add(lblTotalUnpaid);
            Controls.Add(lblTotalRevenue);
            Controls.Add(lblTotalCustomers);
            Controls.Add(plotMonthlyRevenue);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Analytics Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += frmAnalytics_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ScottPlot.WinForms.FormsPlot plotMonthlyRevenue;
        private Label lblTotalCustomers;
        private Label lblTotalRevenue;
        private Label lblTotalUnpaid;
        private ScottPlot.WinForms.FormsPlot plotPaidUnpaid;
        private Label lblTop5Title;
        private DataGridView dgvTop5;
        private Button btnCloseAnalytics;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn TotalConsumption;
        private DataGridViewTextBoxColumn TotalBilled;
    }
}