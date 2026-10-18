namespace BillingSystem
{
    partial class CustomerListForm
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            dgvCustomers = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAnalytics = new Button();
            btnExportExcel = new Button();
            btnExportPdf = new Button();
            btnManagePermissions = new Button();
            statusStrip1 = new StatusStrip();
            lblStatusUser = new ToolStripStatusLabel();
            lblStatusSep = new ToolStripStatusLabel();
            lblStatusTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            btnAuditLog = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer List";
            lblTitle.Click += lblTitle_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(27, 95);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(715, 402);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            dgvCustomers.CellFormatting += dgvCustomers_CellFormatting;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(174, 421);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(299, 421);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(396, 420);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(289, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(411, 23);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(706, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search:";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Location = new Point(498, 420);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(75, 23);
            btnAnalytics.TabIndex = 7;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(227, 450);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(98, 23);
            btnExportExcel.TabIndex = 8;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += button1_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(345, 450);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(88, 23);
            btnExportPdf.TabIndex = 9;
            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnManagePermissions
            // 
            btnManagePermissions.Location = new Point(289, 393);
            btnManagePermissions.Margin = new Padding(3, 2, 3, 2);
            btnManagePermissions.Name = "btnManagePermissions";
            btnManagePermissions.Size = new Size(194, 22);
            btnManagePermissions.TabIndex = 10;
            btnManagePermissions.Text = "Manage Permissions";
            btnManagePermissions.UseVisualStyleBackColor = true;
            btnManagePermissions.Click += btnManagePermissions_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusUser, lblStatusSep, lblStatusTime });
            statusStrip1.Location = new Point(0, 487);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(33, 17);
            lblStatusUser.Text = "User:";
            // 
            // lblStatusSep
            // 
            lblStatusSep.Name = "lblStatusSep";
            lblStatusSep.Size = new Size(705, 17);
            lblStatusSep.Spring = true;
            lblStatusSep.Text = "    ";
            // 
            // lblStatusTime
            // 
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(33, 17);
            lblStatusTime.Text = "Time";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += statusTimer_Tick;
            // 
            // btnAuditLog
            // 
            btnAuditLog.Location = new Point(455, 448);
            btnAuditLog.Margin = new Padding(3, 2, 3, 2);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Size = new Size(82, 25);
            btnAuditLog.TabIndex = 10;
            btnAuditLog.Text = "Audit Log";
            btnAuditLog.UseVisualStyleBackColor = true;
            btnAuditLog.Click += btnAuditLog_Click;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(784, 509);
            Controls.Add(statusStrip1);
            Controls.Add(btnManagePermissions);
            Controls.Add(btnAuditLog);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportExcel);
            Controls.Add(btnAnalytics);
            Controls.Add(lblTitle);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomers);
            Name = "CustomerListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System v1.0 – Customer List (C.N.)";
            Load += CustomerListForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLogout;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAnalytics;
        private Button btnExportExcel;
        private Button btnExportPdf;
        private Button btnManagePermissions;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusUser;
        private ToolStripStatusLabel lblStatusSep;
        private ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer timer1;
        private Button btnAuditLog;
    }
}