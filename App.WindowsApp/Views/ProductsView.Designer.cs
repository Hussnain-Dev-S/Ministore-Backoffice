namespace App.WindowsApp.Views
{
    partial class ProductsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblProducts = new TableLayoutPanel();
            tsProducts = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlFilters = new Panel();
            tblFilters = new TableLayoutPanel();
            lblCategory = new Label();
            lblStockStatus = new Label();
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            txtText = new TextBox();
            lblSearch = new Label();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            colid = new DataGridViewTextBoxColumn();
            colname = new DataGridViewTextBoxColumn();
            colcategory = new DataGridViewTextBoxColumn();
            colprice = new DataGridViewTextBoxColumn();
            colstock = new DataGridViewTextBoxColumn();
            colstatus = new DataGridViewTextBoxColumn();
            tblProducts.SuspendLayout();
            tsProducts.SuspendLayout();
            pnlFilters.SuspendLayout();
            tblFilters.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.Controls.Add(tsProducts, 0, 0);
            tblProducts.Controls.Add(pnlFilters, 0, 1);
            tblProducts.Controls.Add(pnlGrid, 0, 2);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Margin = new Padding(2, 4, 2, 4);
            tblProducts.Name = "tblProducts";
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 214F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProducts.Size = new Size(1288, 929);
            tblProducts.TabIndex = 0;
            tblProducts.Paint += tblProducts_Paint;
            // 
            // tsProducts
            // 
            tsProducts.BackColor = Color.White;
            tsProducts.Dock = DockStyle.Fill;
            tsProducts.GripStyle = ToolStripGripStyle.Hidden;
            tsProducts.ImageScalingSize = new Size(24, 24);
            tsProducts.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh });
            tsProducts.Location = new Point(3, 5);
            tsProducts.Margin = new Padding(2, 4, 2, 4);
            tsProducts.Name = "tsProducts";
            tsProducts.Size = new Size(1282, 62);
            tsProducts.TabIndex = 0;
            tsProducts.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = Properties.Resources.square_plus;
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(74, 57);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = Properties.Resources.edit;
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(70, 57);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = Properties.Resources.eye;
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(77, 57);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = Properties.Resources.square_minus;
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(90, 57);
            tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = Properties.Resources.refresh;
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(98, 57);
            tsbRefresh.Text = "Refresh";
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.Controls.Add(tblFilters);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(3, 76);
            pnlFilters.Margin = new Padding(2, 4, 2, 4);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(12, 11, 12, 11);
            pnlFilters.Size = new Size(1282, 206);
            pnlFilters.TabIndex = 1;
            // 
            // tblFilters
            // 
            tblFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilters.ColumnCount = 3;
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.Controls.Add(lblCategory, 1, 0);
            tblFilters.Controls.Add(lblStockStatus, 2, 0);
            tblFilters.Controls.Add(cmbCategory, 1, 1);
            tblFilters.Controls.Add(cmbStockStatus, 2, 1);
            tblFilters.Controls.Add(txtText, 0, 1);
            tblFilters.Controls.Add(lblSearch, 0, 0);
            tblFilters.Dock = DockStyle.Fill;
            tblFilters.Location = new Point(12, 11);
            tblFilters.Margin = new Padding(2, 4, 2, 4);
            tblFilters.Name = "tblFilters";
            tblFilters.RowCount = 2;
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.Size = new Size(1258, 184);
            tblFilters.TabIndex = 0;
            tblFilters.Paint += tblFilters_Paint;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(505, 0);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(373, 92);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.Location = new Point(882, 0);
            lblStockStatus.Margin = new Padding(2, 0, 2, 0);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(374, 92);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "Stock Status";
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(505, 96);
            cmbCategory.Margin = new Padding(2, 4, 2, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(373, 33);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.Dock = DockStyle.Fill;
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(882, 96);
            cmbStockStatus.Margin = new Padding(2, 4, 2, 4);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(374, 33);
            cmbStockStatus.TabIndex = 4;
            cmbStockStatus.SelectedIndexChanged += cmbStockStatus_SelectedIndexChanged;
            // 
            // txtText
            // 
            txtText.Dock = DockStyle.Fill;
            txtText.Location = new Point(2, 96);
            txtText.Margin = new Padding(2, 4, 2, 4);
            txtText.Name = "txtText";
            txtText.Size = new Size(499, 31);
            txtText.TabIndex = 5;
            txtText.TextChanged += txtText_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(2, 0);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(499, 92);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            lblSearch.Click += lblSearch_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(3, 291);
            pnlGrid.Margin = new Padding(2, 4, 2, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(12, 15, 12, 15);
            pnlGrid.Size = new Size(1282, 633);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colid, colname, colcategory, colprice, colstock, colstatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(12, 15);
            dgvProducts.Margin = new Padding(2, 4, 2, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 28;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1258, 603);
            dgvProducts.TabIndex = 0;
            // 
            // colid
            // 
            colid.DataPropertyName = "Id";
            colid.HeaderText = "ID";
            colid.MinimumWidth = 8;
            colid.Name = "colid";
            colid.ReadOnly = true;
            // 
            // colname
            // 
            colname.DataPropertyName = "Name";
            colname.HeaderText = "Name";
            colname.MinimumWidth = 8;
            colname.Name = "colname";
            colname.ReadOnly = true;
            // 
            // colcategory
            // 
            colcategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colcategory.DataPropertyName = "Category";
            colcategory.HeaderText = "Category";
            colcategory.MinimumWidth = 8;
            colcategory.Name = "colcategory";
            colcategory.ReadOnly = true;
            colcategory.Width = 150;
            // 
            // colprice
            // 
            colprice.DataPropertyName = "Price";
            colprice.HeaderText = "Price";
            colprice.MinimumWidth = 8;
            colprice.Name = "colprice";
            colprice.ReadOnly = true;
            // 
            // colstock
            // 
            colstock.DataPropertyName = "Stock";
            colstock.HeaderText = "Stock";
            colstock.MinimumWidth = 8;
            colstock.Name = "colstock";
            colstock.ReadOnly = true;
            // 
            // colstatus
            // 
            colstatus.DataPropertyName = "Status";
            colstatus.HeaderText = "Status";
            colstatus.MinimumWidth = 8;
            colstatus.Name = "colstatus";
            colstatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProducts);
            Margin = new Padding(2, 4, 2, 4);
            Name = "ProductsView";
            Size = new Size(1288, 929);
            Load += ProductsView_Load;
            tblProducts.ResumeLayout(false);
            tblProducts.PerformLayout();
            tsProducts.ResumeLayout(false);
            tsProducts.PerformLayout();
            pnlFilters.ResumeLayout(false);
            tblFilters.ResumeLayout(false);
            tblFilters.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.ToolStrip tsProducts;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colid;
        private DataGridViewTextBoxColumn colname;
        private DataGridViewTextBoxColumn colcategory;
        private DataGridViewTextBoxColumn colprice;
        private DataGridViewTextBoxColumn colstock;
        private DataGridViewTextBoxColumn colstatus;
    }
}
