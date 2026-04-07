namespace App.WindowsApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            picUserIcon = new PictureBox();
            lblUser = new Label();
            flpleft = new FlowLayoutPanel();
            pblogo = new PictureBox();
            label1 = new Label();
            panelLeft = new Panel();
            flpnav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnOrder = new Button();
            btnReports = new Button();
            btnSync = new Button();
            btnLogs = new Button();
            btnSettings = new Button();
            pnlContent = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnCustomer = new Button();
            pnlHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserIcon).BeginInit();
            flpleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            panelLeft.SuspendLayout();
            flpnav.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Controls.Add(flpleft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Font = new Font("Segoe UI", 9F);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2, 4, 2, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(909, 75);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += panelHeader_Paint;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(picUserIcon);
            flpRight.Controls.Add(lblUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.Font = new Font("Segoe UI", 9F);
            flpRight.Location = new Point(687, 0);
            flpRight.Margin = new Padding(2, 4, 2, 4);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(222, 75);
            flpRight.TabIndex = 1;
            flpRight.Paint += flpRight_Paint;
            // 
            // picUserIcon
            // 
            picUserIcon.Image = Properties.Resources.svgviewer_png_output__2_1;
            picUserIcon.Location = new Point(2, 4);
            picUserIcon.Margin = new Padding(2, 4, 2, 4);
            picUserIcon.Name = "picUserIcon";
            picUserIcon.Size = new Size(56, 62);
            picUserIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            picUserIcon.TabIndex = 1;
            picUserIcon.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(62, 22);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(67, 25);
            lblUser.TabIndex = 2;
            lblUser.Text = "Admin";
            // 
            // flpleft
            // 
            flpleft.Controls.Add(pblogo);
            flpleft.Controls.Add(label1);
            flpleft.Dock = DockStyle.Left;
            flpleft.Font = new Font("Segoe UI", 9F);
            flpleft.Location = new Point(0, 0);
            flpleft.Margin = new Padding(2, 4, 2, 4);
            flpleft.Name = "flpleft";
            flpleft.Size = new Size(222, 75);
            flpleft.TabIndex = 0;
            flpleft.Paint += flpleft_Paint;
            // 
            // pblogo
            // 
            pblogo.Image = Properties.Resources.svgviewer_png_output__1_;
            pblogo.Location = new Point(2, 4);
            pblogo.Margin = new Padding(2, 4, 2, 4);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(56, 62);
            pblogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "Mini Store";
            label1.Click += label1_Click;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(flpnav);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Font = new Font("Segoe UI", 9F);
            panelLeft.Location = new Point(0, 75);
            panelLeft.Margin = new Padding(2, 4, 2, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(222, 685);
            panelLeft.TabIndex = 1;
            panelLeft.Paint += panelLeft_Paint;
            // 
            // flpnav
            // 
            flpnav.Controls.Add(btnDashboard);
            flpnav.Controls.Add(btnProducts);
            flpnav.Controls.Add(btnCustomer);
            flpnav.Controls.Add(btnOrder);
            flpnav.Controls.Add(btnReports);
            flpnav.Controls.Add(btnSync);
            flpnav.Controls.Add(btnLogs);
            flpnav.Controls.Add(btnSettings);
            flpnav.Dock = DockStyle.Fill;
            flpnav.FlowDirection = FlowDirection.TopDown;
            flpnav.Font = new Font("Segoe UI", 9F);
            flpnav.Location = new Point(0, 0);
            flpnav.Margin = new Padding(2, 4, 2, 4);
            flpnav.Name = "flpnav";
            flpnav.Size = new Size(222, 685);
            flpnav.TabIndex = 1;
            flpnav.Paint += flpnav_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Image = Properties.Resources.dashboard_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(2, 4);
            btnDashboard.Margin = new Padding(2, 4, 2, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(11, 0, 0, 0);
            btnDashboard.Size = new Size(216, 75);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.Image = Properties.Resources.production_quantity_limits_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(2, 87);
            btnProducts.Margin = new Padding(2, 4, 2, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(11, 0, 0, 0);
            btnProducts.Size = new Size(220, 75);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackgroundImageLayout = ImageLayout.Zoom;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Image = Properties.Resources.orders_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(2, 253);
            btnOrder.Margin = new Padding(2, 4, 2, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(11, 0, 0, 0);
            btnOrder.Size = new Size(220, 75);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Image = Properties.Resources.lab_profile_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(2, 336);
            btnReports.Margin = new Padding(2, 4, 2, 4);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(11, 0, 0, 0);
            btnReports.Size = new Size(220, 75);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSync
            // 
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSync.Image = Properties.Resources.sync_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(2, 419);
            btnSync.Margin = new Padding(2, 4, 2, 4);
            btnSync.Name = "btnSync";
            btnSync.Padding = new Padding(11, 0, 0, 0);
            btnSync.Size = new Size(220, 75);
            btnSync.TabIndex = 4;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnLogs
            // 
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogs.Image = Properties.Resources.svgviewer_png_output;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(2, 502);
            btnLogs.Margin = new Padding(2, 4, 2, 4);
            btnLogs.Name = "btnLogs";
            btnLogs.Padding = new Padding(11, 0, 0, 0);
            btnLogs.Size = new Size(220, 75);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Image = Properties.Resources.settings_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(2, 585);
            btnSettings.Margin = new Padding(2, 4, 2, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(11, 0, 0, 0);
            btnSettings.Size = new Size(220, 75);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Font = new Font("Segoe UI", 9F);
            pnlContent.Location = new Point(222, 75);
            pnlContent.Margin = new Padding(2, 4, 2, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(687, 685);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += panelContent_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 760);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(909, 32);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(62, 25);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // btnCustomer
            // 
            btnCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(2, 170);
            btnCustomer.Margin = new Padding(2, 4, 2, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(11, 0, 0, 0);
            btnCustomer.Size = new Size(220, 75);
            btnCustomer.TabIndex = 7;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 792);
            Controls.Add(pnlContent);
            Controls.Add(panelLeft);
            Controls.Add(statusStrip1);
            Controls.Add(pnlHeader);
            Margin = new Padding(2, 4, 2, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserIcon).EndInit();
            flpleft.ResumeLayout(false);
            flpleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            panelLeft.ResumeLayout(false);
            flpnav.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpleft;
        private System.Windows.Forms.FlowLayoutPanel flpnav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private Button btnCustomer;
    }
}