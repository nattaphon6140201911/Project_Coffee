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
    public partial class Form11 : Form
    {
        static string salid = "";
        static string salid1 = "";
        public Form11()
        {
            InitializeComponent();
            
            Random rnd = new Random();
            salid = rnd.Next(1000, 9999).ToString();
            textBox1.Text = salid;

            Random rnd1 = new Random();
            salid1 = rnd.Next(100, 999).ToString();
            textBox2.Text = salid1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM staffs1";
            /*sql2 = "INSERT INTO staffs1 (StaffID.,StaffCode,StaffName,Gender,StaffLevel) VALUES('" + textBox1.Text + " ','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')";*/
            sql2 = "INSERT INTO `staffs1`(`StaffID.`, `StaffCode`, `StaffName`, `Gender`, `StaffLevel`) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "')";
            MySqlConnection con2 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();


            string sql = "SELECT * FROM staffs";
            sql = "INSERT INTO staffs (StaffID,StaffCode,StaffName,Gender,StaffPassword,StaffLevel) VALUES('" + textBox1.Text + " ','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "')";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("สมัครสำเร็จ");
            this.Hide();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
