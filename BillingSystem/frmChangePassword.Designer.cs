namespace BillingSystem
{
    partial class frmChangePassword
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
            lblCurrentPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblRetypePassword = new Label();
            txtRetypePassword = new TextBox();
            btnSavePassword = new Button();
            btnCancel = new Button();
            lblChangePassword = new Label();
            SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(87, 77);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(103, 15);
            lblCurrentPassword.TabIndex = 0;
            lblCurrentPassword.Text = "Current Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(87, 95);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(632, 23);
            txtCurrentPassword.TabIndex = 1;
            txtCurrentPassword.UseSystemPasswordChar = true;
            txtCurrentPassword.TextChanged += txtCurrentPassword_TextChanged;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(87, 137);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(87, 15);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(87, 155);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(632, 23);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // lblRetypePassword
            // 
            lblRetypePassword.AutoSize = true;
            lblRetypePassword.Location = new Point(87, 198);
            lblRetypePassword.Name = "lblRetypePassword";
            lblRetypePassword.Size = new Size(99, 15);
            lblRetypePassword.TabIndex = 4;
            lblRetypePassword.Text = "Retype Password:";
            // 
            // txtRetypePassword
            // 
            txtRetypePassword.Location = new Point(87, 216);
            txtRetypePassword.Name = "txtRetypePassword";
            txtRetypePassword.Size = new Size(632, 23);
            txtRetypePassword.TabIndex = 5;
            txtRetypePassword.UseSystemPasswordChar = true;
            // 
            // btnSavePassword
            // 
            btnSavePassword.BackColor = Color.FromArgb(55, 86, 35);
            btnSavePassword.ForeColor = SystemColors.ButtonHighlight;
            btnSavePassword.Location = new Point(183, 270);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(185, 23);
            btnSavePassword.TabIndex = 6;
            btnSavePassword.Text = "Save Password";
            btnSavePassword.UseVisualStyleBackColor = false;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(410, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(185, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePassword.Location = new Point(294, 21);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(214, 32);
            lblChangePassword.TabIndex = 8;
            lblChangePassword.Text = "Change Password";
            lblChangePassword.Click += lblChangePassword_Click;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblChangePassword);
            Controls.Add(btnCancel);
            Controls.Add(btnSavePassword);
            Controls.Add(txtRetypePassword);
            Controls.Add(lblRetypePassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblCurrentPassword);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentPassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblRetypePassword;
        private TextBox txtRetypePassword;
        private Button btnSavePassword;
        private Button btnCancel;
        private Label lblChangePassword;
    }
}