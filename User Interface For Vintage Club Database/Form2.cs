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
using DatabaseProject;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class Form2 : Form
    {
        DBAccess dBAccess = new DBAccess();

        public Form2()
        {
            InitializeComponent();
        }
        public int Duh = 0;
        public void ShowMessageBox()
        {
            DialogResult msg = MessageBox.Show("There are empty fields! Would you like to continue?", "Empty Box",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Duh = 0;

            if (msg == DialogResult.OK)
            {
                MessageBoxDisplay.Text = "No";
            }
            else
            {
                MessageBoxDisplay.Text = "No";
            }
        }
        public void ColourReset()
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            numericUpDown1.BackColor = Color.White;
        }

        public void BoxChecker()
        {
            if (textBox1.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (textBox2.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (textBox3.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (textBox4.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (comboBox1.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (comboBox2.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (comboBox3.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (richTextBox1.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (pictureBox1.Image == null)
            {
                MessageBoxDisplay.Text = "Yes";
            }
            if (numericUpDown1.Text == "0")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (numericUpDown1.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (Duh == 9)
            {
                Duh = 0;
                MessageBoxDisplay.Text = "No";
                MessageBox.Show("You didn't even fill any of the boxes, you old fool!","Empty Boxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearBoxes()
        {
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            textBox1.SelectedItem = null;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            numericUpDown1.Text = "";
            pictureBox1.Image = null;
        }

        public void BoxEmpty()
        {
            if (MessageBox.Show("There are empty fields! Would you like to continue?", "Empty Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                if (textBox1.Text == "")
                {
                    textBox1.BackColor = Color.Red;
                    MessageBoxDisplay.Text = "Yes";
                }
                if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.Red;
                    MessageBoxDisplay.Text = "Yes";
                }
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = Color.Red;
                    MessageBoxDisplay.Text = "Yes";
                }
                if (textBox4.Text == "")
                {
                    textBox4.BackColor = Color.Red;
                    MessageBoxDisplay.Text = "Yes";
                }
                if (comboBox1.Text == "")
                {
                    comboBox1.BackColor = Color.Red;
                    MessageBoxDisplay.Text = "Yes";
                }
                if (comboBox2.Text == "")
                {
                    comboBox2.BackColor = Color.Red;
                    MessageBoxDisplay.Text = "Yes";
                }
                if (comboBox3.Text == "")
                {
                    comboBox3.BackColor = Color.Red;
                    MessageBoxDisplay.Text = "Yes";
                }
                if (richTextBox1.Text == "")
                {
                    richTextBox1.BackColor = Color.Red;
                    MessageBoxDisplay.Text = "Yes";
                }
                if (numericUpDown1.Value == 0)
                {
                    numericUpDown1.BackColor = Color.Red;
                    MessageBoxDisplay.Text = "Yes";
                }
            }
            else if (MessageBox.Show("There are empty fields! Would you like to continue?", "Empty Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Send incomplete form data to the database.
                
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BoxChecker();

            if (MessageBoxDisplay.Text == "Yes")
            {
                BoxEmpty();
            }

            if (textBox1.SelectedItem == null)
            {
                textBox1.BackColor = Color.Red;
                MessageBoxDisplay.Text = "Yes";
            }
            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into General_Table(Machine_Name, Year_Built, Original_Owner, Date_Acquired, Description, Image, Maintenence_Information, Model, Horse_Power, Machine_Location, Restoration_Status, Link_To_TractorData) values (@MachineName, @YearBuilt)");
            }
            if (textBox2.Text == "")
            {

            }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            string MachineType = textBox1.Text;
            string YearBuilt = numericUpDown1.Value.ToString();
            string OriginalOwner = textBox2.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NumericUpDown IdiotDetector = new NumericUpDown();
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

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            ColourReset();
        }
    }
}
