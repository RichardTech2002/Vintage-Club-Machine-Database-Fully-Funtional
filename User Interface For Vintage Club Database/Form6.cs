using DatabaseProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class Form6 : Form
    {
        Form4 f4;
        public Form6(Form4 f4)
        {
            InitializeComponent();
            this.f4 = f4;
        }

        Form3 f3;
        public Form6(Form3 f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }

        public Form6()
        {
            InitializeComponent();
        }

        Form5 f5;
        public Form6(Form5 f5)
        {
            InitializeComponent();
            this.f5 = f5;
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public static string Machine_Type, Year_Built, Make, Model, AutoManual;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" && textBox2.Text == "" && richTextBox1.Text == "")
            {
                this.Hide();
            }
            else
            {
                DialogResult DialogResult = MessageBox.Show("The form isn't complete, would you like to continue?", "Imcomplete Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                {
                    if (DialogResult == DialogResult.Yes)
                    {
                        this.Hide();
                    }
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
            if (textBox7.Text == "" && textBox2.Text == "" && richTextBox1.Text == "")
            {
                MessageBox.Show("Add some data, you moron!", "Empty Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult SaveExit = MessageBox.Show("Maintenence Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (SaveExit == DialogResult.OK)
                {
                    SqlCommand insertcommand = new SqlCommand("insert into Maintenence_Information(Date, Basic_Title, Who_By, Maintenence_Information, Id_Grabber, AutoManual ) values (@Date, @Basic_Title, @Who_By, @Maintenence_Information,@ID_Grabber, @AutoManual)");

                    if (radioButton1.Checked)
                    {
                        insertcommand.Parameters.AddWithValue("@AutoManual", "Auto");
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
                            insertcommand.Parameters.AddWithValue("@AutoManual", "Manual");
                            insertcommand.Parameters.AddWithValue("@Date", textBox1.Text);
                            insertcommand.Parameters.AddWithValue("@Basic_Title", textBox7.Text);
                            insertcommand.Parameters.AddWithValue("@Who_By", textBox2.Text);
                            insertcommand.Parameters.AddWithValue("@Maintenence_Information", richTextBox1.Text);
                            insertcommand.Parameters.AddWithValue("@ID_Grabber", numericUpDown1.Value);
                        }
                        else
                        {
                            insertcommand.Parameters.AddWithValue("@AutoManual", "Manual");
                            insertcommand.Parameters.AddWithValue("@Date", textBox1.Text);
                            insertcommand.Parameters.AddWithValue("@Basic_Title", textBox7.Text);
                            insertcommand.Parameters.AddWithValue("@Who_By", textBox2.Text);
                            insertcommand.Parameters.AddWithValue("@Maintenence_Information", richTextBox1.Text);
                            insertcommand.Parameters.AddWithValue("@ID_Grabber", numericUpDown1.Value);
                        }
                    }


                    int row = objDBAccess.executeQuery(insertcommand);

                    //Exit the form part.

                    Form5 f5 = new Form5();
                    f5.Show();
                    this.Close();
                }
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
//Unused "print" block of code.

//label8.Visible = true;
//button1.Visible = false;
//button2.Visible = false;
//radioButton1.Visible = false;
//radioButton2.Visible = false;
//PrintDialog pdl = new PrintDialog();
//if (pdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
//{
//    button1.Visible = true;
//    button2.Visible = true;
//    label8.Visible = false;
//    radioButton1.Visible = true;
//    radioButton2.Visible = true;
//}
//else
//{
//    label8.Visible = false;
//    button1.Visible = true;
//    button2.Visible = true;
//    radioButton1.Visible = true;
//    radioButton2.Visible = true;
//}