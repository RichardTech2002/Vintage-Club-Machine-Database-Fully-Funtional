using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.Demotext1;
            textBox2.Text = Form2.Demotext2;
            textBox3.Text = Form2.Demotext3;
            textBox4.Text = Form2.Demotext4;
            richTextBox1.Text = Form2.Demotext5;
        }
    }
}
