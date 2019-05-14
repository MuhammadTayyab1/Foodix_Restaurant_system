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
    public partial class sellpro : Form
    {
        public sellpro()
        {
            InitializeComponent();
        }
        SqlConnection con;
        int check = 0;
        int pr = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr.co);
            con.Open();

            SqlCommand cqd = new SqlCommand("select * from customer where cell='"+textBox1.Text+"'", con);
            SqlDataReader reader = cqd.ExecuteReader();
            if (reader.Read())
            {
               

                label5.Text = "Name     : " + reader[0].ToString();
                label4.Text = "Email    : " + reader[2].ToString();
                label7.Text = "CNIC     : " + reader[3].ToString();
                label8.Text = "Cell     : " + reader[1].ToString();
                pr = Convert.ToInt32(reader[4].ToString());
                label3.Text = "Previous Products : " + pr;
                check = Convert.ToInt32(reader[5].ToString());
                label6.Text = "Previous amount    : " +check;

                customerdata.name = label5.Text;
                customerdata.cell = label8.Text;
                customerdata.cnic = label7.Text;
                customerdata.email = label4.Text;

                customerdata.ucell = reader[1].ToString();
                
                 

            }
            con.Close();

            if(check < -500)
            {
                MessageBox.Show("Please Clear remainig bill \n "+check);

                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }

        }

        private void sellpro_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

            textBox1.Enabled = false;
            button1.Enabled = false;

            label5.Text = "Name     : "+customerdata.name;
            label4.Text = "Email    : "+customerdata.email;
            label7.Text = "CNIC     : "+customerdata.cnic;
            label8.Text = "Cell     : "+customerdata.cell;
            label3.Hide();
            label6.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            customerdata.ch = "1";
            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

            label3.Show();
            label6.Show();

            label5.Text = "";
            label4.Text = "";
            label7.Text = "";
            label8.Text = "";

        }

        private void sellpro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            customerdata.ch = "0";

            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;


            label5.Text = "Name     : " + customerdata.name;
            label4.Text = "Email    : " + customerdata.email;
            label7.Text = "CNIC     : " + customerdata.cnic;
            label8.Text = "Cell     : " + customerdata.cell;

            label3.Hide();
            label6.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            select s = new select();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }
    }
}
