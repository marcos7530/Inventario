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
    public partial class FrmCategoryList : Form
    {
        public FrmCategoryList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

            /*LAS 2 LINEAS DE ABAJO SIRVEN PARA QUE SE ACTUALICE LA GRILLA UNA VES AGREGADO LA CATEGORIA*/
            dto = bll.Select();
            dgvCategories.DataSource = dto.Categories;
        }

        CategoryDTO dto = new CategoryDTO();
        CategoryBLL bll = new CategoryBLL();

        private void FrmCategoryList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dgvCategories.DataSource = dto.Categories;
            dgvCategories.Columns[0].Visible = false;
            dgvCategories.Columns[1].HeaderText = "Nombre Categoria";
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            List<CategoryDetailDTO> list = dto.Categories;
            list = list.Where
                (n => n.CategoryName.Contains(txtCategoryName.Text)).ToList();

            dgvCategories.DataSource = list;
        }
    }
}
