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
    public partial class MaintenenceForm : Form
    {
        public MaintenenceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintenenceView mtnv = new MaintenenceView();
            mtnv.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker1.Enabled = true;
            textBox1.Visible = false;
            textBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            dateTimePicker1.Enabled = false;
            textBox1.Visible = true;
            textBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
