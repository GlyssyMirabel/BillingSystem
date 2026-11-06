using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;
using BillingSystem.Utils;
using System.Text.RegularExpressions;

namespace BillingSystem
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            // 1. Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text) ||
                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                string.IsNullOrWhiteSpace(txtRetypePassword.Text))
            {
                MessageBox.Show(
                    "Please fill in all password fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // 2. Verify current password
            if (!VerifyCurrentPassword())
            {
                MessageBox.Show(
                    "Your current password is incorrect.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCurrentPassword.Clear();
                txtCurrentPassword.Focus();

                return;
            }

            // 3. Check if new password and retyped password match
            if (txtNewPassword.Text != txtRetypePassword.Text)
            {
                MessageBox.Show(
                    "New Password and Retype Password do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtRetypePassword.Clear();
                txtRetypePassword.Focus();

                return;
            }

            // 4. Check password complexity
            List<string> errors =
                CheckPasswordRequirements(txtNewPassword.Text);

            if (errors.Count > 0)
            {
                MessageBox.Show(
                    "Your new password must meet the following requirements:\n\n" +
                    string.Join("\n", errors),
                    "Password Requirements",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // 5. Update password in database
            if (UpdatePassword(txtNewPassword.Text))
            {
                MessageBox.Show(
                    "Your password has been changed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Password was not updated. Please try again.",
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (txtCurrentPassword.Text == txtNewPassword.Text)
            {
                MessageBox.Show(
                    "Your new password must be different from your current password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerifyCurrentPassword()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT Password
                           FROM Users
                           WHERE UserID = @UserID";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@UserID", AppSession.CurrentUserID);

                        object result = cmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            return false;
                        }

                        return result.ToString() == txtCurrentPassword.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to verify current password:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }


        private List<string> CheckPasswordRequirements(string password)
        {
            List<string> errors = new List<string>();

            if (password.Length < 8)
            {
                errors.Add("At least 8 characters long.");
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                errors.Add("At least one uppercase letter (A-Z).");
            }

            if (!Regex.IsMatch(password, "[a-z]"))
            {
                errors.Add("At least one lowercase letter (a-z).");
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                errors.Add("At least one numeric digit (0-9).");
            }

            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                errors.Add("At least one special character (!@#$%^&*).");
            }

            return errors;
        }

        private bool UpdatePassword(string newPassword)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE Users
                           SET Password = @NewPassword
                           WHERE UserID = @UserID";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@NewPassword", newPassword);

                        cmd.Parameters.AddWithValue(
                            "@UserID", AppSession.CurrentUserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update password:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
