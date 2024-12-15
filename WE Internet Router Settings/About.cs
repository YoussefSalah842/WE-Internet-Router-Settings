using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WE_Internet_Router_Settings
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/YoussefSalah842");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@YoussefSalah-n8u");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/youssefsalah392/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://x.com/YoussefSalah986");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/YoussefSalah842");
        }
    }
}
