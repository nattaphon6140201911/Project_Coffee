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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM sale_details";
            sql = "DELETE FROM sale_details WHERE SaleDetailID = '"+ textBox1.Text + "'  ";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            /*MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.Hide();
                Form2 loo1 = new Form2();
                loo1.Show();
            }*/

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
