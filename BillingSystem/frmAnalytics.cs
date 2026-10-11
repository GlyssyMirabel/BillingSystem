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
                MessageBox.Show($"Error loading KPI summary:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMonthlyRevenueChart()
        {
            try
            {
                var months = new List<string>();
                var amounts = new List<double>();

                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Group PAID bills by month and sum the total amount
                    string sql = @"SELECT BillingMonth,
                                  SUM(TotalAmount) AS MonthlyTotal
                           FROM   Billing
                           WHERE  Status = 'Paid'
                           GROUP  BY BillingMonth
                           ORDER  BY MIN(BillingDate);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //months.Add(reader.GetString("BillingMonth"));
                            // Shorten "January 2026" to "Jan 2026" so labels fit
                            string raw = reader.GetString("BillingMonth");
                            months.Add(DateTime.TryParse(raw, out var d) ? d.ToString("MMM yyyy") : raw);

                            amounts.Add((double)reader.GetDecimal("MonthlyTotal"));
                        }
                    }
                }

                // Clear any existing plot before drawing a new one
                plotMonthlyRevenue.Plot.Clear();

                // Add a bar chart using the amounts as bar heights
                double[] values = amounts.ToArray();


                plotMonthlyRevenue.Plot.Add.Bars(values);

                // Use the month names as X-axis tick labels
                double[] positions = new double[months.Count];
                for (int i = 0; i < months.Count; i++) positions[i] = i;

                var bottom = plotMonthlyRevenue.Plot.Axes.Bottom;
                bottom.SetTicks(positions, months.ToArray());

                // Label styling: anchored by the end of the text, with room reserved below
                bottom.TickLabelStyle.Rotation = -45;
                bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;
                bottom.MinimumSize = 90;

                // Bars sit directly on the axis (no gap underneath)
                plotMonthlyRevenue.Plot.Axes.Margins(bottom: 0);


                plotMonthlyRevenue.Plot.Title("Monthly Revenue (Paid Bills)");
                plotMonthlyRevenue.Plot.YLabel("Revenue (₱)");
                plotMonthlyRevenue.Plot.XLabel("Month");

                plotMonthlyRevenue.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading monthly revenue chart:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPaidUnpaidChart()
        {
            try
            {
                int paidCount = 0;
                int unpaidCount = 0;

                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Group all bills by status and count each group
                    string sql = @"SELECT Status, COUNT(*) AS StatusCount
                           FROM   Billing
                           GROUP  BY Status;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader.GetString("Status");
                            int count = reader.GetInt32("StatusCount");

                            if (status == "Paid") paidCount = count;
                            if (status == "Unpaid") unpaidCount = count;
                        }
                    }
                }

                // Clear any existing plot before drawing a new one
                plotPaidUnpaid.Plot.Clear();

                // Build the pie slices: Paid and Unpaid
                double[] values = { paidCount, unpaidCount };
                string[] labels = { "Paid", "Unpaid" };
                double total = paidCount + unpaidCount;

                var pie = plotPaidUnpaid.Plot.Add.Pie(values);
                for (int i = 0; i < pie.Slices.Count; i++)
                {
                    pie.Slices[i].Label = $"{labels[i]} ({values[i] / total:P0})";
                }
                pie.SliceLabelDistance = 0.5;   // place labels on the slices

                plotPaidUnpaid.Plot.Title("Paid vs Unpaid Bills");
                plotPaidUnpaid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Paid/Unpaid chart:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTop5Customers()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT c.FullName,
                                  SUM(b.Consumption)  AS TotalConsumption,
                                  SUM(b.TotalAmount)  AS TotalBilled
                           FROM   Customers c
                           INNER JOIN Billing b ON c.CustomerID = b.CustomerID
                           GROUP  BY c.CustomerID, c.FullName
                           ORDER  BY TotalConsumption DESC
                           LIMIT  5;";

                    using (var adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvTop5.DataSource = dt;

                        if (dgvTop5.Columns.Count > 0)
                        {
                            dgvTop5.Columns["FullName"].HeaderText = "Customer Name";
                            dgvTop5.Columns["TotalConsumption"].HeaderText = "Total Consumption (kWh)";
                            dgvTop5.Columns["TotalBilled"].HeaderText = "Total Billed (₱)";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Top 5 customers:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void frmAnalytics_Load(object sender, EventArgs e)
        {
            LoadKpiSummary();
            LoadMonthlyRevenueChart();
            LoadPaidUnpaidChart();
            LoadTop5Customers();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseAnalytics_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plotMonthlyRevenue_Load(object sender, EventArgs e)
        {

        }

        private void plotPaidUnpaid_Load(object sender, EventArgs e)
        {

        }

        private void lblTop5Title_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}
