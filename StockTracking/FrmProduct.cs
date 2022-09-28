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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
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

        public ProductDTO dto = new ProductDTO();
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;
        }

        ProductBLL bll = new ProductBLL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim()=="")
            {
                MessageBox.Show("El nombre del producto esta vacio");
            }
            else if (cmbCategory.SelectedIndex==-1)
            {
                MessageBox.Show("POr favor seleccione una categoria");
            }
            else if (txtPrice.Text.Trim()=="")
            {
                MessageBox.Show("El producto no tiene precio!");
            }
            else
            {
                ProductDetailDTO product = new ProductDetailDTO();
                product.ProductName = txtProductName.Text;
                product.CategoryID = (int)cmbCategory.SelectedValue;
                product.Price = Convert.ToInt32(txtPrice.Text);

                if (bll.Insert(product))
                {
                    MessageBox.Show("El producto se ha agregado de correctamente.");
                    txtPrice.Clear();
                    txtProductName.Clear();
                    cmbCategory.SelectedIndex = -1;
                }
            }
        }
    }
}
