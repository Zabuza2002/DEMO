using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp43
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Form1 f1;
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }
        DateTime dateTimeCons = new DateTime(2020, 11, 24, 6, 0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            TimeSpan div = dateTimeCons - dateTime;
            label1.Text = $"{div.Days} дней {div.Hours} часов {div.Minutes} минут";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.f4 = this;
            this.Hide();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.f4 = this;
            this.Hide();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.f4 = this;
            this.Hide();
            newForm.Show();
        }
    }
}
