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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public Form4 f4;
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            f4.Show();
        }
        public Form12 f12 = new Form12();
        private void button2_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12();
            newForm.f11 = this;
            this.Hide();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            f4.Show();
        }
    }
}
