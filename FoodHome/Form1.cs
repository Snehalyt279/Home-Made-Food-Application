using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timerTime.Start();
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
           firstUC1.BringToFront();

        }
       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            firstUC1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delivery dlv = new Delivery();
            dlv.Show();
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.stackoverflow.com/questions/5713934/give-url-to-picturebox");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.stackoverflow.com/questions/5713934/give-url-to-picturebox");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.stackoverflow.com/questions/5713934/give-url-to-picturebox");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stats st = new Stats();
            st.Show();
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TakeAway ta = new TakeAway();
            ta.Show();
            panel4.Height = button7.Height;
            panel4.Top = button7.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            secondUC1.BringToFront();
        }
    }
}
