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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form1 f1;

        private void Form2_Load(object sender, EventArgs e)
        {
          

           
                    }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

            try
            {
                

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=MarathonSkills; Integrated Security=SSPI;");
            con.Open();
            SqlCommand com = new SqlCommand("SELECT RunnerId, CharityName, CharityLogo, CharityDescription from [MarathonSkills].[dbo].[Registration] inner join Charity on Registration.CharityId = Charity.CharityId", con);

            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
              
                for (int i = 0; i < table.Rows.Count; i++)
                {
                 if(table.Rows[i][0].ToString() == comboBox3.Text)
                    {

                        int id = Convert.ToInt32(table.Rows[i][1]);
                    
                    }
                }

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    
                
                        comboBox3.Items.Add(table.Rows[i][0].ToString() + " " + table.Rows[i][1]);


                
                }

            }
            catch
            {
                label26.Text = "Здесь будет благотворительная организация";
             
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label28.Text = "$" + textBox2.Text;
            Form3 newForm = new Form3();
            newForm.f2 = this;
            newForm.name = comboBox3.Text;
            newForm.sum = label28.Text;
            this.Hide();
            newForm.Show();
        }
   
        public void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
