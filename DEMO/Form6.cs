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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public Form1 f1;
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

        private void button7_Click(object sender, EventArgs e)
        {

        }
        public Form7 f7;
        private void button2_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.f6 = this;
            this.Hide();
            newForm.Show();
        }
    }
}
