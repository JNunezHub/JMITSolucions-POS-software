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
using System.Data.SqlClient;
using JMITSolucions_POS_software.General;
using System.Configuration;

namespace JMITSolucions_POS_software.Screens.ProductsF
{
    public partial class DefineProductsScreen : MetroSetForm
    {
        public DefineProductsScreen()
        {
            InitializeComponent();
        }

        public bool IsUpdate { get; set; }
        private List<int> SizesCart = new List<int>();
        private void DefineProductsScreen_Load(object sender, EventArgs e)
        {
            if (!this.IsUpdate)
            {

            }
            LoadAllSizesInDataGridView();
            LoadDataIntoComboBoxes();
        }

        private void LoadDataIntoComboBoxes()
        {
            CategoryComboBox.DataSource = GetComboBoxData(2);
            CategoryComboBox.DisplayMember = "Description";
            CategoryComboBox.ValueMember = "ID";
            SupplierComboBox.DataSource = GetComboBoxData(3);
            SupplierComboBox.DisplayMember = "Description";
            SupplierComboBox.ValueMember = "ID";
        }

        private DataTable GetComboBoxData(int ListTypeID)
        {

            DataTable dtrecord = new DataTable();


            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_ListTypeData_LoadDataIntoComboBox", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListTypeID", ListTypeID);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                }
            }

            return dtrecord;
        }

        private void LoadAllSizesInDataGridView()
        {
            SizeDataGridView.DataSource = GetSizesData();
            SizeDataGridView.Columns[0].Visible = false;
        }

        private DataTable GetSizesData()
        {
            DataTable dtsizes = new DataTable(); ;

            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Sizes_LoadAllSizes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListTypeID", 1);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtsizes.Load(sdr);
                }
            }

            return dtsizes;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefineNewButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            ProductNameTextBox.Text = "";
            CategoryComboBox.SelectedIndex = -1;
            SupplierComboBox.SelectedIndex = -1;
            PurchasePriceTextBox.Text = "";
            SalesPriceTextBox.Text = "";

            foreach (DataGridViewRow row in SizeDataGridView.Rows)
            {
                row.Cells["Select"].Value = 0;
            }
            ProductNameTextBox.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SizesCart.Clear();
                LoadDataIntoSizesCart();
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Products_InsertNewProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", ProductNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryComboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@SupplieID", SupplierComboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePriceTextBox.Text);
                        cmd.Parameters.AddWithValue("@SalesPrice", SalesPriceTextBox.Text);

                        con.Open();
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        SaveSizes(id);
                        MessageBox.Show("Product No. " + id.ToString() + " is saved successfully in the system", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void SaveSizes(int _id)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (int sizeID in SizesCart)
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Products_InsertProductSizes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", _id);
                        cmd.Parameters.AddWithValue("@SizeID", sizeID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void LoadDataIntoSizesCart()
        {
            foreach (DataGridViewRow row in SizeDataGridView.Rows)
            {
                if (row.Cells["Select"].Value != null && !DBNull.Value.Equals(row.Cells["Select"].Value) && Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    SizesCart.Add((int)row.Cells["ID"].Value);
                }
            }
        }

        private bool IsValid()
        {
            if (ProductNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Product name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductNameTextBox.Focus(); //remember to do the same in login form.
                return false;
            }

            if (PurchasePriceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Purchase price is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PurchasePriceTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
