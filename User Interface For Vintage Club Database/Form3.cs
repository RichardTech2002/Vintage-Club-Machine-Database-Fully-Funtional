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
using System.IO;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=LAPTOP-BT59QU4U;Initial Catalog=Vintage_Database;Integrated Security=True";

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'machine_DatabaseDataSet.General_Table' table. You can move, or remove it, as needed.
            this.general_TableTableAdapter.Fill(this.machine_DatabaseDataSet.General_Table);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
