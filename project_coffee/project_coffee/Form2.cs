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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 aa = new Form5();
            aa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 gg = new Form4();
            gg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 gg = new Form3();
            gg.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void time_Tick(object sender, EventArgs e)
        {
            time2.Text = DateTime.Now.ToString();
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM sale_details";
            sql = "INSERT INTO sale_details (SaleDetailID,SaleID,ProductID,Price,Amount) VALUES('1','2','3','4','5')";

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

        private void dataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM sale_details";
            sql = "INSERT INTO sale_details (SaleDetailID,SaleID,ProductID,Price,Amount) VALUES('1','2','3','4','5')";

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

        private void button11_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM sale_details";
            sql = "INSERT INTO sale_details (SaleDetailID,SaleID,ProductID,Price,Amount) VALUES('1','2','3','4','5')";

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
    }
}
