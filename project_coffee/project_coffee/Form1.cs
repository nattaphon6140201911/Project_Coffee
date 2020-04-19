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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> tre = new List<string>();
            List<string> re = new List<string>();


            string sql = "SELECT * FROM staffs WHERE StaffName ='" + txtUserName.Text + "' AND StaffPassword ='" + txtPassword.Text+ "' " ;
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            
            while(reader.Read())

            {
                this.Hide();
                Form2 loo1 = new Form2();
                loo1.Show();
                loo1.GetData(SensData());   
            }          

        }
        public string SensData()
        {
            return txtUserName.Text;


        }
        
    }
}
