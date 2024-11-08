using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWFEMPLOYEEMANAGER
{
    public partial class ClientTasks : Form
    {
        public ClientTasks()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientHome clientHome = new ClientHome();
            clientHome.Show();
            this.Hide();
        }

        private void inquiriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientInquiries clientInquiries = new ClientInquiries();
            clientInquiries.Show();
            this.Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientProfile clientProfile = new ClientProfile();
            clientProfile.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientTasks_Load(object sender, EventArgs e)
        {

        }
    }
}
