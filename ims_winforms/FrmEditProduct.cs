using ims_winforms.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims_winforms
{
    public partial class FrmEditProduct : Form
    {
        public int Id;
        public FrmEditProduct(int id)
        {
            InitializeComponent();

            this.Id = id;
            InventoryManager inventory = new InventoryManager();
            var product = inventory.GetProduct(id);
            TxtProductId.Text = product.Id.ToString();
            TxtName.Text = product.Name;
            TxtQuantity.Text = product.QuantityInStock.ToString();
            TxtPrice.Text = product.Price.ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtQuantity.Text.Trim() == "")
            {
                 MessageBox.Show("Fill enter new quantity of the product.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InventoryManager inventory = new InventoryManager();
                if (inventory.UpdateProduct(Convert.ToInt32(TxtProductId.Text), Convert.ToInt32(TxtQuantity.Text)))
                {
                    MessageBox.Show("Product quantity successfully updated.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to update product quantity, please try again.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
