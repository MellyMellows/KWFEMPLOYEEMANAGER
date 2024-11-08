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
    public partial class ClientInquiries : Form
    {
        public ClientInquiries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientHome clientHome = new ClientHome();
            clientHome.Show();
            this.Hide();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTasks clientTasks = new ClientTasks();
            clientTasks.Show();
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
