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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            groupBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM staffs";
            sql = "DELETE FROM staffs WHERE StaffID = '" + v4.Text + "' ";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            string sql1 = "SELECT * FROM staffs1";
            sql1 = "DELETE FROM staffs1 WHERE StaffID. = '" + v4.Text + "' ";

            MySqlConnection con1 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);

            con1.Open();
            cmd1.ExecuteNonQuery();
            con1.Close();

            MessageBox.Show("ลบออกแล้ว");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql2 = "UPDATE staffs SET StaffLevel = '" + v3.Text + "' WHERE StaffID ='" + v1.Text + "'";
            MySqlConnection con2 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();


            string sql = "UPDATE `staffs1` SET `StaffLevel` = '" + v3.Text + "' WHERE `StaffID.` ='" + v1.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("เสร็จสิ้น");
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = true;
        }
    }
}
