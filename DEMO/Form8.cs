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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public Form7 f7;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.f8 = this;
            this.Hide();
            newForm.Show();
        }
    }
}
