using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_inventory_management_console.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Product
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => _id = value > 0 ? value : throw new Exception("Product Id cannot be negative.");
        }
        public string Name { get; set; }

        private int _quantity;
        public int QuantityInStock
        {
            get => _quantity;
            set => _quantity = value > 0 ? value : throw new Exception("Quantity cannot be negative.");
        }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set => _price = value > 0 ? value : throw new Exception("Price cannot be negative.");
        }
    }
}
