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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string Demotext1 = "";
        public static string Demotext2 = "";
        public static string Demotext3 = "";
        public static string Demotext4 = "";
        public static string Demotext5 = "";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Demotext1 = textBox1.Text;
            Demotext2 = numericUpDown1.Text;
            Demotext3 = textBox2.Text;
            Demotext4 = textBox3.Text;
            Demotext5 = richTextBox1.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
            numericUpDown1.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
