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
    public partial class ServerProfile : Form
    {
        public ServerProfile()
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
            ServerConsole serverConsole = new ServerConsole();
            serverConsole.Show();
            this.Hide();
        }
    }
}
