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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public Form4 f4 = new Form4();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f4.Show();
        }
        DateTime dateTimeCons = new DateTime(2020, 11, 24, 6, 0, 0);
        private void label1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            TimeSpan div = dateTimeCons - dateTime;
            label1.Text = $"{div.Days} дней {div.Hours} часов {div.Minutes} минут";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("C:\\Fraps\\map-icon-drinks.png");
  pictureBox1.Location= new System.Drawing.Point(30, 30);//left,top
            pictureBox3.Size = new System.Drawing.Size(10,10);
           pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = image1;
        }
    } 
}
