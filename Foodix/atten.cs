using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodix
{
    public partial class atten : Form
    {
        public atten()
        {
            InitializeComponent();
        }

        private void atten_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }
        SqlConnection con;
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = "Absent";
            string j = "Absent";
            string a = "Absent";
            string m = "Absent";
            string mi = "Absent";

            if(checkBox1.Checked==true)
            {
                t = "Present";
            }
            if (checkBox4.Checked == true)
            {
                j = "Present";
            } if (checkBox6.Checked == true)
            {
                a = "Present";
            } if (checkBox8.Checked == true)
            {
                mi = "Present";
            } if (checkBox10.Checked == true)
            {
                m = "Present";
            }


            con = new SqlConnection(constr.co);
            con.Open();


            SqlCommand cmd = new SqlCommand("insert into att(tom,john,alex,michel,mark,date)values('" + t + "','" + j + "','" + a + "','" + mi + "','" + m + "','" + DateTime.Now.ToString("dddd, dd MMMM yyyy") + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("sucess");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr.co);
            con.Open();

            SqlDataAdapter sdp = new SqlDataAdapter("select * from att", con);
            DataTable dtt = new DataTable();
            sdp.Fill(dtt);
            dataGridView1.DataSource = dtt;
            con.Close();
        }
    }
}
