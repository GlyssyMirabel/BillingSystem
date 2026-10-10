using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;
using ScottPlot;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is the frmAnalytics class, which is a Windows Form that displays analytics and key performance indicators (KPIs) for the billing system. It connects to a MySQL database to retrieve data about customers, revenue, and unpaid bills, and displays this information in labels and a DataGridView.
namespace BillingSystem
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
            dgvTop5.AutoGenerateColumns = false;
            dgvTop5.Columns["FullName"].DataPropertyName = "FullName";
            dgvTop5.Columns["TotalConsumption"].DataPropertyName = "TotalConsumption";
            dgvTop5.Columns["TotalBilled"].DataPropertyName = "TotalBilled";
        }

        //Final version of the LoadKpiSummary method that retrieves and displays key performance indicators (KPIs) from the database. It calculates the total number of customers, total revenue from paid bills, and total unpaid amounts from unpaid bills, and updates the corresponding labels on the form.
        private void LoadKpiSummary()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // 1) Total number of customers 
                    string sqlCustomers = "SELECT COUNT(*) FROM Customers;";
                    using (var cmd = new MySqlCommand(sqlCustomers, conn))
                    {
                        int totalCustomers = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalCustomers.Text = $"Total Customers: {totalCustomers}"; 
                    }

                    // 2) Total revenue — sum of all PAID bills 
                    string sqlRevenue = @"SELECT IFNULL(SUM(TotalAmount), 0) 
                                  FROM   Billing 
                                  WHERE  Status = 'Paid';";
                    using (var cmd = new MySqlCommand(sqlRevenue, conn))
                    {
                        decimal totalRevenue =
        Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalRevenue.Text = $"Total Revenue: ₱{totalRevenue:N2}";
                    }

                    // 3) Total unpaid — sum of all UNPAID bills 
                    string sqlUnpaid = @"SELECT IFNULL(SUM(TotalAmount), 0) 
                                 FROM   Billing 
                                 WHERE  Status = 'Unpaid';";
                    using (var cmd = new MySqlCommand(sqlUnpaid, conn))
                    {
                        decimal totalUnpaid =
        Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalUnpaid.Text = $"Total Unpaid: ₱{totalUnpaid:N2}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading KPI summary:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAnalytics_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
