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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public void GetData2(string str)
        {
            string sql1 = "SELECT * FROM sale00 ";

            MySqlConnection con1 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            con1.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;





            string sql = "SELECT * FROM customers ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (str == reader.GetString("CustomerID"))
                {
                    textBox7.Text = reader.GetString("CustomerName");
                    textBox8.Text = reader.GetString("CustomerType");

                }
            }


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM sale00";
            sql = "DELETE FROM sale00 ";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("เสร็จสิ้น");
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
                    textBox7.Text = reader.GetString("CustomerName");
                    textBox8.Text = reader.GetString("CustomerType");

                }
            }
        }
    }
}
