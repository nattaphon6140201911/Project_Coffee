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
        static string bnn = "";
        static string salid1 = "";
        


        public Form2()
        {
            InitializeComponent();
            string oo;
            Random rnd = new Random();
            salid = rnd.Next(1000, 9999).ToString();
            textBox1.Text = salid;
            textBox2.Text = "0";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 aa = new Form8();
            aa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 gg = new Form9();
            gg.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            


            string sql = "SELECT * FROM customers WHERE CustomerID ='" + CustomerID.Text + "' ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())

            {
                string sql3 = "SELECT * FROM sales";
                sql3 = "INSERT INTO sales (SaleID,SaleDateTime,CustomerID,StaffID,GrandTotal) VALUES('" + textBox1.Text + " ','" + dateTimePicker1.Value + "','" + CustomerID.Text + "','" + lbl_id.Text + "','" + textBox2.Text + "')";


                MySqlConnection con3 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
                MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
                con3.Open();

                cmd3.ExecuteNonQuery();

                Form4 gg = new Form4();
                gg.Show();
                gg.GetData2(SensData2());
                gg.GetData3(SensData3());
                CustomerID.Text = "";
                numericUpDown1.Text = "0";
                numericUpDown2.Text = "0";
                numericUpDown3.Text = "0";

                textBox2.Text = "0";


                Random rnd = new Random();
                salid = rnd.Next(1000, 9999).ToString();
                textBox1.Text = salid;
            }

            




        }
        public string SensData2()
        {
            return CustomerID.Text;
        }
        public string SensData3()
        {
            return textBox2.Text;
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
            MessageBox.Show("Americano 50 บาท คล้ายๆ กับเอสเพรสโซ่ แต่จะอ่อนกว่าเล็กน้อย");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espresso 50 บาท เป็นการใช้เมล็ดกาแฟบด เข้าเครื่องชงกาแฟที่จะใช้แรงอัดไอน้ำให้ผ่านเมล็ดกาแฟส่งกลิ่นหอมๆ และเข้มข้น");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
      
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




            string x2 = numericUpDown1.Text;
            MessageBox.Show(x2);

            string sql2 = "SELECT * FROM sale00";
            sql2 = "INSERT INTO sale00 (SaleDetailID,ProductName,Price,Amount) VALUES('" + oo2 + "','Espresso','50','" + x2 + "')";

            MySqlConnection con2 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();

            cmd2.ExecuteNonQuery();
            con2.Close();




            string x4 = (numericUpDown1.Text);
            int b = 50 * Convert.ToInt32(x4);
            int bc = 50 * Convert.ToInt32(x4);
            int ddf = Convert.ToInt32(textBox2.Text);
            b += ddf;

            bnn = b.ToString();
            

            string sql = "SELECT * FROM sale_details";
            sql = "INSERT INTO sale_details (SaleDetailID,SaleID,ProductID,Price,Quantity,Amount) VALUES('" + oo2 + " ','" + textBox1.Text + "','11','50','" + x2 + "','" + bc + "')";
            
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            
            textBox2.Text = bnn;


            cmd.ExecuteNonQuery();
            con.Close();





            /*string sql3 = "SELECT * FROM sales";
            sql3 = "INSERT INTO sales (SaleID,SaleDateTime,CustomerID,StaffID,GrandTotal) VALUES('" + textBox1.Text + " ','" + time2.Text + "','11','"+lbl_id.Text+"','"+textBox2+"')";

            MySqlConnection con3 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
            con3.Open();

            cmd3.ExecuteNonQuery();
            con3.Close();*/





        }

        private void dataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            

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
            sql2 = "INSERT INTO sale00 (SaleDetailID,ProductName,Price,Amount) VALUES('" + oo2 + "','Americano','50','" + x2 + "')";

            MySqlConnection con2 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();

            cmd2.ExecuteNonQuery();
            con2.Close();



            string x4 = (numericUpDown3.Text);
            int b = 50 * Convert.ToInt32(x4);
            int bc = 50 * Convert.ToInt32(x4);
            int ddf = Convert.ToInt32(textBox2.Text);
            b += ddf;

            bnn = b.ToString();

            string sql = "SELECT * FROM sale_details";
            sql = "INSERT INTO sale_details (SaleDetailID,SaleID,ProductID,Price,Quantity,Amount) VALUES('" + oo2 + " ','" + textBox1.Text + "','22','50','" + x2 + "','" + bc +" ')";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            textBox2.Text = bnn;

            cmd.ExecuteNonQuery();
            con.Close();



            

           /* string sql3 = "SELECT * FROM sales";
            sql3 = "INSERT INTO sales (SaleID,SaleDateTime,CustomerID,StaffID,GrandTotal) VALUES('" + textBox1.Text + " ','" + time2.Text + "','11','" + lbl_id.Text + "','xx')";

            MySqlConnection con3 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
            con3.Open();

            cmd3.ExecuteNonQuery();
            con3.Close();*/


        }

        private void button11_Click(object sender, EventArgs e)
        {
            

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




            string x2 = numericUpDown2.Text;
            MessageBox.Show(x2);

            string sql2 = "SELECT * FROM sale00";
            sql2 = "INSERT INTO sale00 (SaleDetailID,ProductName,Price,Amount) VALUES('" + oo2 + "','Cappuccino','50','" + x2 + "')";

            MySqlConnection con2 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();

            cmd2.ExecuteNonQuery();
            con2.Close();


            string x4 = (numericUpDown2.Text);
            int b = 50 * Convert.ToInt32(x4);
            int bc = 50 * Convert.ToInt32(x4);
            int ddf = Convert.ToInt32(textBox2.Text);
            b += ddf;

            bnn = b.ToString();

            string sql = "SELECT * FROM sale_details";
            sql = "INSERT INTO sale_details (SaleDetailID,SaleID,ProductID,Price,Quantity,Amount) VALUES('" + oo2 + " ','" + textBox1.Text + "','33','50','" + x2 + "','" + bc + "')" ;

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            textBox2.Text = bnn;

            cmd.ExecuteNonQuery();
            con.Close();


            

            /*string sql3 = "SELECT * FROM sales";
            sql3 = "INSERT INTO sales (SaleID,SaleDateTime,CustomerID,StaffID,GrandTotal) VALUES('" + textBox1.Text + " ','" + time2.Text + "','11','" + lbl_id.Text + "',' xx ')";

            MySqlConnection con3 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
            con3.Open();

            cmd3.ExecuteNonQuery();
            con3.Close();*/


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
            //lbl_code.Text = str;//

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM customers WHERE CustomerID ='" + CustomerID.Text + "' ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())

            {

                Form7 gg1 = new Form7();
                gg1.Show();
                gg1.GetData4(SensData4());
            }
            this.Close();
        }


        public string SensData4()
        {
            return CustomerID.Text;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
            string sql = "SELECT * FROM sale_details";
            sql = "DELETE FROM sale_details WHERE SaleDetailID = '" + textBox4.Text + "'  ";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ลบออกแล้ว");



            string sql1 = "SELECT * FROM sale00";
            sql1 = "DELETE FROM sale00 WHERE SaleDetailID = '" + textBox4.Text + "'  ";

            MySqlConnection con1 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);


            con1.Open();
            cmd1.ExecuteNonQuery();
            con1.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form6 aa = new Form6();
            aa.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM sale00 ";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;

            con.Close();



        }
        public void GetData6(string str)
        {
            /*string sql = "SELECT * FROM customers ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (str == reader.GetString("CustomerID"))
                {
                    textBox3.Text = reader.GetString("CustomerName");
                    textBox2.Text = reader.GetString("CustomerType");

                }
            }*/
            
        }
        public void GetData7(string str)
        {
            
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            string sql5 = "SELECT * FROM sale00";

            MySqlConnection con5 = new MySqlConnection("host=localhost;user=root;password=25252542;database=coffee_project");
            MySqlCommand cmd5 = new MySqlCommand(sql5, con5);
            con5.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd5);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cappuccino 50 บาท กาแฟคาปูชิโน่จะเป็นการนำเอากาแฟเอสเพรสโซ่ มาผสมกับนม");
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            Form10 gg = new Form10();
            gg.Show();
        }
    }
}
