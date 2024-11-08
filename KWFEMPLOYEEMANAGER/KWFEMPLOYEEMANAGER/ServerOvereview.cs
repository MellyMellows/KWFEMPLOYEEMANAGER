using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;

namespace KWFEMPLOYEEMANAGER
{
    public partial class ServerOvereview : Form
    {
        public ServerOvereview()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                string filePath = @"C:\Users\Admin\source\repos\KWFEMPLOYEEMANAGER\Book1.xlsx";
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                        });
                        DataTable dataTable = result.Tables["Sheet1"];

                        // Ensure at least 10 rows, filling with null if necessary
                        while (dataTable.Rows.Count < 10)
                        {
                            DataRow newRow = dataTable.NewRow();
                            newRow["Employee Name"] = "N/A";
                            dataTable.Rows.Add(newRow);
                        }

                        if (dataTable != null)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerHome serverHome = new ServerHome();
            serverHome.Show();
            this.Hide();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerTasks serverTasks = new ServerTasks();
            serverTasks.Show();
            this.Hide();
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerConsole console = new ServerConsole();
            console.Show();
            this.Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerProfile serverProfile = new ServerProfile();
            serverProfile.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }
    }
}
