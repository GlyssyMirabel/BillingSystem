using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BillingSystem
{
    public partial class frmBillingHistory : Form
    {
        // Update connection string to match your database settings
        private string connectionString = "server=localhost;database=BillingSystem;uid=root;pwd=";
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
            using (MySqlConnection conn = new MySqlConnection(connectionString))
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
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Requirement 3.6: Parameterized query filtered by customer ID
                string query = @"SELECT BillingMonth, PreviousReading, PresentReading, Consumption, RatePerCubic, TotalAmount, Status 
                                 FROM Billing WHERE CustomerID = @CustomerID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind data to your updated grid control name
                        dgvBillingHistory.DataSource = dt;

                        // Requirement 3.5 (Popup 2): Zero Billing Records Found check
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No billing records were found for that customer.",
                                            "Zero Billing Records Found",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}