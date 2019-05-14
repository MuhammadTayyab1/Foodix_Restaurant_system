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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Foodix
{
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }
        int total = 0;
        SqlConnection con;
        private void select_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    int p1 = int.Parse(textBox3.Text);
                    total += 120 * p1;
                }
                if (checkBox2.Checked == true)
                {
                    int p2 = int.Parse(textBox4.Text);
                    total += 100 * p2;
                }
                if (checkBox3.Checked == true)
                {
                    int p3 = int.Parse(textBox5.Text);
                    total += 110 * p3;
                }
                if (checkBox4.Checked == true)
                {
                    int p4 = int.Parse(textBox6.Text);
                    total += 170 * p4;
                }

                if (checkBox5.Checked == true)
                {
                    int p5 = int.Parse(textBox7.Text);
                    total += 110 * p5;
                }
                if (checkBox6.Checked == true)
                {
                    int p6 = int.Parse(textBox8.Text);
                    total += 120 * p6;
                }
                if (checkBox7.Checked == true)
                {
                    int p7 = int.Parse(textBox9.Text);
                    total += 130 * p7;
                }
                if (checkBox8.Checked == true)
                {
                    int p8 = int.Parse(textBox10.Text);
                    total += 180 * p8;
                }



                if (checkBox9.Checked == true)
                {
                    int p9 = int.Parse(textBox1.Text);
                    total += 100 * p9;
                }
                if (checkBox10.Checked == true)
                {
                    int p10 = int.Parse(textBox2.Text);
                    total += 110 * p10;
                }
                if (checkBox11.Checked == true)
                {
                    int p11 = int.Parse(textBox11.Text);
                    total += 130 * p11;
                }



                if (checkBox12.Checked == true)
                {
                    int p12 = int.Parse(textBox14.Text);
                    total += 250 * p12;
                }
                if (checkBox13.Checked == true)
                {
                    int p13 = int.Parse(textBox13.Text);
                    total += 250 * p13;
                }
                if (checkBox14.Checked == true)
                {
                    int p14 = int.Parse(textBox12.Text);
                    total += 400 * p14;
                }


                if (checkBox15.Checked == true)
                {
                    int p15 = int.Parse(textBox17.Text);
                    total += 150 * p15;
                }
                if (checkBox16.Checked == true)
                {
                    int p16 = int.Parse(textBox16.Text);
                    total += 120 * p16;
                }
                if (checkBox17.Checked == true)
                {
                    int p17 = int.Parse(textBox15.Text);
                    total += 200 * p17;
                }


                if (checkBox18.Checked == true)
                {
                    int p18 = int.Parse(textBox20.Text);
                    total += 65 * p18;
                }
                if (checkBox19.Checked == true)
                {
                    int p19 = int.Parse(textBox19.Text);
                    total += 25 * p19;
                }
                if (checkBox20.Checked == true)
                {
                    int p20 = int.Parse(textBox18.Text);
                    total += 30 * p20;
                }

                textBox21.Text = Convert.ToString(total);

                float to = float.Parse(textBox21.Text);
                float discount = to * 0.30f;
                textBox22.Text = Convert.ToString(discount);
                float final = to - discount;
                textBox23.Text = Convert.ToString(final);
            }
            catch
            {
                MessageBox.Show("Enter complete data");
            }

        }

        private void select_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Enabled = true;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Enabled = true;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            textBox14.Enabled = true;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            textBox13.Enabled = true;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            textBox12.Enabled = true;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            textBox17.Enabled = true;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            textBox16.Enabled = true;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            textBox15.Enabled = true;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            textBox20.Enabled = true;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            textBox19.Enabled = true;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            textBox18.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(customerdata.ch=="0")
            {
                Random r = new Random();
                int ran = r.Next(89099, 999999);
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("" + customerdata.ucell +".pdf", FileMode.Create));
                doc.Open();

                Paragraph a = new Paragraph("\n\n                                                          INVOICE");
                doc.Add(a);

                Paragraph p = new Paragraph("                                             **** Foodix **** \n\n");
                doc.Add(p);

                Paragraph p1 = new Paragraph("                  Date  :  " + DateTime.Now.ToString("MM/dd/yyyy") + "\n");
                doc.Add(p1);

                Paragraph p2 = new Paragraph("                  Time  :  " + DateTime.Now.ToString("HH:mm:ss") + "\n");
                doc.Add(p2);
                

                Paragraph p90 = new Paragraph("                  Invoice number  :  " + ran + "\n\n");
                doc.Add(p90);

                Paragraph p3 = new Paragraph("                  _____________________________________________  \n\n");
                doc.Add(p3);

                Paragraph p4 = new Paragraph("                  Customer Name  :  " + customerdata.name + "\n");
                doc.Add(p4);

                Paragraph po = new Paragraph("                  Product Name  : Food items \n");
                doc.Add(po);


                Paragraph p7 = new Paragraph("                  Total amount  :  " + textBox23.Text + "\n\n");
                doc.Add(p7);

                Paragraph p8 = new Paragraph("                  _____________________________________________\n\n");
                doc.Add(p8);

                Paragraph p9 = new Paragraph("                  Thanks for purchase from us ");
                doc.Add(p9);

                Paragraph p10 = new Paragraph("                  Contact us : 1234567890 \n\n");
                doc.Add(p10);

                Paragraph pl = new Paragraph("                   copyright all rights reserved CMT softwares soltion ");
                doc.Add(pl);

                Paragraph pq = new Paragraph("                   https://sites.google.com/view/cmt-softwares-solution/home ");
                doc.Add(pq);



                doc.Close();
                MessageBox.Show("sucess");




            }
            else if(customerdata.ch=="1")
            {
                con = new SqlConnection(constr.co);
                con.Open();
                MessageBox.Show(customerdata.ucell);
                SqlCommand cnd = new SqlCommand("UPDATE customer SET products='1',amount='" + textBox23.Text + "' WHERE cell='" + customerdata.ucell + "'", con);
                cnd.ExecuteNonQuery();

                MessageBox.Show("ok");


                con.Close();


                Random r = new Random();
                int ran = r.Next(89099, 999999);

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("" + customerdata.ucell +".pdf", FileMode.Create));
                doc.Open();

                Paragraph a = new Paragraph("\n\n                                                          INVOICE");
                doc.Add(a);

                Paragraph p = new Paragraph("                                             **** Foodix **** \n\n");
                doc.Add(p);

                Paragraph p1 = new Paragraph("                  Date  :  " + DateTime.Now.ToString("MM/dd/yyyy") + "\n");
                doc.Add(p1);

                Paragraph p2 = new Paragraph("                  Time  :  " + DateTime.Now.ToString("HH:mm:ss") + "\n");
                doc.Add(p2);
                

                Paragraph p90 = new Paragraph("                  Invoice number  :  " + ran + "\n\n");
                doc.Add(p90);

                Paragraph p3 = new Paragraph("                  _____________________________________________  \n\n");
                doc.Add(p3);

                Paragraph p4 = new Paragraph("                  Customer " + customerdata.name + "\n");
                doc.Add(p4);

                Paragraph po = new Paragraph("                  Product Name  : Food items \n");
                doc.Add(po);


                Paragraph p7 = new Paragraph("                  Total amount  :  " + textBox23.Text + "\n\n");
                doc.Add(p7);

                Paragraph p8 = new Paragraph("                  _____________________________________________\n\n");
                doc.Add(p8);

                Paragraph p9 = new Paragraph("                  Thanks for purchase from us ");
                doc.Add(p9);

                Paragraph p10 = new Paragraph("                  Contact us : 1234567890 \n\n");
                doc.Add(p10);

                Paragraph pl = new Paragraph("                   copyright all rights reserved CMT softwares soltion ");
                doc.Add(pl);

                Paragraph pq = new Paragraph("                   https://sites.google.com/view/cmt-softwares-solution/home ");
                doc.Add(pq);



                doc.Close();
                MessageBox.Show("sucess");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }
    }
}
