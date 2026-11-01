namespace BillingSystem
{
    partial class frmBillingHistory
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
            lblCustomerName = new Label();
            dgvBillingHistory = new DataGridView();
            btnClose = new Button();
            colBillingMonth = new DataGridViewTextBoxColumn();
            colPreviousReading = new DataGridViewTextBoxColumn();
            colPresentReading = new DataGridViewTextBoxColumn();
            colConsumption = new DataGridViewTextBoxColumn();
            colRatePerCubic = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(35, 21);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(233, 20);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Billing History - [Customer Name]";
            // 
            // dgvBillingHistory
            // 
            dgvBillingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillingHistory.Columns.AddRange(new DataGridViewColumn[] { colBillingMonth, colPreviousReading, colPresentReading, colConsumption, colRatePerCubic, colTotalAmount, colStatus });
            dgvBillingHistory.Location = new Point(35, 72);
            dgvBillingHistory.Name = "dgvBillingHistory";
            dgvBillingHistory.RowHeadersWidth = 51;
            dgvBillingHistory.Size = new Size(928, 294);
            dgvBillingHistory.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(629, 402);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // colBillingMonth
            // 
            colBillingMonth.HeaderText = "Billing Month";
            colBillingMonth.MinimumWidth = 6;
            colBillingMonth.Name = "colBillingMonth";
            colBillingMonth.Width = 125;
            // 
            // colPreviousReading
            // 
            colPreviousReading.HeaderText = "Previous Reading";
            colPreviousReading.MinimumWidth = 6;
            colPreviousReading.Name = "colPreviousReading";
            colPreviousReading.Width = 125;
            // 
            // colPresentReading
            // 
            colPresentReading.HeaderText = "Present Reading";
            colPresentReading.MinimumWidth = 6;
            colPresentReading.Name = "colPresentReading";
            colPresentReading.Width = 125;
            // 
            // colConsumption
            // 
            colConsumption.HeaderText = "Consumption";
            colConsumption.MinimumWidth = 6;
            colConsumption.Name = "colConsumption";
            colConsumption.Width = 125;
            // 
            // colRatePerCubic
            // 
            colRatePerCubic.HeaderText = "Rate Per Cubic";
            colRatePerCubic.MinimumWidth = 6;
            colRatePerCubic.Name = "colRatePerCubic";
            colRatePerCubic.Width = 125;
            // 
            // colTotalAmount
            // 
            colTotalAmount.HeaderText = "Total Amount";
            colTotalAmount.MinimumWidth = 6;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.Width = 125;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // frmBillingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvBillingHistory);
            Controls.Add(lblCustomerName);
            Name = "frmBillingHistory";
            Text = "frmBillingHistory";
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private DataGridView dgvBillingHistory;
        private DataGridViewTextBoxColumn colBillingMonth;
        private DataGridViewTextBoxColumn colPreviousReading;
        private DataGridViewTextBoxColumn colPresentReading;
        private DataGridViewTextBoxColumn colConsumption;
        private DataGridViewTextBoxColumn colRatePerCubic;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colStatus;
        private Button btnClose;
    }
}