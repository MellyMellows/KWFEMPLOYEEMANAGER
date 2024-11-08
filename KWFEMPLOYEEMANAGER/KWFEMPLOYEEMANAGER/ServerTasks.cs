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
    public partial class ServerTasks : Form
    {
        public ServerTasks()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerHome serverHome = new ServerHome();
            serverHome.Show();
            this.Hide();
        }

        private void overeviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerTasks serverTasks = new ServerTasks();
            serverTasks.Show();
            this.Hide();
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerConsole serverConsole = new ServerConsole();
            serverConsole.Show();
            this.Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerProfile serverProfile = new ServerProfile();
            serverProfile.Show();
            this.Hide();
        }
    }
}
