namespace KWFEMPLOYEEMANAGER
{
    partial class ClientInquiries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            inquiriesToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, tasksToolStripMenuItem, inquiriesToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(56, 24);
            tasksToolStripMenuItem.Text = "Tasks";
            tasksToolStripMenuItem.Click += tasksToolStripMenuItem_Click;
            // 
            // inquiriesToolStripMenuItem
            // 
            inquiriesToolStripMenuItem.Name = "inquiriesToolStripMenuItem";
            inquiriesToolStripMenuItem.Size = new Size(79, 24);
            inquiriesToolStripMenuItem.Text = "Inquiries";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(174, 45);
            label1.TabIndex = 5;
            label1.Text = "Inquiries";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 280);
            label2.Name = "label2";
            label2.Size = new Size(133, 26);
            label2.TabIndex = 6;
            label2.Text = "Information:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 128);
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(41, 317);
            label3.Name = "label3";
            label3.Size = new Size(146, 26);
            label3.TabIndex = 7;
            label3.Text = "09xxxxxxxxxxx";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 128);
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(41, 354);
            label4.Name = "label4";
            label4.Size = new Size(193, 26);
            label4.TabIndex = 8;
            label4.Text = "xxxxxx@gmail.com";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(60, 90);
            button1.Name = "button1";
            button1.Size = new Size(312, 57);
            button1.TabIndex = 9;
            button1.Text = "Report Issues";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ClientInquiries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "ClientInquiries";
            Text = "ClientInquiries";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem inquiriesToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}