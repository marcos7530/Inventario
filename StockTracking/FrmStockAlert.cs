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
    public partial class FrmStockAlert : Form
    {
        public FrmStockAlert()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
           
        }

        ProductDTO dto = new ProductDTO();
        ProductBLL bll = new ProductBLL();
        private void FrmStockAlert_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dto.Products = dto.Products.Where(x=>x.StockAmount<=10).ToList();

            RellenarGrilla(dto.Products);

        }

        private void RellenarGrilla(List<ProductDetailDTO> products)
        {
            if (StockBajo(products))
            {
                dataGridView1.DataSource = products;
                dataGridView1.Columns[0].HeaderText = "Producto";
                dataGridView1.Columns[1].HeaderText = "Categoria";
                dataGridView1.Columns[2].HeaderText = "Stock";
                dataGridView1.Columns[3].HeaderText = "Precio";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
            else
            {
                FrmMain frm = new FrmMain();
                this.Hide();
                frm.ShowDialog();
            }
            
        }

        private bool StockBajo(List<ProductDetailDTO> products)
        {
            if (products.Count==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
