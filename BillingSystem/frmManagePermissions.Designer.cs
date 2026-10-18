namespace BillingSystem
{
    partial class frmManagePermissions
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
            lblRole = new Label();
            cmbRole = new ComboBox();
            chkAddCustomer = new CheckBox();
            chkEditCustomer = new CheckBox();
            chkDeleteCustomer = new CheckBox();
            chkAnalytics = new CheckBox();
            chkExportExcel = new CheckBox();
            chkExportPdf = new CheckBox();
            chkAuditLogs = new CheckBox();
            btnSave = new Button();
            btnClose = new Button();
            grpboxPermissions = new GroupBox();
            grpboxPermissions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(226, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Permissions";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(12, 41);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(67, 15);
            lblRole.TabIndex = 1;
            lblRole.Text = "Select Role:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Cashier" });
            cmbRole.Location = new Point(12, 58);
            cmbRole.Margin = new Padding(3, 2, 3, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(133, 23);
            cmbRole.TabIndex = 2;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            cmbRole.Click += cmbRole_SelectedIndexChanged;
            // 
            // chkAddCustomer
            // 
            chkAddCustomer.AutoSize = true;
            chkAddCustomer.Location = new Point(11, 26);
            chkAddCustomer.Margin = new Padding(3, 2, 3, 2);
            chkAddCustomer.Name = "chkAddCustomer";
            chkAddCustomer.Size = new Size(103, 19);
            chkAddCustomer.TabIndex = 3;
            chkAddCustomer.Text = "Add Customer";
            chkAddCustomer.UseVisualStyleBackColor = true;
            // 
            // chkEditCustomer
            // 
            chkEditCustomer.AutoSize = true;
            chkEditCustomer.Location = new Point(11, 49);
            chkEditCustomer.Margin = new Padding(3, 2, 3, 2);
            chkEditCustomer.Name = "chkEditCustomer";
            chkEditCustomer.Size = new Size(101, 19);
            chkEditCustomer.TabIndex = 4;
            chkEditCustomer.Text = "Edit Customer";
            chkEditCustomer.UseVisualStyleBackColor = true;
            // 
            // chkDeleteCustomer
            // 
            chkDeleteCustomer.AutoSize = true;
            chkDeleteCustomer.Location = new Point(11, 71);
            chkDeleteCustomer.Margin = new Padding(3, 2, 3, 2);
            chkDeleteCustomer.Name = "chkDeleteCustomer";
            chkDeleteCustomer.Size = new Size(114, 19);
            chkDeleteCustomer.TabIndex = 5;
            chkDeleteCustomer.Text = "Delete Customer";
            chkDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // chkAnalytics
            // 
            chkAnalytics.AutoSize = true;
            chkAnalytics.Location = new Point(11, 94);
            chkAnalytics.Margin = new Padding(3, 2, 3, 2);
            chkAnalytics.Name = "chkAnalytics";
            chkAnalytics.Size = new Size(74, 19);
            chkAnalytics.TabIndex = 6;
            chkAnalytics.Text = "Analytics";
            chkAnalytics.UseVisualStyleBackColor = true;
            // 
            // chkExportExcel
            // 
            chkExportExcel.AutoSize = true;
            chkExportExcel.Location = new Point(11, 116);
            chkExportExcel.Margin = new Padding(3, 2, 3, 2);
            chkExportExcel.Name = "chkExportExcel";
            chkExportExcel.Size = new Size(104, 19);
            chkExportExcel.TabIndex = 7;
            chkExportExcel.Text = "Export to Excel";
            chkExportExcel.UseVisualStyleBackColor = true;
            // 
            // chkExportPdf
            // 
            chkExportPdf.AutoSize = true;
            chkExportPdf.Location = new Point(11, 139);
            chkExportPdf.Margin = new Padding(3, 2, 3, 2);
            chkExportPdf.Name = "chkExportPdf";
            chkExportPdf.Size = new Size(98, 19);
            chkExportPdf.TabIndex = 8;
            chkExportPdf.Text = "Export to PDF";
            chkExportPdf.UseVisualStyleBackColor = true;
            // 
            // chkAuditLogs
            // 
            chkAuditLogs.AutoSize = true;
            chkAuditLogs.Location = new Point(11, 161);
            chkAuditLogs.Margin = new Padding(3, 2, 3, 2);
            chkAuditLogs.Name = "chkAuditLogs";
            chkAuditLogs.Size = new Size(83, 19);
            chkAuditLogs.TabIndex = 9;
            chkAuditLogs.Text = "Audit Logs";
            chkAuditLogs.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(144, 314);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 22);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Permissions";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(357, 314);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 22);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // grpboxPermissions
            // 
            grpboxPermissions.Controls.Add(chkAddCustomer);
            grpboxPermissions.Controls.Add(chkEditCustomer);
            grpboxPermissions.Controls.Add(chkAuditLogs);
            grpboxPermissions.Controls.Add(chkDeleteCustomer);
            grpboxPermissions.Controls.Add(chkExportPdf);
            grpboxPermissions.Controls.Add(chkAnalytics);
            grpboxPermissions.Controls.Add(chkExportExcel);
            grpboxPermissions.Location = new Point(12, 84);
            grpboxPermissions.Margin = new Padding(3, 2, 3, 2);
            grpboxPermissions.Name = "grpboxPermissions";
            grpboxPermissions.Padding = new Padding(3, 2, 3, 2);
            grpboxPermissions.Size = new Size(219, 208);
            grpboxPermissions.TabIndex = 12;
            grpboxPermissions.TabStop = false;
            grpboxPermissions.Text = "Permissions";
            grpboxPermissions.Enter += grpboxPermissions_Enter;
            // 
            // frmManagePermissions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 425);
            Controls.Add(grpboxPermissions);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmManagePermissions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Permissions";
            Load += frmManagePermissions_Load;
            grpboxPermissions.ResumeLayout(false);
            grpboxPermissions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void grpboxPermissions_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTitle;
        private Label lblRole;
        private ComboBox cmbRole;
        private CheckBox chkAddCustomer;
        private CheckBox chkEditCustomer;
        private CheckBox chkDeleteCustomer;
        private CheckBox chkAnalytics;
        private CheckBox chkExportExcel;
        private CheckBox chkExportPdf;
        private CheckBox chkAuditLogs;
        private Button btnSave;
        private Button btnClose;
        private GroupBox grpboxPermissions;
    }
}