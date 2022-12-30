using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHome
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1.ProLos' table. You can move, or remove it, as needed.
            this.proLosTableAdapter.Fill(this.database1.ProLos);
            // TODO: This line of code loads data into the 'database.SoldPurchased' table. You can move, or remove it, as needed.
            this.soldPurchasedTableAdapter.Fill(this.database.SoldPurchased);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                soldPurchasedBindingSource.EndEdit();
                soldPurchasedTableAdapter.Update(database.SoldPurchased);
                MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series["Sold"].XValueMember = "Sold";
            chart1.Series["Sold"].YValueMembers = "Purchased";
            chart1.DataSource = database.SoldPurchased;
            chart1.DataBind();

                   }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                proLosBindingSource.EndEdit();
                proLosTableAdapter.Update(database1.ProLos);
                MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart2.Series["Profit"].XValueMember = "Profit";
            chart2.Series["Profit"].YValueMembers = "Profit";
            chart2.DataSource = database1.ProLos;
            chart2.DataBind();

            chart2.Series["Loss"].XValueMember = "Loss";
            chart2.Series["Loss"].YValueMembers = "Loss";
            chart2.DataSource = database1.ProLos;
            chart2.DataBind();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
