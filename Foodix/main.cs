using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodix
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            regcustomer r = new regcustomer();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sellpro p = new sellpro();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerview v = new customerview();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            updatecustomer uc = new updatecustomer();
            uc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            deletecustomer dc = new deletecustomer();
            dc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            label2.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            atten a = new atten();
            a.Show();
        }
    }
}
