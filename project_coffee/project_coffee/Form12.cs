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
    }
}
