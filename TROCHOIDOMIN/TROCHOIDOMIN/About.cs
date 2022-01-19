using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace TROCHOIDOMIN
{
    public partial class About : Form
    {
        Form1 ori;
        public About(Form1 f2)
        {
            ori = f2;
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            ori.timer1.Stop();
            ori.Enabled = false;
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://facebook.com/kusok.kg123");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ori.stopgame == false && ori.clickFirst == false)
            {
                ori.timer1.Enabled = true;
                ori.timer1.Start();
                Thread.Sleep(200);
            }
            ori.cb_level.Focus();
            ori.Enabled = true;
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pic_clock_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
