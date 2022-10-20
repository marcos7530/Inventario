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
    public partial class FrmAddStock : Form
    {
        public FrmAddStock()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStockProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        ProductBLL bll = new ProductBLL();
        ProductDTO dto = new ProductDTO();
        private void FrmAddStock_Load(object sender, EventArgs e)
        {
            dto = bll.Select();

            //COMBO BOX
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;

            //GRILLA DE PRODUCTO
            dataGridView1.DataSource = dto.Products;
            dataGridView1.Columns[0].HeaderText = "Producto";
            dataGridView1.Columns[1].HeaderText = "Categoria";
            dataGridView1.Columns[2].HeaderText = "Stock";
            dataGridView1.Columns[3].HeaderText = "Precio";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            if (dto.Categories.Count>0)
            {
                combofull = true;
            }
        
        }

        bool combofull = false;
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
            List<ProductDetailDTO> list = dto.Products;
                list = list.Where(x=>x.CategoryID==Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
                dataGridView1.DataSource = list;
                if (list.Count==0)
                {
                    txtPrice.Clear();
                    txtProductName.Clear();
                    txtStockProduct.Clear();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("Por favor seleccione un producto de la tabla");
            }
            else if (txtStockProduct.Text.Trim()=="")
            {
                MessageBox.Show("Por favor, introduce una cantidad");
            }
            else
            {
                int sumStock = detail.StockAmount;
                sumStock += Convert.ToInt32(txtStockProduct.Text);
                detail.StockAmount = sumStock;
                if (bll.Update(detail))
                {
                    MessageBox.Show("El stock ha sido actualizado");
                    bll = new ProductBLL();
                    dto = bll.Select();
                    dataGridView1.DataSource = dto.Products;
                    txtStockProduct.Clear();
                }
            }
        }

        ProductDetailDTO detail = new ProductDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProductName.Text = detail.ProductName;
            detail.Price= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value) ;
            txtPrice.Text = detail.Price.ToString();
            detail.StockAmount= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
        }
    }
}
