using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;

namespace BillingSystem
{
    public partial class frmBillingHistory : Form
    {
        // Update connection string to match your database settings
        //private string connectionString = "server=localhost;database=BillingSystem;uid=root;pwd=admin123";
        private int customerId;

        public frmBillingHistory(int selectedCustomerId)
        {
            InitializeComponent();
            customerId = selectedCustomerId;
        }

        private void frmBillingHistory_Load(object sender, EventArgs e)
        {
           LoadCustomerName();
            LoadBillingRecords();


        }

        private void LoadCustomerName()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                // Requirement 3.4: Retrieve customer's name from database
                string query = "SELECT FullName FROM Customers WHERE CustomerID = @CustomerID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        lblCustomerName.Text = "Billing History — " + result.ToString();
                    }
                }
            }
        }

        private void LoadBillingRecords()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT BillingMonth, PreviousReading,
                         PresentReading, Consumption, RatePerCubic,
                         TotalAmount, Status
                         FROM Billing
                         WHERE CustomerID = @CustomerID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Display the retrieved records
                        dgvBillingHistory.AutoGenerateColumns = true;
                        dgvBillingHistory.DataSource = null;
                        dgvBillingHistory.Columns.Clear();
                        dgvBillingHistory.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show(
                                "No billing records were found for that customer.",
                                "Zero Billing Records Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBillingHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}