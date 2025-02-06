using ims_winforms.Functions;
using ims_winforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims_winforms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private bool ValidateFields()
        {
            foreach (Control control in GroupAddProduct.Controls)
            {
                if (control is TextBox txt)
                {
                    if (txt.Text.Trim() == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void LoadProducts()
        {
            InventoryManager inventory = new InventoryManager();
            var products = inventory.ListProducts(TxtSearch.Text);
            ProdDataGrid.Rows.Clear();
            foreach (var product in products.Values)
            {
                ProdDataGrid.Rows.Add(product.Id, product.Name, product.QuantityInStock, product.Price);
            }
            ProdDataGrid.ClearSelection();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in GroupAddProduct.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Clear();
                }
            }
            TxtSearch.Select();
            TxtSearch.SelectAll();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    InventoryManager inventory = new InventoryManager();

                    Product product = new Product()
                    {
                        Id = Convert.ToInt32(TxtProductId.Text),
                        Name = Convert.ToString(TxtName.Text),
                        QuantityInStock = Convert.ToInt32(TxtQuantity.Text),
                        Price = Convert.ToDecimal(TxtPrice.Text),
                    };

                    if (inventory.AddProduct(product))
                    {
                        MessageBox.Show("Product successfully added into inventory.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnClear.PerformClick();
                        LoadProducts();
                        TxtSearch.Select();
                        TxtSearch.SelectAll();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product, please try again.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Fill up the fields with valid values. Note that Product Id, Quantity, and Price must not be negative.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtProductId.Select();
                    TxtProductId.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Fill up all the fields", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void ProdDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InventoryManager inventory;
            try
            {
                if (ProdDataGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    FrmEditProduct edit = new FrmEditProduct(Convert.ToInt32(ProdDataGrid.Rows[e.RowIndex].Cells[0].Value));
                    edit.ShowDialog();
                    LoadProducts();
                    TxtSearch.Select();
                    TxtSearch.SelectAll();
                }
                if (ProdDataGrid.Columns[e.ColumnIndex].HeaderText == "Remove")
                {
                    var result = MessageBox.Show("Are you sure want to remove selected product from the inventory?", "Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        inventory = new InventoryManager();
                        if (inventory.RemoveProduct(Convert.ToInt32(ProdDataGrid.Rows[e.RowIndex].Cells[0].Value)))
                        {
                            LoadProducts();
                            MessageBox.Show("Product successfully removed from the inventory.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BtnClear.PerformClick();
                            TxtSearch.Select();
                            TxtSearch.SelectAll();
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove product, please try again.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception) { }

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void BtnGetTotalInventory_Click(object sender, EventArgs e)
        {
            InventoryManager inventory = new InventoryManager();
            MessageBox.Show($"Total Inventory Value: {inventory.GetTotalValue()}", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
