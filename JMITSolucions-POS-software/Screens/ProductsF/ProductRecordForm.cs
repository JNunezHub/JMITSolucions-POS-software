using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JMITSolucions_POS_software.General;
using MetroSet_UI.Forms;

namespace JMITSolucions_POS_software.Screens.ProductsF
{
    public partial class ProductRecordForm : MetroSetForm

    {
        public ProductRecordForm()
        {
            InitializeComponent();
        }

        private void ProductRecordForm_Load(object sender, EventArgs e)
        {
            LoadAllProductsIntoDataGridView();
        }

        private void LoadAllProductsIntoDataGridView()
        {
            ProductsDataGridView.DataSource = GetData();
            ProductsDataGridView.Columns[0].Visible = false;

        }

        private DataTable GetData()
        {
            DataTable dtrecord = new DataTable();


            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_Products_LoadAllProductsForDataGridView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                }
            }

            return dtrecord;
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductNameTextBox.Text.Trim() == string.Empty)
            {
                LoadAllProductsIntoDataGridView();
            }
            else
            {
                ProductsDataGridView.DataSource = GetProductByProductID();
            }
        }

        private DataTable GetProductByProductID()
        {
            DataTable dtrecord = new DataTable();


            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_Products_LoadAllProductsByProductName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", ProductNameTextBox.Text.Trim());
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                }
            }

            return dtrecord;
        }
    }
}
