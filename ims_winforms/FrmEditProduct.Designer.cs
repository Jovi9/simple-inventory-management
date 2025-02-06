namespace ims_winforms
{
    partial class FrmEditProduct
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
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtProductId = new System.Windows.Forms.TextBox();
            this.LblProductId = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(171, 121);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(178, 32);
            this.TxtPrice.TabIndex = 5;
            this.TxtPrice.TabStop = false;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(167, 94);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(58, 24);
            this.LblPrice.TabIndex = 15;
            this.LblPrice.Text = "Price";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantity.Location = new System.Drawing.Point(27, 121);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(138, 32);
            this.TxtQuantity.TabIndex = 0;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(23, 94);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(86, 24);
            this.LblQuantity.TabIndex = 14;
            this.LblQuantity.Text = "Quantity";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(171, 46);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(178, 32);
            this.TxtName.TabIndex = 4;
            this.TxtName.TabStop = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(167, 19);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(65, 24);
            this.LblName.TabIndex = 12;
            this.LblName.Text = "Name";
            // 
            // TxtProductId
            // 
            this.TxtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductId.Location = new System.Drawing.Point(27, 46);
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.ReadOnly = true;
            this.TxtProductId.Size = new System.Drawing.Size(138, 32);
            this.TxtProductId.TabIndex = 3;
            this.TxtProductId.TabStop = false;
            // 
            // LblProductId
            // 
            this.LblProductId.AutoSize = true;
            this.LblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductId.Location = new System.Drawing.Point(23, 19);
            this.LblProductId.Name = "LblProductId";
            this.LblProductId.Size = new System.Drawing.Size(107, 24);
            this.LblProductId.TabIndex = 9;
            this.LblProductId.Text = "Product ID";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(27, 182);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(322, 40);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update Product";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Red;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(27, 240);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(322, 40);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmEditProduct
            // 
            this.AcceptButton = this.BtnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(379, 292);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtProductId);
            this.Controls.Add(this.LblProductId);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FrmEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtProductId;
        private System.Windows.Forms.Label LblProductId;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
    }
}