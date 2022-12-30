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

namespace FoodHome
{
    public partial class TakeAway : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ADMIN-PC\\SQLSERVER;Initial Catalog=Foods;Integrated Security=True");

        public TakeAway()
        {
            InitializeComponent();
            show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String id = textBox1.Text.ToString();
                int iid = Int32.Parse(id);
                String pro = textBox2.Text.ToString();
                String quan = textBox3.Text.ToString();
                int iquan = Int32.Parse(quan);
                String price = textBox4.Text.ToString();
                int iprice = Int32.Parse(price);
                String description = textBox5.Text.ToString();


                String qry = "insert into TakeAway values(" + iid + ",'" + pro + "'," + iquan + "," + iprice + ",'" + description + "')";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show(i + "Record added successfully : " + pro);
                }
                else
                {
                    MessageBox.Show("Record not added ! ");
                }
                con.Close();

                show();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show("Error is " + exp.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String id = textBox1.Text.ToString();
                int iid = Int32.Parse(id);
                String pro = textBox2.Text.ToString();

                String qry = "delete from TakeAway where ID=" + iid + "";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show(i + "Record deleted successfully : " + pro);
                }
                else
                {
                    MessageBox.Show("Record deletion failed ! ");
                }
                con.Close();
                show();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show("Error is " + exp.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String id = textBox1.Text.ToString();
                int iid = Int32.Parse(id);
                String pro = textBox2.Text.ToString();
                String quan = textBox3.Text.ToString();
                int iquan = Int32.Parse(quan);
                String price = textBox4.Text.ToString();
                int iprice = Int32.Parse(price);
                String description = textBox5.Text.ToString();

                String qry = "update TakeAway set Pro='" + pro + "',Quan=" + iquan + ",Price=" + iprice + ",Description='" + description + "' where ID=" + iid + "";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show(i + "Employee updated successfully : " + pro);
                }
                else
                {
                    MessageBox.Show("Employee updation failed ! ");
                }
                con.Close();
                show();
            }

            catch (System.Exception exp)
            {
                MessageBox.Show("Error is " + exp.ToString());
            }
        }
        void show()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from TakeAway", con);

            DataTable dtl = new DataTable();
            sda.Fill(dtl);

            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dtl.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                
            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from TakeAway where Pro like'%" + textBox6.Text.ToString() + "%'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
               
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
