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
    public partial class regcustomer : Form
    {
        public regcustomer()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" || textBox2.Text!="" || textBox3.Text!="" || textBox4.Text!="")
            {
                if(radioButton2.Checked==true)
                {
                    con = new SqlConnection(constr.co);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into customer(name,cell,email,cnic,products,amount)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','0','0')", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    this.Hide();
                    sellpro s = new sellpro();
                    s.Show();
                }
                if(radioButton1.Checked==true)
                {
                    customerdata.name = textBox1.Text;
                    customerdata.cell = textBox2.Text;
                    customerdata.cnic = textBox3.Text;
                    customerdata.email = textBox4.Text;
                    this.Hide();
                    sellpro s = new sellpro();
                    s.Show();
                }
            }
            else
            {
                MessageBox.Show("All fileds are required");
            }
        }
    }
}
