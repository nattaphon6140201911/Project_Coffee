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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM sale_details";
            sql = "INSERT INTO sale_details (CustomerID,CustomerName,Gender,CustomerType,CustomerTelNo) VALUES('" + textBox1.Text + " ','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "')";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox3_keypress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || cInt == 8) 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเป็นตัวเลขเท่านั้น");

            }
        }
    }
}