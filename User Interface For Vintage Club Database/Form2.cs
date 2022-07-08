using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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
            //SqlCommand cmd = new SqlCommand("insert into Machine_Database values (@Machine_Type, @Year_Built, @Original_Owner, @Date_Acquired)", con); 

            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            textBox1.SelectedItem = null;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            numericUpDown1.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ImageLocation = "";
            try
            {
                OpenFileDialog Dialog = new OpenFileDialog();
                Dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png) |*.png|All Files(*.*)|*.*";

                if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageLocation = Dialog.FileName;
                    pictureBox1.ImageLocation = ImageLocation;
                }
            }
            catch
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
