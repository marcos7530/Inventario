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
    public partial class FrmCategory : Form
    {
        CategoryBLL bll = new CategoryBLL();


        public FrmCategory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim()=="")
            {
                MessageBox.Show("La categoria está vacia");
            }
            else
            {
                CategoryDetailDTO category = new CategoryDetailDTO();

                category.CategoryName = txtCategoryName.Text;

                if (bll.Insert(category))
                {
                    MessageBox.Show("Categoria añadida con exito");
                    txtCategoryName.Clear();
                }
            }
        }
    }
}
