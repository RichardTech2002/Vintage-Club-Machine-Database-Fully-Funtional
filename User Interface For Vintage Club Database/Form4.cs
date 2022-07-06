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
            textBox2.Text = Form2.Demotext1;
            textBox1.Text = Form2.Demotext2;
            textBox3.Text = Form2.Demotext3;
            textBox4.Text = Form2.Demotext4;
            richTextBox1.Text = Form2.Demotext5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Visible = false;
            button3.Enabled = true;
            button3.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            richTextBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button2.Enabled = true;
            button3.Visible = false;
            button3.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            richTextBox1.Enabled = false;
        }
    }
}
