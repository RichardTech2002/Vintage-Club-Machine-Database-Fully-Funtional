using DatabaseProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class MaintenenceFormEditPage : Form

    {
        MaintenenceView mtn;
        public MaintenenceFormEditPage(MaintenenceView mtn)
        {
            InitializeComponent();
            this.mtn = mtn;
        }

        public MaintenenceFormEditPage()
        {
            InitializeComponent();
        }

        public static string ID, BasicTitle, Date, WhoBy, MaintenanceInformation, IDGrabber;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        private void MaintenenceFormEditPage_Load(object sender, EventArgs e)
        {
            MainIdTaker.Value = 1021;
            textBox3.Text = Form4.Machine_Type;
            textBox4.Text = Form4.Year_Built;
            textBox5.Text = Form4.Make;
            textBox6.Text = Form4.Model;

            string DateManual = textBox1.Text;
            string DateAutomatic = dateTimePicker1.Text;
            if (MainIdTaker.Value != 0)
            {
                string query = "Select ID, Date, Basic_Title, Who_By, Maintenence_Information, ID_Grabber, AutoManual from Maintenence_Information where ID = '" + MainIdTaker.Value + "'";
                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    ID = dtUsers.Rows[0]["ID"].ToString();
                    BasicTitle = dtUsers.Rows[0]["Basic_Title"].ToString();
                    Date = dtUsers.Rows[0]["Date"].ToString();
                    WhoBy = dtUsers.Rows[0]["Who_By"].ToString();
                    MaintenanceInformation = dtUsers.Rows[0]["Maintenence_Information"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsFormEdited.Text == "No")
            {
                this.Hide();
            }
            else
            {
                DialogResult ExitCheck = MessageBox.Show("There are unsaved changes. Would you like to continiue?", "Check the form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult DeleteData = MessageBox.Show("Are you sure you want to delete this row? This can only be brought back if you have a backup. It is otherwise removed entirely from the database.", "Delete Row", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == DeleteData)
            {
                SqlConnection Deleteconn = new SqlConnection("Data Source=LAPTOP-BT59QU4U;Initial Catalog=Machine_Database_Fixed;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                Deleteconn.Open();
                string query = "DELETE from dbo.Maintenence_Information where ID = '" + MainIdTaker.Value + "'";
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
            IsFormEdited.Text = "No";
            string UpdatedDate = textBox1.Text;
            string UpdatedBasic_Title = textBox7.Text;
            string UpdatedWho_By = textBox2.Text;
            string UpdatedMaintenence_Information = richTextBox1.Text;

            string query = "Update General_Table SET Date = '" + @UpdatedDate + "', Basic_Title = " + @UpdatedBasic_Title + "', Who_By = " + @UpdatedWho_By + "', Maintenence_Information = " + @UpdatedMaintenence_Information + "'Where ID = '" + MainIdTaker.Value + "'";

            SqlCommand updatecommand = new SqlCommand(query);

            updatecommand.Parameters.AddWithValue("@Date", UpdatedDate);
            updatecommand.Parameters.AddWithValue("@Basic_Title", UpdatedBasic_Title);
            updatecommand.Parameters.AddWithValue("@Who_By", UpdatedWho_By);
            updatecommand.Parameters.AddWithValue("@Maintenence_Information", UpdatedMaintenence_Information);

            int row = objDBAccess.executeQuery(updatecommand);

            MessageBox.Show("Maintenance Details Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            IsFormEdited.Text = "Yes";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            IsFormEdited.Text = "Yes";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            IsFormEdited.Text = "Yes";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            IsFormEdited.Text = "Yes";
        }
    }
}
