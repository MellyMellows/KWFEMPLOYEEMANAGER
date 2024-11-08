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
    public partial class ClientHome : Form
    {
        public ClientHome()
        {
            InitializeComponent();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTasks clientTasks = new ClientTasks();
            clientTasks.Show();
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
    }
}
