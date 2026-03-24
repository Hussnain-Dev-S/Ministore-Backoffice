using App.core.Models;
using App.core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {

        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            InitializeComponent();

            nudPrice.Maximum = Decimal.MaxValue;
            nudStock.Maximum = Int32.MaxValue;

            cbCategory.Items.Clear();
            cbCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cbCategory.SelectedIndex = 0;

            cbStatus.Items.Clear();
            cbStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cbStatus.SelectedIndex = 0;


            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }


            //if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            //{
            //    tbId.Text = p.Id;
            //    lblName.Text = p.Name;
            //    cbCategory.SelectedItem = p.Category;
            //    cbStatus.SelectedItem = p.Status;
            //    // cbCategory.SelectedValue = p.Category;
            //    //cbStatus.SelectedValue = p.Status;
            //    nudPrice.Value = p.Price;
            //    nudStock.Value = p.Stock;

            //}
            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {

                tbId.Text = p.Id;
                tbSearch.Text = p.Name;
                cbCategory.SelectedItem = p.Category;
                cbStatus.SelectedItem = p.Status;
                nudPrice.Value = p.Price;
                nudStock.Value = p.Stock;


            }

        }

        private void tlpProductForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
