//Serverhome
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
    public partial class ServerHome : Form
    {
        public ServerHome()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void overeviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerOvereview serverOvereview = new ServerOvereview();
            serverOvereview.Show();
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
            ServerProfile profile = new ServerProfile();
            profile.Show();
            this.Hide();
        }
    }
}
