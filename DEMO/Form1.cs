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
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

     
        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.f1 = this;
            this.Hide();
            newForm.Show();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.f1 = this;
            this.Hide();
            newForm.Show();
        }
        

        private void Button4_Click(object sender, EventArgs e)
        {

        }
        DateTime dateTimeCon = new DateTime(2020, 11, 24, 6, 0, 0 );
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            TimeSpan div = dateTimeCon - dateTime;
            label3.Text = $"{div.Days} дней {div.Hours} часов {div.Minutes} минут";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("ddd dd MMMM yyyy");

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        public Form5 f5;
        public Form6 f6;
        private void button3_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.f1 = this;
            this.Hide();
            newForm.Show();
        }
    }
}
