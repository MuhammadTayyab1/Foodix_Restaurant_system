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
    public partial class customerview : Form
    {
        public customerview()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void customerview_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(constr.co);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from customer", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void customerview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
