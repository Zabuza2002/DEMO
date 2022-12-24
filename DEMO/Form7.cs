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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public Form8 f8;
        public Form6 f6; 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.f7= this;
            this.Hide();
            newForm.Show();
        }
    }
}
