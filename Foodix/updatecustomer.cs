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
    public partial class updatecustomer : Form
    {
        public updatecustomer()
        {
            InitializeComponent();
        }

        private void updatecustomer_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                button2.Enabled = true;
                con = new SqlConnection(constr.co);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from customer where cell='"+textBox2.Text+"'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                    textBox5.Text = reader[4].ToString();
                    textBox6.Text = reader[5].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid pin");
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("enter cell number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr.co);
            con.Open();

            SqlCommand cnd = new SqlCommand("UPDATE customer SET name='" + textBox1.Text + "',cell='" + textBox2.Text + "',email='"+textBox3.Text+"',cnic='"+textBox4.Text+"',products='"+textBox5.Text+"',amount='"+textBox6.Text+"' WHERE cell='" + textBox2.Text + "'", con);
            cnd.ExecuteNonQuery();

            MessageBox.Show("sucess");


            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void updatecustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
