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
        static string salid = "";
        static string salid2 = "";
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
            string x = numericUpDown1.Text;
            MessageBox.Show(x);

            string sql = "SELECT * FROM sale_details";
            sql = "INSERT INTO sale_details (SaleDetailID,SaleID,ProductID,Price,Amount) VALUES('"+x+" ','2','3','4','5')";

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
            string oo;
            Random rnd = new Random();
            salid = rnd.Next(1000, 9999).ToString();
            oo = salid;

            string oo2;
            Random rnd2 = new Random();
            salid2 = rnd2.Next(100, 999).ToString();
            oo2 = salid2;

            string sql1 = "SELECT * FROM sale00";

            MySqlConnection con1 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            con1.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;




            string x2 = numericUpDown3.Text;
            MessageBox.Show(x2);

            string sql2 = "SELECT * FROM sale00";
            sql2 = "INSERT INTO sale00 (SaleID,ProductName,Price,Amount) VALUES('" + oo + "','2','50','" + x2 + "')";

            MySqlConnection con2 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();
            
            cmd2.ExecuteNonQuery();
            con2.Close();




            string x = numericUpDown3.Text;
            MessageBox.Show(x);

            string sql = "SELECT * FROM sale_details";
            sql = "INSERT INTO sale_details (SaleDetailID,SaleID,ProductID,Price,Amount) VALUES('" + oo2 + " ','" +oo+"','22','50','"+x+"')";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
          
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
        public void GetData(string str)
        {
            //lbl_id.Text = str;//

            string sql = "SELECT * FROM staffs ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if(str == reader.GetString("StaffName"))
                {
                    lbl_code.Text = reader.GetString("StaffCode");
                    lbl_id.Text   = reader.GetString("StaffID");
                    lbl_name.Text = reader.GetString("StaffName");
                    lbl_Lv.Text    = reader.GetString("StaffLevel");
                }
            }

        }
        public void GetData1(string str)
        {
            //lbl_code.Text = str;//

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
