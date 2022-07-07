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
        public List<DataClass> DataClass { get; set; }
        public Form3()
        {
            DataClass = GetData();
            InitializeComponent();
        }
        private List<DataClass> GetData()
        {
            var list = new List<DataClass>();
            list.Add(new DataClass()
            {
                Machine_Type = "Tractor",
                Year_Built = "1978",
                Date_Donated = "05/05/2005",
                Description = "It's a Tractor",
                Maintenence_Information = "Put petrol in it",
                Model = "Messy Fingerson",
                Machine_Location = "Workshop",
                Restoration_Status = "Scrapped",
                Link_To_Tractor = "https//website.com"
            });

            return list;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var DataClass = this.DataClass;
            dataGridView1.DataSource = DataClass;
            dataGridView1.Columns["Date_Donated"].Visible = false;
            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["Maintenence_Information"].Visible = false;
            dataGridView1.Columns["Horse_Power"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
