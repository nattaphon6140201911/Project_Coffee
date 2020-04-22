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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mm = new Form1();
            mm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 mm = new Form8();
            mm.Show();
            this.Hide();
        }
    }
}
