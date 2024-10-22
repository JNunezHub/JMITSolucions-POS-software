using JMITSolucions_POS_software.Screens.ProductsF;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMITSolucions_POS_software.Screens
{
    public partial class DashboardForm : MetroSetForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void metroSetButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            DefineProductsScreen dps = new DefineProductsScreen();
            dps.Show();
        }

        private void ManageProductsBotton_Click(object sender, EventArgs e)
        {
            ProductRecordForm prd = new ProductRecordForm();
            prd.Show();
        }
    }
}
