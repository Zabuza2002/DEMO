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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public Form4 f4;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f4.Show();
        }
        DateTime dateTimeCon = new DateTime(2020, 11, 24, 6, 0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            TimeSpan div = dateTimeCon - dateTime;
            label1.Text = $"{div.Days} дней {div.Hours} часов {div.Minutes} минут";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=MarathonSkills; Integrated Security=SSPI;");
                con.Open();
                SqlCommand com = new SqlCommand(@"SELECT [Email] ,[Password] FROM [User] WHERE [Email]='" + textBox1.Text + "' and [Password]='" + textBox2.Text + "'", con);

                SqlDataReader rad = com.ExecuteReader();
                DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            
                if (dataGridView1.Rows[0].Cells[0].Value != null)
                {
                    label7.Text = "Вы успешно вошли";
                }
                else
                {
                    label7.Text = "Вы не вошли";
                }


           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public Form1 f1;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 newForm = new Form1();
            newForm.f5 = this;
            this.Hide();
            newForm.Show();
        }
    }
}
