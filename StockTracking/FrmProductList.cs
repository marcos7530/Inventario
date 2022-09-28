using StockTracking.BLL;
using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTracking
{
    public partial class FrmProductList : Form
    {
        public FrmProductList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtStockProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

            CleanFilters();
        }

        ProductBLL bll = new ProductBLL();
        ProductDTO dto = new ProductDTO();
        private void FrmProductList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;

            dgvProductList.DataSource = dto.Products;
            dgvProductList.Columns[0].HeaderText = "Producto";
            dgvProductList.Columns[1].HeaderText = "Categoria";
            dgvProductList.Columns[2].HeaderText = "Stock";
            dgvProductList.Columns[3].HeaderText = "Precio";
            dgvProductList.Columns[4].Visible = false;
            dgvProductList.Columns[5].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProductDetailDTO> list = dto.Products;

            if (txtProductName.Text.Trim()!=null)
            {
                list = list.Where(x => x.ProductName.Contains(txtProductName.Text)).ToList();
            }
            if (cmbCategory.SelectedIndex!=-1)
            {
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
            }
            if (txtPrice.Text.Trim()!="")
            {
                if (rbEqualPrice.Checked)
                {
                    list = list.Where(x => x.Price == Convert.ToInt32(txtPrice.Text)).ToList();
                }
                else if (rbMorePrice.Checked)
                {
                    list = list.Where(x => x.Price > Convert.ToInt32(txtPrice.Text)).ToList();
                }
                else if (rbLessPrice.Checked)
                {
                    list = list.Where(x => x.Price < Convert.ToInt32(txtPrice.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un criterio de busqueda para el precio");
                }
            }
            if (txtStockProduct.Text.Trim() != "")
            {
                if (rbEqualStock.Checked)
                {
                    list = list.Where(x => x.StockAmount == Convert.ToInt32(txtStockProduct.Text)).ToList();
                }
                else if (rbMoreStock.Checked)
                {
                    list = list.Where(x => x.StockAmount > Convert.ToInt32(txtStockProduct.Text)).ToList();
                }
                else if (rbLessStock.Checked)
                {
                    list = list.Where(x => x.StockAmount < Convert.ToInt32(txtStockProduct.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un criterio de busqueda para el stock");
                }

            }
            dgvProductList.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanFilters();
        }

        private void CleanFilters()
        {
            txtPrice.Clear();
            txtProductName.Clear();
            txtStockProduct.Clear();
            cmbCategory.SelectedIndex = -1;
            rbEqualPrice.Checked = false;
            rbMorePrice.Checked = false;
            rbLessPrice.Checked = false;
            rbEqualStock.Checked = false;
            rbLessStock.Checked = false;
            rbMoreStock.Checked = false;
            dgvProductList.DataSource = dto.Products;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

    }
}
