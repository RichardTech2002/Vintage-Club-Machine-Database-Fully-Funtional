using DatabaseProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class Form4 : Form
    {
        Form3 f3;
        public Form4(Form3 f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }

        public Form4()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public static string id, Machine_Type, Year_Built, Original_Owner, Date_Acquired, Description, Maintenence_Information, Machine_Location, Restoration_Status, Donated_Or_Loaned, Link_To_TractorData, Model, Make, Other_Notes, IfSold, FileLocation1, FileLocation2, FileLocation3;
        string ImageLocation1 = @"E:\Database General Folder\No Image Icon.jpg";
        string ImageLocation2 = @"E:\Database General Folder\No Image Icon.jpg";
        string ImageLocation3 = @"E:\Database General Folder\No Image Icon.jpg";

        private void button2_Click(object sender, EventArgs e)
        {
            if (MenuLock.Text == "Locked")
            {
                DialogResult dlg1 = MessageBox.Show("This is currently in edit mode. Any changes that you may have done will not been saved unless you press the save button. If you back out now, you will need to re-do any changes you made. Would you like to continue?", "Edit Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg1 == DialogResult.Yes)
                {
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else
                {
                    //Do Nothing
                }
            }
            else
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Dialog = new OpenFileDialog();
                Dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png) |*.png";

                if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageLocation3 = Dialog.FileName;
                    pictureBox3.ImageLocation = ImageLocation3;
                }
            }
            catch
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox4.Text);
            MessageBox.Show("Link Copied! Click on Google search bar and then press CTRL and V at the same time to put the link into your browser.", "Link Copied");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                DialogResult dlgpic1 = MessageBox.Show("Would you like to remove this image?", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgpic1 == DialogResult.Yes)
                {
                    pictureBox1.ImageLocation = @"E:\Database General Folder\No Image Icon.jpg";
                }
                else
                {
                    //Do Nothing
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2 != null)
            {
                DialogResult dlgpic2 = MessageBox.Show("Would you like to remove this image?", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgpic2 == DialogResult.Yes)
                {
                    pictureBox2.ImageLocation = @"E:\Database General Folder\No Image Icon.jpg";
                }
                else
                {
                    //Do Nothing
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3 != null)
            {
                DialogResult dlgpic3 = MessageBox.Show("Would you like to remove this image?", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgpic3 == DialogResult.Yes)
                {
                    pictureBox3.ImageLocation = @"E:\Database General Folder\No Image Icon.jpg";
                }
                else
                {
                    //Do Nothing
                }
            }
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



        private void button1_Click(object sender, EventArgs e)
        {
            MenuLock.Text = "Unlocked";
            button1.Visible = false;
            button1.Enabled = false;
            button4.Visible = true;
            button4.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            richTextBox1.Enabled = false;
            richTextBox3.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            numericUpDown1.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            comboBox4.Enabled = false;
            button9.Enabled = false;

            //Update the data

            string UpdatedMachineType = textBox1.Text;
            string UpdatedYearBuilt = numericUpDown1.Value.ToString();
            string UpdatedOriginal_Owner = textBox2.Text;
            string UpdatedDateAcquired = textBox3.Text;
            string UpdatedLinkToTractordata = textBox4.Text;
            string UpdatedModel = textBox5.Text;
            string UpdatedMake = textBox6.Text;
            string UpdatedDescription = richTextBox1.Text;
            string UpdatedOtherInformation = richTextBox3.Text;
            string UpdatedRestorationStatus = comboBox1.Text;
            string UpdatedDisplayLocation = comboBox2.Text;
            string UpdatedDonatedOrLoaned = comboBox3.Text;
            string UpdatedIfSold = comboBox4.Text;
            string UpdatedFileLocation1 = ImageLocation1.ToString();
            string UpdatedFileLocation2 = ImageLocation2.ToString();
            string UpdatedFileLocation3 = ImageLocation3.ToString();

            string query = "Update General_Table SET Machine_Type = '" + @UpdatedMachineType + "', Year_Built = '" + @UpdatedYearBuilt + "', Original_Owner = '" + @UpdatedOriginal_Owner + "', Date_Acquired = '" + @UpdatedDateAcquired + "', Link_To_Tractordata = '" + @UpdatedLinkToTractordata + "', Description = '" + @UpdatedDescription + "', Make = '" + @UpdatedMake + "', Model = '" + @UpdatedModel + "', Restoration_Status = '" + @UpdatedRestorationStatus + "', Machine_Location = '" + @UpdatedDisplayLocation + "', Donated_Or_Loaned = '" + @UpdatedDonatedOrLoaned + "', IfSold = '" + @UpdatedIfSold + "', Other_Notes = '" + @UpdatedOtherInformation + "',FileLocation1 = '" + @UpdatedFileLocation1 + "',FileLocation2 = '" + @UpdatedFileLocation2 + "', FileLocation3 = '" + @UpdatedFileLocation3 + "' Where ID = '" + Form4IDTaker.Value + "'";

            SqlCommand updatecommand = new SqlCommand(query);

            updatecommand.Parameters.AddWithValue("@MachineType", @UpdatedMachineType);
            updatecommand.Parameters.AddWithValue("@YearBuilt", @UpdatedYearBuilt);
            updatecommand.Parameters.AddWithValue("@OriginalOwner", @UpdatedOriginal_Owner);
            updatecommand.Parameters.AddWithValue("@DateAcquired", @UpdatedDateAcquired);
            updatecommand.Parameters.AddWithValue("@Description", @UpdatedDescription);
            updatecommand.Parameters.AddWithValue("@RestorationStatus", @UpdatedRestorationStatus);
            updatecommand.Parameters.AddWithValue("@MachineLocation", @UpdatedDisplayLocation);
            updatecommand.Parameters.AddWithValue("@DonatedOrLoaned", @UpdatedDonatedOrLoaned);
            updatecommand.Parameters.AddWithValue("@Machine_Location", @UpdatedDisplayLocation);
            updatecommand.Parameters.AddWithValue("@LinkToTractorData", @UpdatedLinkToTractordata);
            updatecommand.Parameters.AddWithValue("@Model", @UpdatedModel);
            updatecommand.Parameters.AddWithValue("@Make", @UpdatedMake);
            updatecommand.Parameters.AddWithValue("@Other_Notes", @UpdatedOtherInformation);
            updatecommand.Parameters.AddWithValue("@IfSold", @UpdatedIfSold);
            updatecommand.Parameters.AddWithValue("@FileLocation1", @UpdatedFileLocation1);
            updatecommand.Parameters.AddWithValue("@FileLocation2", @UpdatedFileLocation2);
            updatecommand.Parameters.AddWithValue("@FileLocation3", @UpdatedFileLocation3);

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

        private void button4_Click(object sender, EventArgs e)
        {
            MenuLock.Text = "Locked";
            button4.Visible = false;
            button4.Enabled = false;
            button1.Visible = true;
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            richTextBox1.Enabled = true;
            richTextBox3.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            numericUpDown1.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            comboBox4.Enabled = true;
            button9.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult UpdatedData = MessageBox.Show("Are you sure you want to delete this row? This can only be brought back if you have a backup. It is otherwise removed entirely from the database.", "DELETE ROW", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (DialogResult.OK == UpdatedData)
            {
                SqlConnection Fakeconn = new SqlConnection("Data Source=LAPTOP-BT59QU4U;Initial Catalog=Machine_Database_Fixed;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                Fakeconn.Open();
                string query = "DELETE From General_Table where ID = '" + Form4IDTaker.Value + "'";
                string query1 = "DELETE From Maintenence_Information where ID_Grabber = '" + Form4IDTaker.Value + "'";
                SqlCommand deletecommand = new SqlCommand(query);
                SqlCommand deletecommand1 = new SqlCommand(query1, Fakeconn);
                deletecommand1.ExecuteNonQuery();

                int row = objDBAccess.executeQuery(deletecommand);

                if (row == 1)
                {
                    DialogResult Submit = MessageBox.Show("This Machine/Tool has now been deleted! Going back to the main machine database page now.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Submit == DialogResult.OK)
                    {
                        if (MenuLock.Text == "Locked")
                        {
                            DialogResult dlg2 = MessageBox.Show("We are currently in edit mode. If you back out now, you will need to redo any changes you made. Would you like to continue?", "Edit Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dlg2 == DialogResult.Yes)
                            {
                                this.Hide();
                                Form3 f3 = new Form3();
                                f3.Show();
                            }
                            else
                            {
                                //Do Nothing
                            }
                        }
                        else
                        {
                            this.Hide();
                            Form3 f3 = new Form3();
                            f3.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (DialogResult == DialogResult.OK)
                    {
                        this.Hide();
                    }
                }
            }
            if (DialogResult.Cancel == UpdatedData)
            {
                //Do Nothing
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Form4IDTaker.Value = Int32.Parse(f3.IdString);
            if (Form4IDTaker.Value != 0)
            {
                string query = "Select id, Machine_Type, Year_Built, Original_Owner, Date_Acquired, Description, Maintenence_Information, Machine_Location, Restoration_Status, Donated_Or_Loaned, Link_To_TractorData, Model, Make, Other_Notes, IfSold, FileLocation1, FileLocation2, FileLocation3 from General_Table where Id = '" + Form4IDTaker.Value + "'";
                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    id = dtUsers.Rows[0]["ID"].ToString();
                    Machine_Type = dtUsers.Rows[0]["Machine_Type"].ToString();
                    Year_Built = dtUsers.Rows[0]["Year_Built"].ToString();
                    Original_Owner = dtUsers.Rows[0]["Original_Owner"].ToString();
                    Date_Acquired = dtUsers.Rows[0]["Date_Acquired"].ToString();
                    Description = dtUsers.Rows[0]["Description"].ToString();
                    Maintenence_Information = dtUsers.Rows[0]["Maintenence_Information"].ToString();
                    Machine_Location = dtUsers.Rows[0]["Machine_Location"].ToString();
                    Restoration_Status = dtUsers.Rows[0]["Restoration_Status"].ToString();
                    Donated_Or_Loaned = dtUsers.Rows[0]["Donated_Or_Loaned"].ToString();
                    Link_To_TractorData = dtUsers.Rows[0]["Link_To_TractorData"].ToString();
                    Model = dtUsers.Rows[0]["Model"].ToString();
                    Make = dtUsers.Rows[0]["Make"].ToString();
                    Other_Notes = dtUsers.Rows[0]["Other_Notes"].ToString();
                    IfSold = dtUsers.Rows[0]["IfSold"].ToString();
                    FileLocation1 = dtUsers.Rows[0]["FileLocation1"].ToString();
                    FileLocation2 = dtUsers.Rows[0]["FileLocation2"].ToString();
                    FileLocation3 = dtUsers.Rows[0]["FileLocation3"].ToString();

                    textBox1.Text = Machine_Type;
                    numericUpDown1.Value = Int32.Parse(Year_Built);
                    textBox2.Text = Original_Owner;
                    textBox3.Text = Date_Acquired;
                    richTextBox1.Text = Description;
                    comboBox1.Text = Restoration_Status;
                    comboBox2.Text = Machine_Location;
                    comboBox3.Text = Donated_Or_Loaned;
                    textBox4.Text = Link_To_TractorData;
                    textBox5.Text = Make;
                    textBox6.Text = Model;
                    richTextBox3.Text = Other_Notes;
                    comboBox4.Text = IfSold;
                    ImageLocation1 = FileLocation1;
                    ImageLocation2 = FileLocation2;
                    ImageLocation3 = FileLocation3;
                    pictureBox1.ImageLocation = FileLocation1;
                    pictureBox2.ImageLocation = FileLocation2;
                    pictureBox3.ImageLocation = FileLocation3;

                    objDBAccess.closeConn();
                }
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && richTextBox1.Text == "" && richTextBox3.Text == "" && comboBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text == "" && comboBox4.Text == "" && pictureBox1.ImageLocation == @"E:\Database General Folder\No Image Icon.jpg" && pictureBox2.ImageLocation == @"E:\Database General Folder\No Image Icon.jpg" && pictureBox3.ImageLocation == @"E:\Database General Folder\No Image Icon.jpg")
                {
                    MessageBox.Show("This record has been deleted. Go back to the database page.", "Illegal Entry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Dialog = new OpenFileDialog();
                Dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png) |*.png";

                if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageLocation1 = Dialog.FileName;
                    pictureBox1.ImageLocation = ImageLocation1;
                }
            }
            catch
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Dialog = new OpenFileDialog();
                Dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png) |*.png";

                if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageLocation2 = Dialog.FileName;
                    pictureBox2.ImageLocation = ImageLocation2;
                }
            }
            catch
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this);
            f5.ShowDialog();
        }
    }
}

// If you're reading this, fuck off before you ruin the program!
