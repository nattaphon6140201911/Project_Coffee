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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 pp = new Form9();
            pp.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sql5 = "SELECT * FROM sales";

            MySqlConnection con5 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd5 = new MySqlCommand(sql5, con5);
            con5.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
            da.Fill(ds);
            dataG1.DataSource = ds.Tables[0].DefaultView;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public void GetData(string str)
        {
            string sql1 = "SELECT * FROM sales ";

            MySqlConnection con1 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            con1.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            da.Fill(ds);
            dataG1.DataSource = ds.Tables[0].DefaultView;



            string sql = "SELECT * FROM staffs ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (str == reader.GetString("StaffName"))
                {
                    lbl_code.Text = reader.GetString("StaffCode");
                    lbl_id.Text = reader.GetString("StaffID");
                    lbl_name.Text = reader.GetString("StaffName");
                    lbl_Lv.Text = reader.GetString("StaffLevel");
                }
            }


        }
        public void GetData1(string str)
        {
            string sql1 = "SELECT * FROM staffs1 ";

            MySqlConnection con1 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            con1.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            da.Fill(ds);
            data2.DataSource = ds.Tables[0].DefaultView;
        }

        public void GetData2(string str)
        {
            string sql1 = "SELECT * FROM customers ";

            MySqlConnection con1 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            con1.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            da.Fill(ds);
            data3.DataSource = ds.Tables[0].DefaultView;
        }

        public void GetData3(string str)
        {
            string sql5 = "SELECT * FROM products";

            MySqlConnection con5 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd5 = new MySqlCommand(sql5, con5);
            con5.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
            da.Fill(ds);
            dat6.DataSource = ds.Tables[0].DefaultView;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM sales WHERE SaleDateTime LIKE  '%" + CustomerID.Text + "%' ";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataG1.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string sql5 = "SELECT * FROM sales";

            MySqlConnection con5 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd5 = new MySqlCommand(sql5, con5);
            con5.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
            da.Fill(ds);
            dataG1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql = "Admin";

            if (sql == lbl_Lv.Text)
            {
                Form11 rr = new Form11();
                rr.Show();
            }

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql5 = "SELECT * FROM staffs1";

            MySqlConnection con5 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd5 = new MySqlCommand(sql5, con5);
            con5.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
            da.Fill(ds);
            data2.DataSource = ds.Tables[0].DefaultView;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sql5 = "SELECT * FROM customers";

            MySqlConnection con5 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd5 = new MySqlCommand(sql5, con5);
            con5.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
            da.Fill(ds);
            data3.DataSource = ds.Tables[0].DefaultView;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sql5 = "SELECT * FROM products";

            MySqlConnection con5 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd5 = new MySqlCommand(sql5, con5);
            con5.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
            da.Fill(ds);
            dat6.DataSource = ds.Tables[0].DefaultView;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }

        private void dat6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form12 oo = new Form12();
            oo.Show();
        }
    }    
}
