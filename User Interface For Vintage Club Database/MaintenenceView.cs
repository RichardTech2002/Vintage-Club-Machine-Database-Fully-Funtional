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
    public partial class MaintenenceView : Form
    {
        Form4 f4;
        public MaintenenceView(Form4 f4)
        {
            InitializeComponent();
            this.f4 = f4;   
        }
        Form3 f3;
        public MaintenenceView (Form3 f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }
        string IDstring1;
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public MaintenenceView()
        {
            InitializeComponent();
        }
        private void MaintenenceView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'machine_Database_FixedDataSet3.Maintenence_Information' table. You can move, or remove it, as needed.
            this.maintenence_InformationTableAdapter.Fill(this.machine_Database_FixedDataSet3.Maintenence_Information);
            string SearchBox = ConfigurationManager.ConnectionStrings["SearchString"].ConnectionString;
            SqlConnection SqlSearch = new SqlConnection(SearchBox);
            string SqlQuery = "select * from [dbo].[Maintenence_Information] where ID_Grabber = '" + Form4.id + "'";
            SqlSearch.Open();
            SqlCommand SqlCom = new SqlCommand(SqlQuery, SqlSearch);
            SqlDataAdapter Sqlcord = new SqlDataAdapter(SqlCom);
            DataTable DT = new DataTable();
            Sqlcord.Fill(DT);
            dataGridView1.DataSource = DT;
            SqlSearch.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MaintenenceForm mtnf = new MaintenenceForm();
            mtnf.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    IDstring1 = dataGridView1.Rows[e.RowIndex].Cells["iDGrabberDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    var IDInt1 = Int32.Parse(IDstring1);
                    MainIdTaker.Value = IDInt1;
                }
                MaintenenceFormEditPage mfep = new MaintenenceFormEditPage();
                mfep.Show();
            }
            catch
            {
                MessageBox.Show("You need to click on the data. Not whatever it is you tried to click.", "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
