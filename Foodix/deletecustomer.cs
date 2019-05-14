using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Foodix
{
    public partial class deletecustomer : Form
    {
        public deletecustomer()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con = new SqlConnection(constr.co);
                con.Open();

                SqlCommand cmd = new SqlCommand("delete from customer where cell='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("sucess");
            }
            else
            {
                MessageBox.Show("All fileds are required");
            }
        }

        private void deletecustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }
    }
}
