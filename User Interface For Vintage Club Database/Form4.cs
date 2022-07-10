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
    public partial class Form4 : Form
    {  
        public Form4()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=LAPTOP-BT59QU4U;Initial Catalog=Vintage_Database;Integrated Security=True";

        private void Form4_Load(object sender, EventArgs e)
        {          
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
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
            button4.Enabled = false;
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

        private void button4_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
