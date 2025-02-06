namespace ims_winforms
{
    partial class FrmMain
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.GroupAddProduct = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtProductId = new System.Windows.Forms.TextBox();
            this.LblProductId = new System.Windows.Forms.Label();
            this.ProdDataGrid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnGetTotalInventory = new System.Windows.Forms.Button();
            this.PanelHeader.SuspendLayout();
            this.GroupAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.BtnGetTotalInventory);
            this.PanelHeader.Controls.Add(this.TxtSearch);
            this.PanelHeader.Controls.Add(this.LblSearch);
            this.PanelHeader.Controls.Add(this.GroupAddProduct);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(837, 194);
            this.PanelHeader.TabIndex = 0;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(198, 144);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(276, 32);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(12, 150);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(160, 24);
            this.LblSearch.TabIndex = 11;
            this.LblSearch.Text = "Search Product:";
            // 
            // GroupAddProduct
            // 
            this.GroupAddProduct.Controls.Add(this.BtnClear);
            this.GroupAddProduct.Controls.Add(this.BtnAddProduct);
            this.GroupAddProduct.Controls.Add(this.TxtPrice);
            this.GroupAddProduct.Controls.Add(this.LblPrice);
            this.GroupAddProduct.Controls.Add(this.TxtQuantity);
            this.GroupAddProduct.Controls.Add(this.LblQuantity);
            this.GroupAddProduct.Controls.Add(this.TxtName);
            this.GroupAddProduct.Controls.Add(this.LblName);
            this.GroupAddProduct.Controls.Add(this.TxtProductId);
            this.GroupAddProduct.Controls.Add(this.LblProductId);
            this.GroupAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupAddProduct.Location = new System.Drawing.Point(12, 12);
            this.GroupAddProduct.Name = "GroupAddProduct";
            this.GroupAddProduct.Size = new System.Drawing.Size(749, 121);
            this.GroupAddProduct.TabIndex = 2;
            this.GroupAddProduct.TabStop = false;
            this.GroupAddProduct.Text = "Add Product";
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(614, 20);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(129, 32);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProduct.Location = new System.Drawing.Point(614, 72);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(129, 32);
            this.BtnAddProduct.TabIndex = 5;
            this.BtnAddProduct.Text = "Add Product";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(468, 72);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(115, 32);
            this.TxtPrice.TabIndex = 4;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(464, 45);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(58, 24);
            this.LblPrice.TabIndex = 7;
            this.LblPrice.Text = "Price";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantity.Location = new System.Drawing.Point(347, 72);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(115, 32);
            this.TxtQuantity.TabIndex = 3;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(343, 45);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(86, 24);
            this.LblQuantity.TabIndex = 5;
            this.LblQuantity.Text = "Quantity";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(163, 72);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(178, 32);
            this.TxtName.TabIndex = 2;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(159, 45);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(65, 24);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Name";
            // 
            // TxtProductId
            // 
            this.TxtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductId.Location = new System.Drawing.Point(19, 72);
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.Size = new System.Drawing.Size(138, 32);
            this.TxtProductId.TabIndex = 1;
            // 
            // LblProductId
            // 
            this.LblProductId.AutoSize = true;
            this.LblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductId.Location = new System.Drawing.Point(15, 45);
            this.LblProductId.Name = "LblProductId";
            this.LblProductId.Size = new System.Drawing.Size(107, 24);
            this.LblProductId.TabIndex = 1;
            this.LblProductId.Text = "Product ID";
            // 
            // ProdDataGrid
            // 
            this.ProdDataGrid.AllowUserToAddRows = false;
            this.ProdDataGrid.AllowUserToDeleteRows = false;
            this.ProdDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colQuantity,
            this.colPrice,
            this.colEdit,
            this.colDelete});
            this.ProdDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdDataGrid.Location = new System.Drawing.Point(0, 194);
            this.ProdDataGrid.Name = "ProdDataGrid";
            this.ProdDataGrid.ReadOnly = true;
            this.ProdDataGrid.RowHeadersWidth = 51;
            this.ProdDataGrid.RowTemplate.Height = 24;
            this.ProdDataGrid.Size = new System.Drawing.Size(837, 457);
            this.ProdDataGrid.TabIndex = 1;
            this.ProdDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDataGrid_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Product ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity In Stock";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Remove";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Remove";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // BtnGetTotalInventory
            // 
            this.BtnGetTotalInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetTotalInventory.Location = new System.Drawing.Point(530, 144);
            this.BtnGetTotalInventory.Name = "BtnGetTotalInventory";
            this.BtnGetTotalInventory.Size = new System.Drawing.Size(225, 32);
            this.BtnGetTotalInventory.TabIndex = 12;
            this.BtnGetTotalInventory.Text = "Get Total Inventory";
            this.BtnGetTotalInventory.UseVisualStyleBackColor = true;
            this.BtnGetTotalInventory.Click += new System.EventHandler(this.BtnGetTotalInventory_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 651);
            this.Controls.Add(this.ProdDataGrid);
            this.Controls.Add(this.PanelHeader);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Inventory Management System";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.GroupAddProduct.ResumeLayout(false);
            this.GroupAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.DataGridView ProdDataGrid;
        private System.Windows.Forms.GroupBox GroupAddProduct;
        private System.Windows.Forms.Label LblProductId;
        private System.Windows.Forms.TextBox TxtProductId;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Button BtnGetTotalInventory;
    }
}

