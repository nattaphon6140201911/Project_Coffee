using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_coffee
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        public void GetData4(string str)
        {
            string sql = "SELECT * FROM customers ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (str == reader.GetString("CustomerID"))
                {
                    textBox1.Text = reader.GetString("CustomerName");
                    textBox2.Text = reader.GetString("CustomerType");
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ii = new Form2();
            ii.Show();
            ii.GetData6(SensData6());
            ii.GetData7(SensData7());
            this.Close();

        }
        public string SensData6()
        {
            return textBox1.Text;
        }
        public string SensData7()
        {
            return textBox2.Text;
        }
        public string SensData8()
        {
            return textBox2.Text;
        }
    }
}
