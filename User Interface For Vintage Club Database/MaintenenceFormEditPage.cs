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
using System.Configuration;
using DatabaseProject;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class MaintenenceFormEditPage : Form
    {
        public MaintenenceFormEditPage()
        {
            InitializeComponent();
        }
        MaintenenceView mtn;
        public MaintenenceFormEditPage(MaintenenceView mtn)
        {
            InitializeComponent();
            this.mtn = mtn;
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        private void MaintenenceFormEditPage_Load(object sender, EventArgs e)
        {
            textBox3.Text = Form4.Machine_Type;
            textBox4.Text = Form4.Year_Built;
            textBox5.Text = Form4.Make;
            textBox6.Text = Form4.Model;
            MainIdTaker.Value = Int32.Parse(Form4.id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IDval = (int)MainIdTaker.Value;
            DialogResult UpdatedData = MessageBox.Show("Are you sure you want to delete this row? This can only be brought back if you have a backup. It is otherwise removed entirely from the database.", "Delete Row", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == UpdatedData)
            {
                string query = "DELETE From Maintenence_Information where ID == '" + IDval + "'";
                SqlCommand deletecommand = new SqlCommand(query);

                int row = objDBAccess.executeQuery(deletecommand);

                if (row == 1)
                {
                    DialogResult Submit = MessageBox.Show("This Machine/Tool has now been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            if (DialogResult.Cancel == UpdatedData)
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = false;
            dateTimePicker1.Visible = true;
            dateTimePicker1.Enabled = true;
            textBox1.Visible = false;
            textBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = true;
            dateTimePicker1.Visible = false;
            dateTimePicker1.Enabled = false;
            textBox1.Visible = true;
            textBox1.Enabled = true;
        }
    }
}
