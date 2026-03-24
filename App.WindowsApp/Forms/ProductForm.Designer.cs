namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            pnlproductform = new Panel();
            pnlBottom = new Panel();
            flpBottom = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tlpProductForm = new TableLayoutPanel();
            lblName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            lblId = new Label();
            tbSearch = new TextBox();
            nudPrice = new NumericUpDown();
            nudStock = new NumericUpDown();
            cbCategory = new ComboBox();
            cbStatus = new ComboBox();
            tbId = new TextBox();
            pnlproductform.SuspendLayout();
            pnlBottom.SuspendLayout();
            flpBottom.SuspendLayout();
            tlpProductForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // pnlproductform
            // 
            pnlproductform.Controls.Add(pnlBottom);
            pnlproductform.Controls.Add(tlpProductForm);
            pnlproductform.Dock = DockStyle.Fill;
            pnlproductform.Location = new Point(0, 0);
            pnlproductform.Margin = new Padding(4);
            pnlproductform.Name = "pnlproductform";
            pnlproductform.Size = new Size(1000, 562);
            pnlproductform.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(flpBottom);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 406);
            pnlBottom.Margin = new Padding(4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1000, 156);
            pnlBottom.TabIndex = 0;
            // 
            // flpBottom
            // 
            flpBottom.Controls.Add(btnSave);
            flpBottom.Controls.Add(btnCancel);
            flpBottom.Dock = DockStyle.Fill;
            flpBottom.FlowDirection = FlowDirection.RightToLeft;
            flpBottom.Location = new Point(0, 0);
            flpBottom.Margin = new Padding(4);
            flpBottom.Name = "flpBottom";
            flpBottom.Size = new Size(1000, 156);
            flpBottom.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(748, 50);
            btnSave.Margin = new Padding(4, 50, 100, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 50);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Image = Properties.Resources.cancel_32dp_000000_FILL0_wght400_GRAD0_opsz40__1_;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(526, 50);
            btnCancel.Margin = new Padding(4, 50, 100, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 50);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tlpProductForm
            // 
            tlpProductForm.ColumnCount = 2;
            tlpProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.0984459F));
            tlpProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.90155F));
            tlpProductForm.Controls.Add(lblName, 0, 0);
            tlpProductForm.Controls.Add(lblCategory, 0, 1);
            tlpProductForm.Controls.Add(lblPrice, 0, 2);
            tlpProductForm.Controls.Add(lblStock, 0, 3);
            tlpProductForm.Controls.Add(lblStatus, 0, 4);
            tlpProductForm.Controls.Add(lblId, 0, 5);
            tlpProductForm.Controls.Add(tbSearch, 1, 0);
            tlpProductForm.Controls.Add(nudPrice, 1, 2);
            tlpProductForm.Controls.Add(nudStock, 1, 3);
            tlpProductForm.Controls.Add(cbCategory, 1, 1);
            tlpProductForm.Controls.Add(cbStatus, 1, 4);
            tlpProductForm.Controls.Add(tbId, 1, 5);
            tlpProductForm.Dock = DockStyle.Fill;
            tlpProductForm.Location = new Point(0, 0);
            tlpProductForm.Margin = new Padding(4);
            tlpProductForm.Name = "tlpProductForm";
            tlpProductForm.RowCount = 7;
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 7.82918167F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 7.29537344F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 7.82918167F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 7.29537344F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 8.718862F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 7.82918167F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2028465F));
            tlpProductForm.Size = new Size(1000, 562);
            tlpProductForm.TabIndex = 1;
            tlpProductForm.Paint += tlpProductForm_Paint;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Location = new Point(55, 9);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.None;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(43, 52);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 25);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.None;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(60, 94);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.None;
            lblStock.AutoSize = true;
            lblStock.Location = new Point(58, 137);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(54, 25);
            lblStock.TabIndex = 9;
            lblStock.Text = "stock";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(55, 182);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Location = new Point(70, 228);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 11;
            lblId.Text = "ID";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbSearch
            // 
            tbSearch.Dock = DockStyle.Fill;
            tbSearch.Location = new Point(174, 4);
            tbSearch.Margin = new Padding(4);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(822, 31);
            tbSearch.TabIndex = 0;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // nudPrice
            // 
            nudPrice.Dock = DockStyle.Fill;
            nudPrice.Location = new Point(174, 89);
            nudPrice.Margin = new Padding(4);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(822, 31);
            nudPrice.TabIndex = 2;
            // 
            // nudStock
            // 
            nudStock.Dock = DockStyle.Fill;
            nudStock.Location = new Point(174, 133);
            nudStock.Margin = new Padding(4);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(822, 31);
            nudStock.TabIndex = 3;
            // 
            // cbCategory
            // 
            cbCategory.Dock = DockStyle.Fill;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(174, 48);
            cbCategory.Margin = new Padding(4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(822, 33);
            cbCategory.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.Dock = DockStyle.Fill;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(174, 174);
            cbStatus.Margin = new Padding(4);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(822, 33);
            cbStatus.TabIndex = 4;
            // 
            // tbId
            // 
            tbId.Dock = DockStyle.Fill;
            tbId.Location = new Point(174, 223);
            tbId.Margin = new Padding(4);
            tbId.Name = "tbId";
            tbId.Size = new Size(822, 31);
            tbId.TabIndex = 5;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(pnlproductform);
            Margin = new Padding(4);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            pnlproductform.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            flpBottom.ResumeLayout(false);
            tlpProductForm.ResumeLayout(false);
            tlpProductForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlproductform;
        private TableLayoutPanel tlpProductForm;
        private Panel pnlBottom;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblStatus;
        private Label lblId;
        private TextBox tbSearch;
        private NumericUpDown nudPrice;
        private NumericUpDown nudStock;
        private ComboBox cbCategory;
        private ComboBox cbStatus;
        private TextBox tbId;
        private FlowLayoutPanel flpBottom;
        private Button btnSave;
        private Button btnCancel;
    }
}