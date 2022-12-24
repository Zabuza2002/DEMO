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
namespace WindowsFormsApp43
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form2 f2;
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        DateTime dateTimeCons = new DateTime(2020, 11, 24, 6, 0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            TimeSpan div = dateTimeCons - dateTime;
            label4.Text = $"{div.Days} дней {div.Hours} часов {div.Minutes} минут";
        }
        public string name;
        public string sum;
        private void Form3_Load(object sender, EventArgs e)
        {
            label7.Text = sum; 
            label5.Text = name;
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            f2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
