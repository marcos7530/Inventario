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
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SalesDTO dto = new SalesDTO();
        private void FrmSales_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;

            dataGridView1.DataSource = dto.Products;
            dataGridView1.Columns[0].HeaderText = "Producto";
            dataGridView1.Columns[1].HeaderText = "Categoria";
            dataGridView1.Columns[2].HeaderText = "Stock";
            dataGridView1.Columns[3].HeaderText = "Precio";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            dataGridView2.DataSource = dto.Customers;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Nombre del Cliente";

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
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();

            }
        }
    }
}
