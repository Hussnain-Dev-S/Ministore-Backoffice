using App.core.Contracts;
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
        ProductFormModeEnum _mode;
        Product _product;
        IProductService _service;

        public ProductForm(ProductFormModeEnum mode, Product? p, IProductService service)
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


            _mode = mode;
            _product = p;
            _service = service;

            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }


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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = tbSearch.Text;
                newProduct.Category = (ProductCategoryEnum)cbCategory.SelectedItem;
                newProduct.Status = (ProductStatusEnum)cbStatus.SelectedItem;
                newProduct.Price = nudPrice.Value;
                newProduct.Stock = (int)nudStock.Value;


                //_product = _service.Add(newProduct);
                // tbId.Text = _product.Id;

                Product temp = _service.Add(newProduct);
                tbId.Text = temp?.Id ?? "";


            }
            else if (_mode == ProductFormModeEnum.Edit)
            {
                _product.Name = tbSearch.Text;
                _product.Category = (ProductCategoryEnum)cbCategory.SelectedItem;
                _product.Status = (ProductStatusEnum)cbStatus.SelectedItem;
                _product.Price = nudPrice.Value;
                _product.Stock = (int)nudStock.Value;

                bool isUpdated = _service.Update(_product);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
