
namespace StockTracking
{
    partial class FrmProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gpbStock = new System.Windows.Forms.GroupBox();
            this.rbLessStock = new System.Windows.Forms.RadioButton();
            this.rbMoreStock = new System.Windows.Forms.RadioButton();
            this.rbEqualStock = new System.Windows.Forms.RadioButton();
            this.gpbPrice = new System.Windows.Forms.GroupBox();
            this.rbLessPrice = new System.Windows.Forms.RadioButton();
            this.rbMorePrice = new System.Windows.Forms.RadioButton();
            this.rbEqualPrice = new System.Windows.Forms.RadioButton();
            this.txtStockProduct = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gpbStock.SuspendLayout();
            this.gpbPrice.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.gpbStock);
            this.panel1.Controls.Add(this.gpbPrice);
            this.panel1.Controls.Add(this.txtStockProduct);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 160);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(618, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(517, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gpbStock
            // 
            this.gpbStock.Controls.Add(this.rbLessStock);
            this.gpbStock.Controls.Add(this.rbMoreStock);
            this.gpbStock.Controls.Add(this.rbEqualStock);
            this.gpbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStock.Location = new System.Drawing.Point(517, 52);
            this.gpbStock.Name = "gpbStock";
            this.gpbStock.Size = new System.Drawing.Size(195, 46);
            this.gpbStock.TabIndex = 5;
            this.gpbStock.TabStop = false;
            this.gpbStock.Text = "Stock";
            // 
            // rbLessStock
            // 
            this.rbLessStock.AutoSize = true;
            this.rbLessStock.Location = new System.Drawing.Point(130, 19);
            this.rbLessStock.Name = "rbLessStock";
            this.rbLessStock.Size = new System.Drawing.Size(60, 17);
            this.rbLessStock.TabIndex = 2;
            this.rbLessStock.TabStop = true;
            this.rbLessStock.Text = "Menor";
            this.rbLessStock.UseVisualStyleBackColor = true;
            // 
            // rbMoreStock
            // 
            this.rbMoreStock.AutoSize = true;
            this.rbMoreStock.Location = new System.Drawing.Point(65, 19);
            this.rbMoreStock.Name = "rbMoreStock";
            this.rbMoreStock.Size = new System.Drawing.Size(59, 17);
            this.rbMoreStock.TabIndex = 1;
            this.rbMoreStock.TabStop = true;
            this.rbMoreStock.Text = "Mayor";
            this.rbMoreStock.UseVisualStyleBackColor = true;
            // 
            // rbEqualStock
            // 
            this.rbEqualStock.AutoSize = true;
            this.rbEqualStock.Location = new System.Drawing.Point(6, 19);
            this.rbEqualStock.Name = "rbEqualStock";
            this.rbEqualStock.Size = new System.Drawing.Size(53, 17);
            this.rbEqualStock.TabIndex = 0;
            this.rbEqualStock.TabStop = true;
            this.rbEqualStock.Text = "Igual";
            this.rbEqualStock.UseVisualStyleBackColor = true;
            // 
            // gpbPrice
            // 
            this.gpbPrice.Controls.Add(this.rbLessPrice);
            this.gpbPrice.Controls.Add(this.rbMorePrice);
            this.gpbPrice.Controls.Add(this.rbEqualPrice);
            this.gpbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPrice.Location = new System.Drawing.Point(517, 3);
            this.gpbPrice.Name = "gpbPrice";
            this.gpbPrice.Size = new System.Drawing.Size(195, 46);
            this.gpbPrice.TabIndex = 2;
            this.gpbPrice.TabStop = false;
            this.gpbPrice.Text = "Precio";
            // 
            // rbLessPrice
            // 
            this.rbLessPrice.AutoSize = true;
            this.rbLessPrice.Location = new System.Drawing.Point(130, 19);
            this.rbLessPrice.Name = "rbLessPrice";
            this.rbLessPrice.Size = new System.Drawing.Size(60, 17);
            this.rbLessPrice.TabIndex = 2;
            this.rbLessPrice.TabStop = true;
            this.rbLessPrice.Text = "Menor";
            this.rbLessPrice.UseVisualStyleBackColor = true;
            // 
            // rbMorePrice
            // 
            this.rbMorePrice.AutoSize = true;
            this.rbMorePrice.Location = new System.Drawing.Point(65, 19);
            this.rbMorePrice.Name = "rbMorePrice";
            this.rbMorePrice.Size = new System.Drawing.Size(59, 17);
            this.rbMorePrice.TabIndex = 1;
            this.rbMorePrice.TabStop = true;
            this.rbMorePrice.Text = "Mayor";
            this.rbMorePrice.UseVisualStyleBackColor = true;
            // 
            // rbEqualPrice
            // 
            this.rbEqualPrice.AutoSize = true;
            this.rbEqualPrice.Location = new System.Drawing.Point(6, 19);
            this.rbEqualPrice.Name = "rbEqualPrice";
            this.rbEqualPrice.Size = new System.Drawing.Size(53, 17);
            this.rbEqualPrice.TabIndex = 0;
            this.rbEqualPrice.TabStop = true;
            this.rbEqualPrice.Text = "Igual";
            this.rbEqualPrice.UseVisualStyleBackColor = true;
            // 
            // txtStockProduct
            // 
            this.txtStockProduct.Location = new System.Drawing.Point(379, 67);
            this.txtStockProduct.Name = "txtStockProduct";
            this.txtStockProduct.Size = new System.Drawing.Size(132, 20);
            this.txtStockProduct.TabIndex = 4;
            this.txtStockProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockProduct_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(275, 70);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(95, 13);
            this.lblStock.TabIndex = 16;
            this.lblStock.Text = "Stock Producto";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(138, 67);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(132, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(379, 18);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 20);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(275, 21);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 13);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Precio Producto";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(8, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(61, 13);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Categoria";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(138, 18);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(132, 20);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(8, 21);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(126, 13);
            this.lblProductName.TabIndex = 12;
            this.lblProductName.Text = "Nombre del Producto";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(280, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 42);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(177, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(489, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(386, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductList.Location = new System.Drawing.Point(0, 160);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.Size = new System.Drawing.Size(787, 384);
            this.dgvProductList.TabIndex = 2;
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 644);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbStock.ResumeLayout(false);
            this.gpbStock.PerformLayout();
            this.gpbPrice.ResumeLayout(false);
            this.gpbPrice.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.TextBox txtStockProduct;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gpbStock;
        private System.Windows.Forms.RadioButton rbLessStock;
        private System.Windows.Forms.RadioButton rbMoreStock;
        private System.Windows.Forms.RadioButton rbEqualStock;
        private System.Windows.Forms.GroupBox gpbPrice;
        private System.Windows.Forms.RadioButton rbLessPrice;
        private System.Windows.Forms.RadioButton rbMorePrice;
        private System.Windows.Forms.RadioButton rbEqualPrice;
    }
}