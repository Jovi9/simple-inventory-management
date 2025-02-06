using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims_winforms.Models
{
    /// <summary>
    /// This class have four properties Id, Name, Quantity and Price.
    /// The Id, Quantity, and Price have a conditional statement that will check whether the value that will be set is a non-negative number. This is to ensure that the values are valid in each fields. If the value is a negative number then the program will throw an exception.
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
            set => _quantity = value >= 0 ? value : throw new Exception("Quantity cannot be negative.");
        }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set => _price = value > 0 ? value : throw new Exception("Price cannot be negative.");
        }
    }
}
