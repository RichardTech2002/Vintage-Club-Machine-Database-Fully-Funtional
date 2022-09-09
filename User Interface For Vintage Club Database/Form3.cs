using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string IdString = "";
        public string conString = "Data Source=LAPTOP-BT59QU4U;Initial Catalog=Machine_Database_Fixed;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'machine_Database_FixedDataSet4.General_Table' table. You can move, or remove it, as needed.
            this.general_TableTableAdapter.Fill(this.machine_Database_FixedDataSet4.General_Table);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string SearchBox = ConfigurationManager.ConnectionStrings["SearchString"].ConnectionString;
            SqlConnection SqlSearch = new SqlConnection(SearchBox);
            string SqlQuery = "select * from [dbo].[General_Table] where Machine_Type like '" + textBox1.Text + "%'" + "Or [ID] like '" + textBox1.Text + "%'" + "Or [Year_Built] like '" + textBox1.Text + "%'" + "Or [Model] like '" + textBox1.Text + "%'" + "Or [Make] like '" + textBox1.Text + "%'" + "Or [Original_Owner] like '" + textBox1.Text + "%'" + "Or [Machine_Location] like '" + textBox1.Text + "%'" + "Or [Restoration_Status] like '" + textBox1.Text + "%'";
            SqlSearch.Open();
            SqlCommand SqlCom = new SqlCommand(SqlQuery, SqlSearch);
            SqlDataAdapter Sqlcord = new SqlDataAdapter(SqlCom);
            DataTable DT = new DataTable();
            Sqlcord.Fill(DT);
            dataGridView1.DataSource = DT;
            SqlSearch.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    IdString = dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn14"].FormattedValue.ToString();
                    var IDInt = Int32.Parse(IdString);
                    Form3IDTaker.Value = IDInt;
                }
                //Open Form 4 data editing page

                Form4 f4 = new Form4(this);
                f4.ShowDialog();
                this.Close();
            }

            catch
            {
                MessageBox.Show("You need to click on the data. Not whatever it is you tried to click.", "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}

