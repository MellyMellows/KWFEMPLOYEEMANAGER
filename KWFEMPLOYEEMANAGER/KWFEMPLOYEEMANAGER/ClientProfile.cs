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
    public partial class ClientProfile : Form
    {
        public ClientProfile()
        {
            InitializeComponent();
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

        private void inquiriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientInquiries clientInquiries = new ClientInquiries();
            clientInquiries.Show();
            this.Hide();
        }
    }
}
