﻿using StockTracking.BLL;
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
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCustomer frm = new FrmCustomer();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

            dto = bll.Select();
            dataGridView1.DataSource = dto.Customers;
        }

            CustomerBLL bll = new CustomerBLL();
            CustomerDTO dto = new CustomerDTO();
        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Customers;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nombre del Cliente";
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailDTO> list = dto.Customers;

            list = list.Where(n => n.CustomerName.Contains(txtCustomerName.Text)).ToList();
            dataGridView1.DataSource = list;

        }
    }
}
