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
            colBillingMonth = new DataGridViewTextBoxColumn();
            colPreviousReading = new DataGridViewTextBoxColumn();
            colPresentReading = new DataGridViewTextBoxColumn();
            colConsumption = new DataGridViewTextBoxColumn();
            colRatePerCubic = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(31, 16);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(187, 15);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Billing History - [Customer Name]";
            // 
            // dgvBillingHistory
            // 
            dgvBillingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillingHistory.Columns.AddRange(new DataGridViewColumn[] { colBillingMonth, colPreviousReading, colPresentReading, colConsumption, colRatePerCubic, colTotalAmount, colStatus });
            dgvBillingHistory.Location = new Point(31, 54);
            dgvBillingHistory.Margin = new Padding(3, 2, 3, 2);
            dgvBillingHistory.Name = "dgvBillingHistory";
            dgvBillingHistory.RowHeadersWidth = 51;
            dgvBillingHistory.Size = new Size(812, 220);
            dgvBillingHistory.TabIndex = 1;
            dgvBillingHistory.CellContentClick += dgvBillingHistory_CellContentClick;
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
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.ForeColor = SystemColors.Control;
            btnClose.Location = new Point(720, 296);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmBillingHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 338);
            Controls.Add(btnClose);
            Controls.Add(dgvBillingHistory);
            Controls.Add(lblCustomerName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBillingHistory";
            Text = "frmBillingHistory";
            Load += frmBillingHistory_Load;
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