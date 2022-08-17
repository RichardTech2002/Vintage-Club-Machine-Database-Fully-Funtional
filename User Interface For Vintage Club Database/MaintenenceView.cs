using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface_For_Vintage_Club_Database
{
    public partial class MaintenenceView : Form
    {
        public MaintenenceView()
        {
            InitializeComponent();
        }
        public void CreateBox()
        {

        }
        private void MaintenenceView_Load(object sender, EventArgs e)
        {

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
    }
}
