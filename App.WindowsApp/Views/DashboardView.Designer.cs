namespace App.WindowsApp.Views
{
    partial class DashboardView
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
            tblDashboard = new TableLayoutPanel();
            tblKpi = new TableLayoutPanel();
            pnlSales = new FlowLayoutPanel();
            lblSalesT = new Label();
            lblSalesV = new Label();
            pnlOrders = new Panel();
            lblOrderV = new Label();
            lblOrderT = new Label();
            pnlRevenue = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnllowStock = new Panel();
            lvLowStock = new ListView();
            clmProduct = new ColumnHeader();
            clmStock = new ColumnHeader();
            lbllowStock = new Label();
            pnlRecentOrder = new Panel();
            lvRecentOrder = new ListView();
            clmOrder = new ColumnHeader();
            clmCostumerId = new ColumnHeader();
            clmTotal = new ColumnHeader();
            clmStatus = new ColumnHeader();
            lblOrder = new Label();
            tblDashboard.SuspendLayout();
            tblKpi.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnllowStock.SuspendLayout();
            pnlRecentOrder.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.BackColor = Color.White;
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(tblKpi, 0, 0);
            tblDashboard.Controls.Add(pnllowStock, 2, 1);
            tblDashboard.Controls.Add(pnlRecentOrder, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(3, 2, 3, 2);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.Padding = new Padding(18, 20, 18, 20);
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(979, 692);
            tblDashboard.TabIndex = 0;
            // 
            // tblKpi
            // 
            tblKpi.ColumnCount = 3;
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.11258F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.11259F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.77484F));
            tblKpi.Controls.Add(pnlSales, 0, 0);
            tblKpi.Controls.Add(pnlOrders, 1, 0);
            tblKpi.Controls.Add(pnlRevenue, 2, 0);
            tblKpi.Dock = DockStyle.Fill;
            tblKpi.Location = new Point(21, 22);
            tblKpi.Margin = new Padding(3, 2, 3, 2);
            tblKpi.Name = "tblKpi";
            tblKpi.RowCount = 1;
            tblKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblKpi.Size = new Size(937, 146);
            tblKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.White;
            pnlSales.Controls.Add(lblSalesT);
            pnlSales.Controls.Add(lblSalesV);
            pnlSales.Dock = DockStyle.Fill;
            pnlSales.Location = new Point(3, 2);
            pnlSales.Margin = new Padding(3, 2, 3, 2);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(304, 142);
            pnlSales.TabIndex = 0;
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesT.Location = new Point(44, 44);
            lblSalesT.Margin = new Padding(44, 44, 41, 0);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(60, 30);
            lblSalesT.TabIndex = 1;
            lblSalesT.Text = "Sales";
            // 
            // lblSalesV
            // 
            lblSalesV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSalesV.AutoSize = true;
            lblSalesV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesV.Location = new Point(158, 49);
            lblSalesV.Margin = new Padding(13, 44, 41, 0);
            lblSalesV.Name = "lblSalesV";
            lblSalesV.Size = new Size(42, 25);
            lblSalesV.TabIndex = 1;
            lblSalesV.Text = "234";
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.White;
            pnlOrders.Controls.Add(lblOrderV);
            pnlOrders.Controls.Add(lblOrderT);
            pnlOrders.Dock = DockStyle.Fill;
            pnlOrders.Location = new Point(313, 2);
            pnlOrders.Margin = new Padding(3, 2, 3, 2);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(304, 142);
            pnlOrders.TabIndex = 1;
            // 
            // lblOrderV
            // 
            lblOrderV.AutoSize = true;
            lblOrderV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderV.Location = new Point(158, 44);
            lblOrderV.Margin = new Padding(33, 44, 41, 0);
            lblOrderV.Name = "lblOrderV";
            lblOrderV.Size = new Size(32, 25);
            lblOrderV.TabIndex = 1;
            lblOrderV.Text = "54";
            // 
            // lblOrderT
            // 
            lblOrderT.AutoSize = true;
            lblOrderT.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderT.Location = new Point(44, 48);
            lblOrderT.Margin = new Padding(33, 44, 41, 0);
            lblOrderT.Name = "lblOrderT";
            lblOrderT.Size = new Size(69, 25);
            lblOrderT.TabIndex = 1;
            lblOrderT.Text = "Orders";
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(lblRevenueV);
            pnlRevenue.Controls.Add(lblRevenueT);
            pnlRevenue.Dock = DockStyle.Fill;
            pnlRevenue.Location = new Point(623, 2);
            pnlRevenue.Margin = new Padding(3, 2, 3, 2);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(311, 142);
            pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueV.Location = new Point(176, 44);
            lblRevenueV.Margin = new Padding(33, 44, 41, 0);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(107, 25);
            lblRevenueV.TabIndex = 1;
            lblRevenueV.Text = "32,765 PKR";
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueT.Location = new Point(33, 44);
            lblRevenueT.Margin = new Padding(33, 44, 41, 0);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(84, 25);
            lblRevenueT.TabIndex = 1;
            lblRevenueT.Text = "Revenue";
            lblRevenueT.Click += lblRevenueT_Click;
            // 
            // pnllowStock
            // 
            pnllowStock.Controls.Add(lvLowStock);
            pnllowStock.Controls.Add(lbllowStock);
            pnllowStock.Dock = DockStyle.Fill;
            pnllowStock.Location = new Point(21, 172);
            pnllowStock.Margin = new Padding(3, 2, 3, 2);
            pnllowStock.Name = "pnllowStock";
            pnllowStock.Size = new Size(937, 247);
            pnllowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            lvLowStock.Columns.AddRange(new ColumnHeader[] { clmProduct, clmStock });
            lvLowStock.Dock = DockStyle.Bottom;
            lvLowStock.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvLowStock.FullRowSelect = true;
            lvLowStock.GridLines = true;
            lvLowStock.Location = new Point(0, 35);
            lvLowStock.Margin = new Padding(3, 5, 3, 5);
            lvLowStock.Name = "lvLowStock";
            lvLowStock.Size = new Size(937, 212);
            lvLowStock.TabIndex = 1;
            lvLowStock.UseCompatibleStateImageBehavior = false;
            lvLowStock.View = View.Details;
            lvLowStock.SelectedIndexChanged += lvLowStock_SelectedIndexChanged;
            // 
            // clmProduct
            // 
            clmProduct.Text = "Product Name";
            // 
            // clmStock
            // 
            clmStock.Text = "Stock";
            // 
            // lbllowStock
            // 
            lbllowStock.AutoSize = true;
            lbllowStock.Dock = DockStyle.Top;
            lbllowStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllowStock.Location = new Point(0, 0);
            lbllowStock.Name = "lbllowStock";
            lbllowStock.Size = new Size(98, 25);
            lbllowStock.TabIndex = 0;
            lbllowStock.Text = "Low Stock";
            // 
            // pnlRecentOrder
            // 
            pnlRecentOrder.Controls.Add(lvRecentOrder);
            pnlRecentOrder.Controls.Add(lblOrder);
            pnlRecentOrder.Dock = DockStyle.Fill;
            pnlRecentOrder.Location = new Point(21, 426);
            pnlRecentOrder.Margin = new Padding(3, 5, 3, 5);
            pnlRecentOrder.Name = "pnlRecentOrder";
            pnlRecentOrder.Size = new Size(937, 241);
            pnlRecentOrder.TabIndex = 2;
            // 
            // lvRecentOrder
            // 
            lvRecentOrder.Columns.AddRange(new ColumnHeader[] { clmOrder, clmCostumerId, clmTotal, clmStatus });
            lvRecentOrder.Dock = DockStyle.Bottom;
            lvRecentOrder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvRecentOrder.FullRowSelect = true;
            lvRecentOrder.GridLines = true;
            lvRecentOrder.Location = new Point(0, 37);
            lvRecentOrder.Margin = new Padding(3, 5, 3, 5);
            lvRecentOrder.Name = "lvRecentOrder";
            lvRecentOrder.Size = new Size(937, 204);
            lvRecentOrder.TabIndex = 1;
            lvRecentOrder.UseCompatibleStateImageBehavior = false;
            lvRecentOrder.View = View.Details;
            // 
            // clmOrder
            // 
            clmOrder.Text = "Order Id";
            // 
            // clmCostumerId
            // 
            clmCostumerId.Text = "Costumer Name";
            // 
            // clmTotal
            // 
            clmTotal.Text = "Total";
            // 
            // clmStatus
            // 
            clmStatus.Text = "Status";
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Dock = DockStyle.Top;
            lblOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrder.Location = new Point(0, 0);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(133, 25);
            lblOrder.TabIndex = 0;
            lblOrder.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardView";
            Size = new Size(979, 692);
            tblDashboard.ResumeLayout(false);
            tblKpi.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnllowStock.ResumeLayout(false);
            pnllowStock.PerformLayout();
            pnlRecentOrder.ResumeLayout(false);
            pnlRecentOrder.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblKpi;
        private System.Windows.Forms.FlowLayoutPanel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnllowStock;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.Label lbllowStock;
        private System.Windows.Forms.ColumnHeader clmProduct;
        private System.Windows.Forms.ColumnHeader clmStock;
        private System.Windows.Forms.Panel pnlRecentOrder;
        private System.Windows.Forms.ListView lvRecentOrder;
        private System.Windows.Forms.ColumnHeader clmOrder;
        private System.Windows.Forms.ColumnHeader clmCostumerId;
        private System.Windows.Forms.ColumnHeader clmTotal;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.Label lblOrder;
    }
}
