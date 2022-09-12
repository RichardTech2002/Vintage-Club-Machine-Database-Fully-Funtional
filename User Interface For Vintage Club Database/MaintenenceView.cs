using DatabaseProject;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public MaintenenceView(Form3 f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public MaintenenceView()
        {
            InitializeComponent();
        }
        private void MaintenenceView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'machine_Database_FixedDataSet5.Maintenence_Information' table. You can move, or remove it, as needed.
            this.maintenence_InformationTableAdapter.Fill(this.machine_Database_FixedDataSet5.Maintenence_Information);
            // TODO: This line of code loads data into the 'machine_Database_FixedDataSet5.Maintenence_Information' table. You can move, or remove it, as needed.
            this.maintenence_InformationTableAdapter1.Fill(this.machine_Database_FixedDataSet5.Maintenence_Information);
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
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MaintenenceForm mtnf = new MaintenenceForm();
            mtnf.ShowDialog();
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
                    IDstring1.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                    var IDInt1 = Int32.Parse(IDstring1.Text);
                    MainIdTaker.Value = IDInt1;
                }
                MaintenenceFormEditPage mtnfp = new MaintenenceFormEditPage();
                mtnfp.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Something went wrong. The data cannot be accessed at the moment. Or you clicked the header!", "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
