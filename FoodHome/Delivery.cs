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
    public partial class Delivery : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ADMIN-PC\\SQLSERVER;Initial Catalog=Foods;Integrated Security=True");

        public Delivery()
        {
            InitializeComponent();
            show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String id = textBox1.Text.ToString();
                int iid = Int32.Parse(id);
                String emp = textBox2.Text.ToString();
                String wth = textBox3.Text.ToString();
                int iwth = Int32.Parse(wth);
                String pl = textBox4.Text.ToString();
                int ipl = Int32.Parse(pl);
                String cuis = textBox5.Text.ToString();
                String dist = textBox6.Text.ToString();

                String qry = "update Delivery set Emp='" + emp + "',Wth=" + iwth + ",PL=" + ipl + ",Cuis='" + cuis + "',Dist='" + dist + "' where ID=" + iid + "";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show(i + "Employee updated successfully : " + emp);
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from Delivery", con);

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
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
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
            String emp = textBox2.Text.ToString();
            String wth = textBox3.Text.ToString();
            int iwth = Int32.Parse(wth);
            String pl = textBox4.Text.ToString();
            int ipl = Int32.Parse(pl);
            String cuis = textBox5.Text.ToString();
            String dist = textBox6.Text.ToString();


            String qry = "insert into Delivery values(" + iid + ",'" + emp + "'," + iwth + "," + ipl + ",'" + cuis + "','" + dist + "')";
            SqlCommand sc = new SqlCommand(qry, con);
            int i = sc.ExecuteNonQuery();
            if (i >= 1)
            {
                MessageBox.Show(i + "Record added successfully : " + emp);
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
            
private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
       {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String id = textBox1.Text.ToString();
                int iid = Int32.Parse(id);
                String emp = textBox2.Text.ToString();

                String qry = "delete from Delivery where ID=" + iid + "";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show(i + "Record deleted successfully : " + emp);
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
      

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Delivery where Emp like'%" + textBox7.Text.ToString() + "%'", con);

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
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
            }
            con.Close();
        }

       
    }
}




    
