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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            v4.Text = "44";
            groupBox2.Visible = false;
            groupBox3.Visible = false;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql2 = "UPDATE products SET ProductName = '" + v2.Text + "' , Price = '" + v3.Text + "' WHERE ProductID ='" + v1.Text + "'";
            MySqlConnection con2 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();
            MessageBox.Show("เสร็จสิ้น");
            this.Hide();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql2 = "UPDATE products SET ProductName = '" + v5.Text + "' , Price = '" + v6.Text + "' WHERE ProductID ='" + v4.Text + "'";
            MySqlConnection con2 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();
            MessageBox.Show("เสร็จสิ้น");
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM products";
            sql = "DELETE FROM products WHERE ProductID = '" + textBox3.Text + "' ";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ลบออกแล้ว");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }
    }
}
