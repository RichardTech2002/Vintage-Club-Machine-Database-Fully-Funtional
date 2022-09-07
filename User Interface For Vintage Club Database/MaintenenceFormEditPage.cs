using DatabaseProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            //MainIDTakerMechInfo.Value =
            string BasicTitle = textBox7.Text;
            string DateManual = textBox1.Text;
            string DateAutomatic = dateTimePicker1.Text;
            if(dtUsers.Rows.Count == 1)
            {


                textBox3.Text = Form4.Machine_Type;
                textBox4.Text = Form4.Year_Built;
                textBox5.Text = Form4.Make;
                textBox6.Text = Form4.Model;
                MainIdTaker.Value = Int32.Parse(Form4.id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsFormEdited.Text == "No")
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
            int IDval = (int)MainIdTaker.Value;
            DialogResult UpdatedData = MessageBox.Show("Are you sure you want to delete this row? This can only be brought back if you have a backup. It is otherwise removed entirely from the database.", "Delete Row", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == UpdatedData)
            {
                SqlConnection conn = new SqlConnection("");
                string query = "DELETE From Maintenence_Information where ID == '" + MainIDTakerMechInfo.Value + "'";
                SqlCommand deletecommand = new SqlCommand(query, conn);

                int row = deletecommand.ExecuteNonQuery();

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
