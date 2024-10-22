namespace JMITSolucions_POS_software.Screens.ProductsF
{
    partial class DefineProductsScreen
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
            ProductNameTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            CategoryComboBox = new MetroSet_UI.Controls.MetroSetComboBox();
            DefineNewButton = new MetroSet_UI.Controls.MetroSetButton();
            metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            CloseButton = new MetroSet_UI.Controls.MetroSetButton();
            SaveButton = new MetroSet_UI.Controls.MetroSetButton();
            PurchasePriceTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            SalesPriceTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            SupplierComboBox = new MetroSet_UI.Controls.MetroSetComboBox();
            SizeDataGridView = new DataGridView();
            SelectAllSizeButton = new Button();
            DeselectSizeInDataGridView = new Button();
            ((System.ComponentModel.ISupportInitialize)SizeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(92, 117);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(257, 34);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 0;
            metroSetLabel1.Text = "Select the product size";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
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
            ProductNameTextBox.Location = new Point(448, 154);
            ProductNameTextBox.MaxLength = 32767;
            ProductNameTextBox.Multiline = false;
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.ReadOnly = false;
            ProductNameTextBox.Size = new Size(265, 34);
            ProductNameTextBox.Style = MetroSet_UI.Enums.Style.Light;
            ProductNameTextBox.StyleManager = null;
            ProductNameTextBox.TabIndex = 1;
            ProductNameTextBox.TextAlign = HorizontalAlignment.Left;
            ProductNameTextBox.ThemeAuthor = "Narwin";
            ProductNameTextBox.ThemeName = "MetroLite";
            ProductNameTextBox.UseSystemPasswordChar = false;
            ProductNameTextBox.WatermarkText = "";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.AllowDrop = true;
            CategoryComboBox.ArrowColor = Color.FromArgb(150, 150, 150);
            CategoryComboBox.BackColor = Color.Transparent;
            CategoryComboBox.BackgroundColor = Color.FromArgb(238, 238, 238);
            CategoryComboBox.BorderColor = Color.FromArgb(150, 150, 150);
            CategoryComboBox.CausesValidation = false;
            CategoryComboBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            CategoryComboBox.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            CategoryComboBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            CategoryComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.IsDerivedStyle = true;
            CategoryComboBox.ItemHeight = 20;
            CategoryComboBox.Location = new Point(531, 207);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            CategoryComboBox.SelectedItemForeColor = Color.White;
            CategoryComboBox.Size = new Size(182, 26);
            CategoryComboBox.Style = MetroSet_UI.Enums.Style.Light;
            CategoryComboBox.StyleManager = null;
            CategoryComboBox.TabIndex = 2;
            CategoryComboBox.ThemeAuthor = "Narwin";
            CategoryComboBox.ThemeName = "MetroLite";
            // 
            // DefineNewButton
            // 
            DefineNewButton.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            DefineNewButton.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            DefineNewButton.DisabledForeColor = Color.Gray;
            DefineNewButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DefineNewButton.HoverBorderColor = Color.FromArgb(95, 207, 255);
            DefineNewButton.HoverColor = Color.FromArgb(95, 207, 255);
            DefineNewButton.HoverTextColor = Color.White;
            DefineNewButton.IsDerivedStyle = true;
            DefineNewButton.Location = new Point(165, 418);
            DefineNewButton.Name = "DefineNewButton";
            DefineNewButton.NormalBorderColor = Color.FromArgb(65, 177, 225);
            DefineNewButton.NormalColor = Color.FromArgb(65, 177, 225);
            DefineNewButton.NormalTextColor = Color.White;
            DefineNewButton.PressBorderColor = Color.FromArgb(35, 147, 195);
            DefineNewButton.PressColor = Color.FromArgb(35, 147, 195);
            DefineNewButton.PressTextColor = Color.White;
            DefineNewButton.Size = new Size(157, 55);
            DefineNewButton.Style = MetroSet_UI.Enums.Style.Light;
            DefineNewButton.StyleManager = null;
            DefineNewButton.TabIndex = 3;
            DefineNewButton.Text = "Define New";
            DefineNewButton.ThemeAuthor = "Narwin";
            DefineNewButton.ThemeName = "MetroLite";
            DefineNewButton.Click += DefineNewButton_Click;
            // 
            // metroSetLabel2
            // 
            metroSetLabel2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel2.IsDerivedStyle = true;
            metroSetLabel2.Location = new Point(710, 361);
            metroSetLabel2.Name = "metroSetLabel2";
            metroSetLabel2.Size = new Size(150, 34);
            metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel2.StyleManager = null;
            metroSetLabel2.TabIndex = 4;
            metroSetLabel2.Text = "Sales Prices";
            metroSetLabel2.ThemeAuthor = "Narwin";
            metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            metroSetLabel3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel3.IsDerivedStyle = true;
            metroSetLabel3.Location = new Point(710, 304);
            metroSetLabel3.Name = "metroSetLabel3";
            metroSetLabel3.Size = new Size(150, 34);
            metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel3.StyleManager = null;
            metroSetLabel3.TabIndex = 5;
            metroSetLabel3.Text = "Purchase Price";
            metroSetLabel3.ThemeAuthor = "Narwin";
            metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            metroSetLabel4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel4.IsDerivedStyle = true;
            metroSetLabel4.Location = new Point(710, 254);
            metroSetLabel4.Name = "metroSetLabel4";
            metroSetLabel4.Size = new Size(150, 34);
            metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel4.StyleManager = null;
            metroSetLabel4.TabIndex = 6;
            metroSetLabel4.Text = "Supplier";
            metroSetLabel4.ThemeAuthor = "Narwin";
            metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            metroSetLabel5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel5.IsDerivedStyle = true;
            metroSetLabel5.Location = new Point(710, 207);
            metroSetLabel5.Name = "metroSetLabel5";
            metroSetLabel5.Size = new Size(150, 34);
            metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel5.StyleManager = null;
            metroSetLabel5.TabIndex = 7;
            metroSetLabel5.Text = "Category";
            metroSetLabel5.ThemeAuthor = "Narwin";
            metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            metroSetLabel6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel6.IsDerivedStyle = true;
            metroSetLabel6.Location = new Point(710, 154);
            metroSetLabel6.Name = "metroSetLabel6";
            metroSetLabel6.Size = new Size(150, 34);
            metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel6.StyleManager = null;
            metroSetLabel6.TabIndex = 8;
            metroSetLabel6.Text = "Product Name";
            metroSetLabel6.ThemeAuthor = "Narwin";
            metroSetLabel6.ThemeName = "MetroLite";
            // 
            // CloseButton
            // 
            CloseButton.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            CloseButton.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            CloseButton.DisabledForeColor = Color.Gray;
            CloseButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.HoverBorderColor = Color.FromArgb(95, 207, 255);
            CloseButton.HoverColor = Color.FromArgb(95, 207, 255);
            CloseButton.HoverTextColor = Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new Point(673, 456);
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = Color.FromArgb(65, 177, 225);
            CloseButton.NormalColor = Color.FromArgb(65, 177, 225);
            CloseButton.NormalTextColor = Color.White;
            CloseButton.PressBorderColor = Color.FromArgb(35, 147, 195);
            CloseButton.PressColor = Color.FromArgb(35, 147, 195);
            CloseButton.PressTextColor = Color.White;
            CloseButton.Size = new Size(187, 55);
            CloseButton.Style = MetroSet_UI.Enums.Style.Light;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 9;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Narwin";
            CloseButton.ThemeName = "MetroLite";
            CloseButton.Click += CloseButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            SaveButton.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            SaveButton.DisabledForeColor = Color.Gray;
            SaveButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.HoverBorderColor = Color.FromArgb(95, 207, 255);
            SaveButton.HoverColor = Color.FromArgb(95, 207, 255);
            SaveButton.HoverTextColor = Color.White;
            SaveButton.IsDerivedStyle = true;
            SaveButton.Location = new Point(457, 456);
            SaveButton.Name = "SaveButton";
            SaveButton.NormalBorderColor = Color.FromArgb(65, 177, 225);
            SaveButton.NormalColor = Color.FromArgb(65, 177, 225);
            SaveButton.NormalTextColor = Color.White;
            SaveButton.PressBorderColor = Color.FromArgb(35, 147, 195);
            SaveButton.PressColor = Color.FromArgb(35, 147, 195);
            SaveButton.PressTextColor = Color.White;
            SaveButton.Size = new Size(187, 55);
            SaveButton.Style = MetroSet_UI.Enums.Style.Light;
            SaveButton.StyleManager = null;
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.ThemeAuthor = "Narwin";
            SaveButton.ThemeName = "MetroLite";
            SaveButton.Click += SaveButton_Click;
            // 
            // PurchasePriceTextBox
            // 
            PurchasePriceTextBox.AutoCompleteCustomSource = null;
            PurchasePriceTextBox.AutoCompleteMode = AutoCompleteMode.None;
            PurchasePriceTextBox.AutoCompleteSource = AutoCompleteSource.None;
            PurchasePriceTextBox.BorderColor = Color.FromArgb(155, 155, 155);
            PurchasePriceTextBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            PurchasePriceTextBox.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            PurchasePriceTextBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            PurchasePriceTextBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PurchasePriceTextBox.HoverColor = Color.FromArgb(102, 102, 102);
            PurchasePriceTextBox.Image = null;
            PurchasePriceTextBox.IsDerivedStyle = true;
            PurchasePriceTextBox.Lines = null;
            PurchasePriceTextBox.Location = new Point(604, 304);
            PurchasePriceTextBox.MaxLength = 32767;
            PurchasePriceTextBox.Multiline = false;
            PurchasePriceTextBox.Name = "PurchasePriceTextBox";
            PurchasePriceTextBox.ReadOnly = false;
            PurchasePriceTextBox.Size = new Size(109, 34);
            PurchasePriceTextBox.Style = MetroSet_UI.Enums.Style.Light;
            PurchasePriceTextBox.StyleManager = null;
            PurchasePriceTextBox.TabIndex = 11;
            PurchasePriceTextBox.TextAlign = HorizontalAlignment.Left;
            PurchasePriceTextBox.ThemeAuthor = "Narwin";
            PurchasePriceTextBox.ThemeName = "MetroLite";
            PurchasePriceTextBox.UseSystemPasswordChar = false;
            PurchasePriceTextBox.WatermarkText = "";
            // 
            // SalesPriceTextBox
            // 
            SalesPriceTextBox.AutoCompleteCustomSource = null;
            SalesPriceTextBox.AutoCompleteMode = AutoCompleteMode.None;
            SalesPriceTextBox.AutoCompleteSource = AutoCompleteSource.None;
            SalesPriceTextBox.BorderColor = Color.FromArgb(155, 155, 155);
            SalesPriceTextBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            SalesPriceTextBox.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            SalesPriceTextBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            SalesPriceTextBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SalesPriceTextBox.HoverColor = Color.FromArgb(102, 102, 102);
            SalesPriceTextBox.Image = null;
            SalesPriceTextBox.IsDerivedStyle = true;
            SalesPriceTextBox.Lines = null;
            SalesPriceTextBox.Location = new Point(604, 361);
            SalesPriceTextBox.MaxLength = 32767;
            SalesPriceTextBox.Multiline = false;
            SalesPriceTextBox.Name = "SalesPriceTextBox";
            SalesPriceTextBox.ReadOnly = false;
            SalesPriceTextBox.Size = new Size(109, 34);
            SalesPriceTextBox.Style = MetroSet_UI.Enums.Style.Light;
            SalesPriceTextBox.StyleManager = null;
            SalesPriceTextBox.TabIndex = 12;
            SalesPriceTextBox.TextAlign = HorizontalAlignment.Left;
            SalesPriceTextBox.ThemeAuthor = "Narwin";
            SalesPriceTextBox.ThemeName = "MetroLite";
            SalesPriceTextBox.UseSystemPasswordChar = false;
            SalesPriceTextBox.WatermarkText = "";
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.AllowDrop = true;
            SupplierComboBox.ArrowColor = Color.FromArgb(150, 150, 150);
            SupplierComboBox.BackColor = Color.Transparent;
            SupplierComboBox.BackgroundColor = Color.FromArgb(238, 238, 238);
            SupplierComboBox.BorderColor = Color.FromArgb(150, 150, 150);
            SupplierComboBox.CausesValidation = false;
            SupplierComboBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            SupplierComboBox.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            SupplierComboBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            SupplierComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            SupplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SupplierComboBox.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.IsDerivedStyle = true;
            SupplierComboBox.ItemHeight = 20;
            SupplierComboBox.Location = new Point(531, 254);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            SupplierComboBox.SelectedItemForeColor = Color.White;
            SupplierComboBox.Size = new Size(182, 26);
            SupplierComboBox.Style = MetroSet_UI.Enums.Style.Light;
            SupplierComboBox.StyleManager = null;
            SupplierComboBox.TabIndex = 13;
            SupplierComboBox.ThemeAuthor = "Narwin";
            SupplierComboBox.ThemeName = "MetroLite";
            // 
            // SizeDataGridView
            // 
            SizeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SizeDataGridView.Location = new Point(77, 154);
            SizeDataGridView.Name = "SizeDataGridView";
            SizeDataGridView.RowHeadersWidth = 35;
            SizeDataGridView.RowTemplate.Height = 33;
            SizeDataGridView.Size = new Size(352, 252);
            SizeDataGridView.TabIndex = 14;
            // 
            // SelectAllSizeButton
            // 
            SelectAllSizeButton.Location = new Point(15, 154);
            SelectAllSizeButton.Name = "SelectAllSizeButton";
            SelectAllSizeButton.Size = new Size(45, 34);
            SelectAllSizeButton.TabIndex = 15;
            SelectAllSizeButton.Text = "A";
            SelectAllSizeButton.UseVisualStyleBackColor = true;
            // 
            // DeselectSizeInDataGridView
            // 
            DeselectSizeInDataGridView.Location = new Point(15, 216);
            DeselectSizeInDataGridView.Name = "DeselectSizeInDataGridView";
            DeselectSizeInDataGridView.Size = new Size(45, 34);
            DeselectSizeInDataGridView.TabIndex = 16;
            DeselectSizeInDataGridView.Text = "D";
            DeselectSizeInDataGridView.UseVisualStyleBackColor = true;
            // 
            // DefineProductsScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(888, 536);
            Controls.Add(DeselectSizeInDataGridView);
            Controls.Add(SelectAllSizeButton);
            Controls.Add(SizeDataGridView);
            Controls.Add(SupplierComboBox);
            Controls.Add(SalesPriceTextBox);
            Controls.Add(PurchasePriceTextBox);
            Controls.Add(SaveButton);
            Controls.Add(CloseButton);
            Controls.Add(metroSetLabel6);
            Controls.Add(metroSetLabel5);
            Controls.Add(metroSetLabel4);
            Controls.Add(metroSetLabel3);
            Controls.Add(metroSetLabel2);
            Controls.Add(DefineNewButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(metroSetLabel1);
            Name = "DefineProductsScreen";
            RightToLeft = RightToLeft.Yes;
            ShowInTaskbar = false;
            Text = "Products Definition";
            Load += DefineProductsScreen_Load;
            ((System.ComponentModel.ISupportInitialize)SizeDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox ProductNameTextBox;
        private MetroSet_UI.Controls.MetroSetComboBox CategoryComboBox;
        private MetroSet_UI.Controls.MetroSetButton DefineNewButton;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetButton CloseButton;
        private MetroSet_UI.Controls.MetroSetButton SaveButton;
        private MetroSet_UI.Controls.MetroSetTextBox PurchasePriceTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox SalesPriceTextBox;
        private MetroSet_UI.Controls.MetroSetComboBox SupplierComboBox;
        private DataGridView SizeDataGridView;
        private Button SelectAllSizeButton;
        private Button DeselectSizeInDataGridView;
    }
}