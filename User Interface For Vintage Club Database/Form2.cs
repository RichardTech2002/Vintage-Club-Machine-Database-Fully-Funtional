using DatabaseProject;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace User_Interface_For_Vintage_Club_Database
{
    public partial class Form2 : Form
    {
        DBAccess objDBAccess = new DBAccess();
        string ImageLocation1 = @"E:\Database General Folder\No Image Icon.jpg";
        string ImageLocation2 = @"E:\Database General Folder\No Image Icon.jpg";
        public byte[] img1;
        public byte[] img2;

        public Form2()
        {
            InitializeComponent();
        }

        public int Duh = 0;

        public void ShowMessageBox()
        {
            DialogResult msg = MessageBox.Show("There are empty fields! Would you like to continue?", "Empty Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Duh = 0;

            if (msg == DialogResult.OK)
            {
                Duh = 0;
                MessageBoxDisplay.Text = "No";
            }
            if (msg == DialogResult.Cancel)
            {
                Duh = 0;
                IfFormEmpty();
            }
        }



        public void ColourReset()
        {
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
            label8.BackColor = Color.White;
            label9.BackColor = Color.White;
            label10.BackColor = Color.White;
            label12.BackColor = Color.White;
            label13.BackColor = Color.White;
            label14.BackColor = Color.White;
            button3.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox2.BackColor = Color.LightGray;
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
                Duh++;
            }
            if (pictureBox1.Image == null)
            {
                MessageBoxDisplay.Text = "Yes";
            }
            if (numericUpDown1.Value == 0)
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (textBox5.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (textBox6.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
            if (richTextBox3.Text == "")
            {
                MessageBoxDisplay.Text = "Yes";
                Duh++;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ColourReset();
            try
            {
                OpenFileDialog Dialog = new OpenFileDialog();
                Dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png) |*.png";

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

        private void button3_Click_1(object sender, EventArgs e)
        {
            ColourReset();
            try
            {
                OpenFileDialog Dialog = new OpenFileDialog();
                Dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png) |*.png";

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

        public void ClearBoxes()
        {
            MessageBoxDisplay.Text = "No";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            textBox1.SelectedItem = null;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
            richTextBox3.Text = "";
            numericUpDown1.Value = 0;
            pictureBox1.ImageLocation = @"E:\Database General Folder\No Image Icon.jpg";
            pictureBox2.ImageLocation = @"E:\Database General Folder\No Image Icon.jpg";
        }



        public void IfFormEmpty()
        {
            if (textBox1.Text == "")
            {
                label1.BackColor = Color.Red;
            }
            if (textBox2.Text == "")
            {
                label2.BackColor = Color.Red;
            }
            if (textBox3.Text == "")
            {
                label3.BackColor = Color.Red;
                label6.BackColor = Color.Red;
            }
            if (textBox4.Text == "")
            {
                label4.BackColor = Color.Red;
            }
            if (richTextBox1.Text == "")
            {
                label5.BackColor = Color.Red;
            }
            if (textBox5.Text == "")
            {
                label13.BackColor = Color.Red;
            }
            if (textBox6.Text == "")
            {
                label7.BackColor = Color.Red;
            }
            if (comboBox1.Text == "")
            {
                label8.BackColor = Color.Red;
            }
            if (comboBox2.Text == "")
            {
                label9.BackColor = Color.Red;
            }
            if (comboBox3.Text == "")
            {
                label10.BackColor = Color.Red;
            }
            if (numericUpDown1.Value == 0)
            {
                label12.BackColor = Color.Red;
            }
            if (richTextBox3.Text == "")
            {
                label14.BackColor = Color.Red;
            }
            if (pictureBox1.ImageLocation == @"E:\Database General Folder\No Image Icon.jpg")
            {
                pictureBox1.BackColor = Color.Red;
            }
            if (pictureBox2.ImageLocation == @"E:\Database General Folder\No Image Icon.jpg")
            {
                pictureBox2.BackColor = Color.Red;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Duh = 0;
            MessageBoxDisplay.Text = "No";
            BoxChecker();


            if (Duh == 13)
            {
                DialogResult Blank = MessageBox.Show("You didn't even fill out any of the boxes, you old fool!", "Empty Boxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Blank == DialogResult.OK)
                {
                    Duh = 0;
                    ColourReset();
                }
            }
            else if (Duh > 13)
            {
                DialogResult DoubleCheck = MessageBox.Show("This form is not complete. Are you sure you want to submit this data how it is? Remember you can change it later.", "Incomplete Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DoubleCheck == DialogResult.OK)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "N/A";
                    }
                    if (textBox2.Text == "")
                    {
                        textBox2.Text = "N/A";
                    }
                    if (textBox3.Text == "")
                    {
                        textBox3.Text = "N/A";
                    }
                    if (textBox4.Text == "")
                    {
                        textBox4.Text = "N/A";
                    }
                    if (comboBox1.Text == "")
                    {
                        comboBox1.Text = "N/A";
                    }
                    if (comboBox2.Text == "")
                    {
                        comboBox2.Text = "N/A";
                    }
                    if (comboBox3.Text == "")
                    {
                        comboBox3.Text = "N/A";
                    }
                    if (richTextBox1.Text == "")
                    {
                        richTextBox1.Text = "N/A";
                    }
                    if (textBox5.Text == "")
                    {
                        textBox5.Text = "N/A";
                    }
                    if (textBox6.Text == "")
                    {
                        textBox6.Text = "N/A";
                    }
                    if (richTextBox3.Text == "")
                    {
                        richTextBox3.Text = "N/A";
                    }

                    SqlCommand insertcommand = new SqlCommand("insert into General_Table(Machine_Type, Year_Built, Original_Owner, Date_Acquired, Description, Machine_Location, Restoration_Status, Donated_Or_Loaned, Link_To_TractorData, Model, Make, Other_Notes, Image, SecondImage, IfSold ) values (@Machinetype, @YearBuilt, @OriginalOwner, @DateAcquired, @Description, @MachineLocation, @RestorationStatus, @DonatedOrLoaned, @LinkToTractorData, @Model, @Make, @Other_Notes, @Image, @SecondImage, @IfSold)");

                    byte[] img1 = null;
                    FileStream fs1 = new FileStream(ImageLocation1, FileMode.Open, FileAccess.Read);
                    BinaryReader br1 = new BinaryReader(fs1);
                    img1 = br1.ReadBytes((int)fs1.Length);
                    insertcommand.Parameters.AddWithValue("@Image", img1);

                    byte[] img2 = null;
                    FileStream fs2 = new FileStream(ImageLocation2, FileMode.Open, FileAccess.Read);
                    BinaryReader br2 = new BinaryReader(fs2);
                    img2 = br2.ReadBytes((int)fs2.Length);
                    insertcommand.Parameters.AddWithValue("@SecondImage", img2);

                    insertcommand.Parameters.AddWithValue("@MachineType", textBox1.Text);
                    insertcommand.Parameters.AddWithValue("@YearBuilt", numericUpDown1.Value);
                    insertcommand.Parameters.AddWithValue("@OriginalOwner", textBox2.Text);
                    insertcommand.Parameters.AddWithValue("@DateAcquired", textBox3.Text);
                    insertcommand.Parameters.AddWithValue("@Description", richTextBox1.Text);
                    insertcommand.Parameters.AddWithValue("@RestorationStatus", comboBox1.Text);
                    insertcommand.Parameters.AddWithValue("@MachineLocation", comboBox2.Text);
                    insertcommand.Parameters.AddWithValue("@DonatedOrLoaned", comboBox3.Text);
                    insertcommand.Parameters.AddWithValue("@LinkToTractorData", textBox4.Text);
                    insertcommand.Parameters.AddWithValue("@Model", textBox5.Text);
                    insertcommand.Parameters.AddWithValue("@Make", textBox6.Text);
                    insertcommand.Parameters.AddWithValue("@Other_Notes", richTextBox3.Text);
                    insertcommand.Parameters.AddWithValue("@IfSold", textBox7.Text);

                    int row = objDBAccess.executeQuery(insertcommand);

                    MessageBox.Show("Information saved to the database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBoxes();
                }
                else
                {
                    IfFormEmpty();
                }
            }
            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into General_Table(Machine_Type, Year_Built, Original_Owner, Date_Acquired, Description, Machine_Location, Restoration_Status, Donated_Or_Loaned, Link_To_TractorData, Model, Make, Other_Notes, Image, SecondImage, IfSold ) values (@Machinetype, @YearBuilt, @OriginalOwner, @DateAcquired, @Description, @MachineLocation, @RestorationStatus, @DonatedOrLoaned, @LinkToTractorData, @Model, @Make, @Other_Notes, @Image, @SecondImage, @IfSold)");

                byte[] img1 = null;
                FileStream fs1 = new FileStream(ImageLocation1, FileMode.Open, FileAccess.Read);
                BinaryReader br1 = new BinaryReader(fs1);
                img1 = br1.ReadBytes((int)fs1.Length);

                byte[] img2 = null;
                FileStream fs2 = new FileStream(ImageLocation2, FileMode.Open, FileAccess.Read);
                BinaryReader br2 = new BinaryReader(fs2);
                img2 = br2.ReadBytes((int)fs2.Length);

                insertcommand.Parameters.AddWithValue("@MachineType", textBox1.Text);
                insertcommand.Parameters.AddWithValue("@YearBuilt", numericUpDown1.Value);
                insertcommand.Parameters.AddWithValue("@OriginalOwner", textBox2.Text);
                insertcommand.Parameters.AddWithValue("@DateAcquired", textBox3.Text);
                insertcommand.Parameters.AddWithValue("@Description", richTextBox1.Text);
                insertcommand.Parameters.AddWithValue("@RestorationStatus", comboBox1.Text);
                insertcommand.Parameters.AddWithValue("@MachineLocation", comboBox2.Text);
                insertcommand.Parameters.AddWithValue("@DonatedOrLoaned", comboBox3.Text);
                insertcommand.Parameters.AddWithValue("@LinkToTractorData", textBox4.Text);
                insertcommand.Parameters.AddWithValue("@Model", textBox5.Text);
                insertcommand.Parameters.AddWithValue("@Make", textBox6.Text);
                insertcommand.Parameters.AddWithValue("@Other_Notes", richTextBox3.Text);
                insertcommand.Parameters.AddWithValue("@IfSold", textBox7.Text);
                insertcommand.Parameters.AddWithValue("@Image", img1);
                insertcommand.Parameters.AddWithValue("@SecondImage", img2);

                int row = objDBAccess.executeQuery(insertcommand);

                //---------------------------------MessageBox Validation Logic Gate------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                if (row == 1)
                {
                    DialogResult Submit = MessageBox.Show("Information Submitted to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBoxes();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearBoxes();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Duh = 0;
            MessageBoxDisplay.Text = "No";
            BoxChecker();
            if (Duh != 0)
            {
                if (Duh == 13)
                {
                    Duh = 0;
                    this.Close();
                }
                if (Duh > 0)
                {
                    if (Duh < 13)
                    {
                        DialogResult msg1 = MessageBox.Show("This form is incomplete. If you go back now, you will need to fill out the form again. Would you like to continue?", "Incomplete Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (msg1 == DialogResult.OK)
                        {
                            Duh = 0;
                            this.Hide();
                        }
                        else
                        {
                            Duh = 0;
                        }
                    }
                }
            }
        }

        //---------------------------------End Of Button Logic-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void button3_Click(object sender, EventArgs e)
        {
            string ImageLocation = "";
            try
            {
                OpenFileDialog Dialog = new OpenFileDialog();
                Dialog.Filter = "PNG files(*.png) |*.png|jpg files(*.jpg)|*.jpg";

                if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (pictureBox1.Image == null)
                    {
                        MessageBox.Show("That doesn't look like an image to me...", "Incorrect file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ImageLocation = Dialog.FileName;
                        pictureBox1.ImageLocation = ImageLocation;
                    }
                }
            }
            catch
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void richTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void textBox1_MouseHover_1(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void comboBox3_MouseHover(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            ColourReset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MaintenenceForm mtnf = new MaintenenceForm();
            mtnf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                DialogResult dlgpic1 = MessageBox.Show("Would you like to remove this image?", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgpic1 == DialogResult.Yes)
                {
                    pictureBox1.ImageLocation = @"E:\Database General Folder\No Image Icon.jpg";
                    Duh -= 1;
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
                    pictureBox1.ImageLocation = @"E:\Database General Folder\No Image Icon.jpg";
                    Duh -= 1;
                }
                else
                {
                    //Do Nothing
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void richTextBox3_Click(object sender, EventArgs e)
        {
            ColourReset();
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {

        }
    }
}
