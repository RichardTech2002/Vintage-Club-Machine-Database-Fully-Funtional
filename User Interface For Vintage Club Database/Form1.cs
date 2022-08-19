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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-BT59QU4U;Initial Catalog=Machine_Database_Fixed;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult UpdatedData = MessageBox.Show("Wait! Do you want to back up the database before closing this program? Just in case Gary spills coffee on the computer or something.", "Wait!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == UpdatedData)
            {
                Application.Exit();
            }
            if (DialogResult.Cancel == UpdatedData)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdg = new FolderBrowserDialog();
            if (fdg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdg.SelectedPath;
                string database = con.Database.ToString();
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("You need to select a place or folder to put the back up file.", "Enter Location");
                }
                else
                {
                    try
                    {
                        string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '" + textBox1.Text + "\\" + "Kaipara Heritage Machinery Club Database Backup" + " -- " + DateTime.Now.ToString("g--HH--ss") + ".bak'";
                        con.Open();
                        SqlCommand command = new SqlCommand(cmd, con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Database successfully backed up!", "Backed Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Can't backup the database for whatever reason.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string database = con.Database.ToString();
            //if(textBox1.Text == string.Empty)
            //{
            //    MessageBox.Show("You need to select a place or folder to put the back up file.", "Enter Location");
            //}
            //else
            //{
            //    string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '" + textBox1.Text + "\\" + "SQL SERVER Database Backup File" + "-" + DateTime.Now.ToString("DD-MM-YYYY--hh-mm-ss") + ".bak'";
            //    con.Open();
            //    SqlCommand command = new SqlCommand(cmd, con);
            //    command.ExecuteNonQuery();
            //    MessageBox.Show("Database successfully backed up!", "Backed Up");
            //    con.Close();
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Database Backup File(*.bak) |*.bak";
            ofd.Title = "Database Backup File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
                string database = con.Database.ToString();
                con.Open();

                try
                {
                    string str1 = string.Format("Alter Database [" + database + "] set single_user with rollback immediate;");
                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    cmd1.ExecuteNonQuery();

                    string str2 = "use master restore database[" + database + "] from disk = '" + textBox2.Text + "' with replace;";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    cmd2.ExecuteNonQuery();

                    string str3 = string.Format("Alter database[" + database + "] set multi_user");
                    SqlCommand cmd3 = new SqlCommand(str3, con);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Database fully restored!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch
                {
                    string str4 = string.Format("Alter database[" + database + "] set multi_user");
                    SqlCommand cmd4 = new SqlCommand(str4, con);
                    cmd4.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Something went wrong.", "Restoration Failed");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string database = con.Database.ToString();
            //con.Open();

            //try
            //{
            //    string str1 = string.Format("Alter Database [" + database + "] set single_user with rollback immediate;");
            //    SqlCommand cmd1 = new SqlCommand(str1, con);
            //    cmd1.ExecuteNonQuery();

            //    string str2 = "use master restore database[" + database + "] from disk = '" + textBox2.Text + "' with replace;";
            //    SqlCommand cmd2 = new SqlCommand(str2, con);
            //    cmd2.ExecuteNonQuery();

            //    string str3 = string.Format("Alter database[" + database + "] set multi_user");
            //    SqlCommand cmd3 = new SqlCommand(str3, con);
            //    cmd3.ExecuteNonQuery();

            //    MessageBox.Show("Database fully restored!","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    con.Close();
            //}
            //catch
            //{
            //    string str4 = string.Format("Alter database[" + database + "] set multi_user");
            //    SqlCommand cmd4 = new SqlCommand(str4, con);
            //    cmd4.ExecuteNonQuery();

            //    con.Close();
            //    MessageBox.Show("Something went wrong.", "Restoration Failed");
            //}
        }
    }
}