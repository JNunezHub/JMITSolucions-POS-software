namespace JMITSolucions_POS_software.Screens.ProductsF
{
    partial class ProductRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            ProductsDataGridView = new DataGridView();
            metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            ProductNameTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(15, 128);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(234, 34);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 0;
            metroSetLabel1.Text = "Search by product name:";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AllowUserToAddRows = false;
            ProductsDataGridView.AllowUserToDeleteRows = false;
            ProductsDataGridView.AllowUserToResizeColumns = false;
            ProductsDataGridView.AllowUserToResizeRows = false;
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(15, 189);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.ReadOnly = true;
            ProductsDataGridView.RowHeadersVisible = false;
            ProductsDataGridView.RowHeadersWidth = 62;
            ProductsDataGridView.RowTemplate.Height = 33;
            ProductsDataGridView.ScrollBars = ScrollBars.Vertical;
            ProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGridView.Size = new Size(914, 396);
            ProductsDataGridView.TabIndex = 2;
            // 
            // metroSetButton1
            // 
            metroSetButton1.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton1.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton1.DisabledForeColor = Color.Gray;
            metroSetButton1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton1.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton1.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton1.HoverTextColor = Color.White;
            metroSetButton1.IsDerivedStyle = true;
            metroSetButton1.Location = new Point(796, 608);
            metroSetButton1.Name = "metroSetButton1";
            metroSetButton1.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton1.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton1.NormalTextColor = Color.White;
            metroSetButton1.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton1.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton1.PressTextColor = Color.White;
            metroSetButton1.Size = new Size(94, 46);
            metroSetButton1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetButton1.StyleManager = null;
            metroSetButton1.TabIndex = 3;
            metroSetButton1.Text = "Exit";
            metroSetButton1.ThemeAuthor = "Narwin";
            metroSetButton1.ThemeName = "MetroLite";
            metroSetButton1.Click += metroSetButton1_Click;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.AutoCompleteCustomSource = null;
            ProductNameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            ProductNameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            ProductNameTextBox.BorderColor = Color.FromArgb(155, 155, 155);
            ProductNameTextBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            ProductNameTextBox.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            ProductNameTextBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            ProductNameTextBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameTextBox.HoverColor = Color.FromArgb(102, 102, 102);
            ProductNameTextBox.Image = null;
            ProductNameTextBox.IsDerivedStyle = true;
            ProductNameTextBox.Lines = null;
            ProductNameTextBox.Location = new Point(271, 126);
            ProductNameTextBox.MaxLength = 32767;
            ProductNameTextBox.Multiline = false;
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.ReadOnly = false;
            ProductNameTextBox.Size = new Size(619, 45);
            ProductNameTextBox.Style = MetroSet_UI.Enums.Style.Light;
            ProductNameTextBox.StyleManager = null;
            ProductNameTextBox.TabIndex = 4;
            ProductNameTextBox.TextAlign = HorizontalAlignment.Left;
            ProductNameTextBox.ThemeAuthor = "Narwin";
            ProductNameTextBox.ThemeName = "MetroLite";
            ProductNameTextBox.UseSystemPasswordChar = false;
            ProductNameTextBox.WatermarkText = "";
            ProductNameTextBox.TextChanged += ProductNameTextBox_TextChanged;
            // 
            // ProductRecordForm
            // 
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 669);
            Controls.Add(ProductNameTextBox);
            Controls.Add(metroSetButton1);
            Controls.Add(ProductsDataGridView);
            Controls.Add(metroSetLabel1);
            Name = "ProductRecordForm";
            ShowInTaskbar = false;
            Text = "Product Record";
            Load += ProductRecordForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private DataGridView ProductsDataGridView;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetTextBox ProductNameTextBox;
    }
}