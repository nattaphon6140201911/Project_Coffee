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

        private void dataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM customers WHERE CustomerID ='" + CustomerID.Text + "' ";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;

            con.Close();

            MessageBox.Show("fff");
        }
    }
}
