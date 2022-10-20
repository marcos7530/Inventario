using StockTracking.BLL;
using StockTracking.DAL.DTO;
using System;
using System.Windows.Forms;

namespace StockTracking
{
    public partial class FrmSalesList : Form
    {
        public FrmSalesList()
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

        private void txtSalesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmSales frm = new FrmSales();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        SalesBLL bll = new SalesBLL();
        SalesDTO dto = new SalesDTO();
        private void FrmSalesList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
        }
    }
}
