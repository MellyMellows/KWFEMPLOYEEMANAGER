using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace KWFEMPLOYEEMANAGER
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Enter Button

            string username = textBox1.Text;
            string password = textBox2.Text;

            if ((username == "Client" || username == "Server") && password == "123")
            {
                label5.Text = "You are Logging IN...";
                await Task.Delay(1000);
                label5.Text = "You are Logging in... Wait...";
                await Task.Delay(1000);

                if (username == "Client")
                {
                    ClientHome clientHome = new ClientHome();
                    clientHome.Show();
                }
                else if (username == "Server")
                {
                    ServerHome serverHome = new ServerHome();
                    serverHome.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
