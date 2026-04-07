namespace App.WindowsApp.Forms
{
    partial class CustomerForm
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
            tlpCustomerForm = new TableLayoutPanel();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblId = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtId = new TextBox();
            flpBottom = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tlpCustomerForm.SuspendLayout();
            flpBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerForm
            // 
            tlpCustomerForm.ColumnCount = 2;
            tlpCustomerForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpCustomerForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tlpCustomerForm.Controls.Add(lblName, 0, 0);
            tlpCustomerForm.Controls.Add(txtName, 1, 0);
            tlpCustomerForm.Controls.Add(lblPhone, 0, 1);
            tlpCustomerForm.Controls.Add(lblEmail, 0, 2);
            tlpCustomerForm.Controls.Add(lblAddress, 0, 3);
            tlpCustomerForm.Controls.Add(lblId, 0, 4);
            tlpCustomerForm.Controls.Add(txtPhone, 1, 1);
            tlpCustomerForm.Controls.Add(txtEmail, 1, 2);
            tlpCustomerForm.Controls.Add(txtAddress, 1, 3);
            tlpCustomerForm.Controls.Add(txtId, 1, 4);
            tlpCustomerForm.Dock = DockStyle.Top;
            tlpCustomerForm.Location = new Point(0, 0);
            tlpCustomerForm.Name = "tlpCustomerForm";
            tlpCustomerForm.RowCount = 5;
            tlpCustomerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerForm.RowStyles.Add(new RowStyle());
            tlpCustomerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCustomerForm.Size = new Size(739, 221);
            tlpCustomerForm.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 35);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(113, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(623, 31);
            txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPhone.Location = new Point(3, 35);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(104, 35);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(3, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(104, 35);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAddress.Location = new Point(3, 105);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(104, 72);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblId.Location = new Point(3, 177);
            lblId.Name = "lblId";
            lblId.Size = new Size(104, 44);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Top;
            txtPhone.Location = new Point(113, 38);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(623, 31);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Location = new Point(113, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(623, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Top;
            txtAddress.Location = new Point(113, 108);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(623, 66);
            txtAddress.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Top;
            txtId.Location = new Point(113, 180);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(623, 31);
            txtId.TabIndex = 9;
            // 
            // flpBottom
            // 
            flpBottom.Controls.Add(btnSave);
            flpBottom.Controls.Add(btnCancel);
            flpBottom.Dock = DockStyle.Bottom;
            flpBottom.FlowDirection = FlowDirection.RightToLeft;
            flpBottom.Location = new Point(0, 294);
            flpBottom.Name = "flpBottom";
            flpBottom.Size = new Size(739, 58);
            flpBottom.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.save_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(611, 9);
            btnSave.Margin = new Padding(9);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3);
            btnSave.Size = new Size(119, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = Properties.Resources.cancel_32dp_000000_FILL0_wght400_GRAD0_opsz40__1_;
            btnCancel.Location = new Point(474, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(119, 44);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 352);
            Controls.Add(flpBottom);
            Controls.Add(tlpCustomerForm);
            Name = "CustomerForm";
            tlpCustomerForm.ResumeLayout(false);
            tlpCustomerForm.PerformLayout();
            flpBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerForm;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblId;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtId;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flpBottom;
        private Button btnSave;
        private Button btnCancel;
    }
}