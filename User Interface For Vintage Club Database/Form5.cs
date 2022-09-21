using DatabaseProject;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class Form5 : Form
    {
        public static string ID, BasicTitle, Date, WhoBy, MaintenanceInformation, IDGrabber, AutoManual;

        Form4 f4;
        Form3 f3;
        public Form5(Form4 f4)
        {
            InitializeComponent();
            this.f4 = f4;
        }
        public Form5(Form3 f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }
        public Form5()
        {
            InitializeComponent();
        }

        public string IDBox;
        public string BasicTitleBox;
        public string DateBox;
        public string WhoByBox;
        public string MaintenenceInformationBox;
        public string IDGrabberBox;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string AutoManualBox;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        private void MaintenenceView_Load(object sender, EventArgs e)
        {
            this.maintenence_InformationTableAdapter.Fill(this.machine_Database_FixedDataSet5.Maintenence_Information);
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        } 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    IDStringView.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                    BasicTitleView.Text = dataGridView1.Rows[e.RowIndex].Cells["basicTitleDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    DateView.Text = dataGridView1.Rows[e.RowIndex].Cells["dateDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    WhoByView.Text = dataGridView1.Rows[e.RowIndex].Cells["whoByDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    IDGrabberView.Text = dataGridView1.Rows[e.RowIndex].Cells["iDGrabberDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    MechInfoView.Text = dataGridView1.Rows[e.RowIndex].Cells["maintenenceInformationDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    AutoManualView.Text = dataGridView1.Rows[e.RowIndex].Cells["autoManualDataGridViewTextBoxColumn"].FormattedValue.ToString();

                    IDBox = IDStringView.Text;
                    BasicTitleBox = BasicTitleView.Text;
                    DateBox = DateView.Text;
                    WhoByBox = WhoByView.Text;
                    IDGrabberBox = IDGrabberView.Text;
                    MaintenenceInformationBox = MechInfoView.Text;
                    AutoManualBox = AutoManualView.Text;

                    IDValueView.Value = Int32.Parse(IDStringView.Text);
                }
                Form7 f7 = new Form7(IDValueView.Value.ToString());
                f7.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Something went wrong. The data cannot be accessed at the moment. Or you clicked the header!", "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
