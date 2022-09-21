using DatabaseProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class Form7 : Form
    {
        public Form7(string XYZ)
        {
            InitializeComponent();
            numericUpDown1.Value = Int32.Parse(XYZ);
        }

        public string xyz { get; set; }

        public static string ID, BasicTitle, Date, WhoBy, MaintenanceInformation, IDGrabber, AutoManual;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        private void MaintenenceFormEditPage_Load(object sender, EventArgs e)
        {
            textBox3.Text = Form4.Machine_Type;
            textBox4.Text = Form4.Year_Built;
            textBox5.Text = Form4.Make;
            textBox6.Text = Form4.Model;

            if (numericUpDown1.Value != 0)
            {
                string query = "Select ID, Date, Basic_Title, Who_By, Maintenence_Information, ID_Grabber, AutoManual from dbo.Maintenence_Information where ID = '" + numericUpDown1.Value + "'";

                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    ID = dtUsers.Rows[0]["ID"].ToString();
                    BasicTitle = dtUsers.Rows[0]["Basic_Title"].ToString();
                    Date = dtUsers.Rows[0]["Date"].ToString();
                    WhoBy = dtUsers.Rows[0]["Who_By"].ToString();
                    MaintenanceInformation = dtUsers.Rows[0]["Maintenence_Information"].ToString();
                    AutoManual = dtUsers.Rows[0]["AutoManual"].ToString();
                    AutoManual1.Text = AutoManual;

                    if(AutoManual1.Text == "Auto")
                    {
                        radioButton1.Checked = true;
                        textBox1.Visible = false;
                        dateTimePicker1.Visible = true;
                        dateTimePicker1.Text = Date;
                        textBox7.Text = BasicTitle;
                        textBox2.Text = WhoBy;
                        richTextBox1.Text = MaintenanceInformation;
                    }
                    if(AutoManual1.Text == "Manual")
                    {
                        radioButton2.Checked = true;
                        textBox1.Visible = true;
                        dateTimePicker1.Visible = false;
                        textBox1.Text = Date;
                        textBox7.Text = BasicTitle;
                        textBox2.Text = WhoBy;
                        richTextBox1.Text = MaintenanceInformation;
                    }

                    objDBAccess.closeConn();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsFormEdited.Text == "No")
            {
                this.Hide();
            }
            else if(IsFormEdited.Text == "Yes")
            {
                DialogResult ExitCheck = MessageBox.Show("Would you like to exit the editing page? Any unsaved changes will be undone.", "Would you like to exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ExitCheck == DialogResult.Yes)
                {
                    IsFormEdited.Text = "No";
                    this.Hide();
                }
                else
                {
                    //Do Nothing
                }
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult DeleteData = MessageBox.Show("Are you sure you want to delete this row? This can only be brought back if you have a backup. It is otherwise removed entirely from the database.", "Delete Row", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == DeleteData)
            {
                SqlConnection Deleteconn = new SqlConnection("Data Source=LAPTOP-BT59QU4U;Initial Catalog=Machine_Database_Fixed;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                Deleteconn.Open();
                string query = "DELETE from dbo.Maintenence_Information where ID = '" + numericUpDown1.Value + "'";
                SqlCommand deletecommand1 = new SqlCommand(query, Deleteconn);

                int row = deletecommand1.ExecuteNonQuery();

                if (row == 1)
                {
                    DialogResult Submit = MessageBox.Show("This data has now been deleted. Going back to the Maintenance Information Page now!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Deleteconn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (DialogResult.Cancel == DeleteData)
            {
                //Do Nothing
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
            if (radioButton1.Checked == true)
            {
                IsFormEdited.Text = "No";
                string UpdatedDate = dateTimePicker1.Text;
                string UpdatedBasic_Title = textBox7.Text;
                string UpdatedWho_By = textBox2.Text;
                string UpdatedMaintenence_Information = richTextBox1.Text;
                string UpdatedAutoManual = AutoManual1.Text;

                string query = "Update Maintenence_Information SET Date = '" + @UpdatedDate + "', Basic_Title = '" + @UpdatedBasic_Title + "', Who_By = '" + @UpdatedWho_By + "', Maintenence_Information = '" + @UpdatedMaintenence_Information + "', AutoManual = '" + @UpdatedAutoManual + "' Where ID = '" + numericUpDown1.Value + "'";

                SqlCommand updatecommand = new SqlCommand(query);

                updatecommand.Parameters.AddWithValue("@Date", UpdatedDate);
                updatecommand.Parameters.AddWithValue("@Basic_Title", UpdatedBasic_Title);
                updatecommand.Parameters.AddWithValue("@Who_By", UpdatedWho_By);
                updatecommand.Parameters.AddWithValue("@Maintenence_Information", UpdatedMaintenence_Information);
                updatecommand.Parameters.AddWithValue("@AutoManual", UpdatedAutoManual);

                int row = objDBAccess.executeQuery(updatecommand);

                if (row == 1)
                {
                    DialogResult Submit = MessageBox.Show("Information successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(radioButton2.Checked == true)
            {
                IsFormEdited.Text = "No";
                string UpdatedDate = dateTimePicker1.Text;
                string UpdatedBasic_Title = textBox7.Text;
                string UpdatedWho_By = textBox2.Text;
                string UpdatedMaintenence_Information = richTextBox1.Text;
                string UpdatedAutoManual = AutoManual1.Text;

                string query = "Update Maintenence_Information SET Date = '" + @UpdatedDate + "', Basic_Title = '" + @UpdatedBasic_Title + "', Who_By = '" + @UpdatedWho_By + "', Maintenence_Information = '" + @UpdatedMaintenence_Information + "', AutoManual = '" + @UpdatedAutoManual + "' Where ID = '" + numericUpDown1.Value + "'";

                SqlCommand updatecommand = new SqlCommand(query);

                updatecommand.Parameters.AddWithValue("@Date", UpdatedDate);
                updatecommand.Parameters.AddWithValue("@Basic_Title", UpdatedBasic_Title);
                updatecommand.Parameters.AddWithValue("@Who_By", UpdatedWho_By);
                updatecommand.Parameters.AddWithValue("@Maintenence_Information", UpdatedMaintenence_Information);
                updatecommand.Parameters.AddWithValue("@AutoManual", UpdatedAutoManual);

                int row = objDBAccess.executeQuery(updatecommand);

                if (row == 1)
                {
                    DialogResult Submit = MessageBox.Show("Information successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            IsFormEdited.Text = "Yes";
        }
    }
}
