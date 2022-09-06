using DatabaseProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class MaintenenceForm : Form
    {
        Form4 f4;
        public MaintenenceForm(Form4 f4)
        {
            InitializeComponent();
            this.f4 = f4;
        }

        Form3 f3;
        public MaintenenceForm(Form3 f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }

        public MaintenenceForm()
        {
            InitializeComponent();
        }

        MaintenenceView mtnv;
        public MaintenenceForm(MaintenenceView mtnv)
        {
            InitializeComponent();
            this.mtnv = mtnv;
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public static string Machine_Type, Year_Built, Make, Model;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" && textBox2.Text == "" && richTextBox1.Text == "")
            {
                this.Hide();
            }
            else
            {
                DialogResult SaveExit = MessageBox.Show("Maintenence Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (SaveExit == DialogResult.OK)
                {
                    SqlCommand insertcommand = new SqlCommand("insert into Maintenence_Information(Date, Basic_Title, Who_By, Maintenence_Information, Id_Grabber ) values (@Date, @Basic_Title, @Who_By, @Maintenence_Information,@ID_Grabber)");

                    if (radioButton1.Checked)
                    {
                        insertcommand.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                        insertcommand.Parameters.AddWithValue("@Basic_Title", textBox7.Text);
                        insertcommand.Parameters.AddWithValue("@Who_By", textBox2.Text);
                        insertcommand.Parameters.AddWithValue("@Maintenence_Information", richTextBox1.Text);
                        insertcommand.Parameters.AddWithValue("@ID_Grabber", numericUpDown1.Value);

                    }
                    if (radioButton2.Checked)
                    {
                        if (textBox1.Text == "")
                        {
                            insertcommand.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                            insertcommand.Parameters.AddWithValue("@Basic_Title", textBox7.Text);
                            insertcommand.Parameters.AddWithValue("@Who_By", textBox2.Text);
                            insertcommand.Parameters.AddWithValue("@Maintenence_Information", richTextBox1.Text);
                            insertcommand.Parameters.AddWithValue("@ID_Grabber", numericUpDown1.Value);
                        }
                        else
                        {
                            insertcommand.Parameters.AddWithValue("@Date", textBox1.Text);
                            insertcommand.Parameters.AddWithValue("@Basic_Title", textBox7.Text);
                            insertcommand.Parameters.AddWithValue("@Who_By", textBox2.Text);
                            insertcommand.Parameters.AddWithValue("@Maintenence_Information", richTextBox1.Text);
                            insertcommand.Parameters.AddWithValue("@ID_Grabber", numericUpDown1.Value);
                        }
                    }


                    int row = objDBAccess.executeQuery(insertcommand);

                    //Exit the form part.

                    MaintenenceView mtnv = new MaintenenceView();
                    mtnv.Show();
                    this.Close();
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label8.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            PrintDialog pdl = new PrintDialog();
            if (pdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button1.Visible = true;
                button2.Visible = true;
                label8.Visible = false;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
            else
            {
                label8.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
        }

        private void MaintenenceForm_Load(object sender, EventArgs e)
        {
            textBox3.Text = Form4.Machine_Type;
            textBox4.Text = Form4.Year_Built;
            textBox5.Text = Form4.Make;
            textBox6.Text = Form4.Model;
            numericUpDown1.Value = Int32.Parse(Form4.id);
        }
    }
}
