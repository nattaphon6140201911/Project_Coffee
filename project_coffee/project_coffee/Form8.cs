﻿using MySql.Data.MySqlClient;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM staffs WHERE StaffName ='" + txtUserName.Text + "' AND StaffPassword ='" + txtPassword.Text + "'AND StaffLevel = 'Admin' ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())

            {
                this.Hide();
                Form5 loo1 = new Form5();
                loo1.Show();
                loo1.GetData(SensData());
            }

            


        }
        public string SensData()
        {
            return txtUserName.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 mm = new Form9();
            mm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
