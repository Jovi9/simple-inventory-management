using simple_inventory_management_console.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_inventory_management_console.Functions
{
    public class InventoryManager : Connection
    {
        public bool AddProduct(Product product)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = @"insert into products (id, name, quantity_in_stock, price) values (@id, @name, @quantity, @price)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = product.Id;
                        command.Parameters.Add("@name", SqlDbType.VarChar).Value = product.Name;
                        command.Parameters.Add("@quantity", SqlDbType.Int).Value = product.QuantityInStock;
                        command.Parameters.Add("@price", SqlDbType.Decimal).Value = product.Price;

                        return command.ExecuteNonQuery() == 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("duplicate"))
                {
                    throw new Exception("Product Id is already added.");
                }
            }
            return false;
        }

        public bool RemoveProduct(int productId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"delete from products where id=@id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productId;

                    return command.ExecuteNonQuery() == 1;
                }
            }
        }

        public bool UpdateProduct(int productId, int newQuantity)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"update products set quantity_in_stock=@quantity where id=@id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                    command.Parameters.Add("@quantity", SqlDbType.Int).Value = newQuantity;

                    return command.ExecuteNonQuery() == 1;
                }
            }
        }

        public Dictionary<int, Product> ListProducts()
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"select * from products;";
                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader.GetValue(0));
                            products.Add(id, new Product()
                            {
                                Id = id,
                                Name = reader.GetString(1),
                                QuantityInStock = Convert.ToInt32(reader.GetValue(2)),
                                Price = Convert.ToDecimal(reader.GetValue(3)),
                            });
                        }
                    }
                }
            }
            return products;
        }

        public int GetTotalValue()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"select sum(quantity_in_stock * price) Total from products;";
                using (var command = new SqlCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public bool CheckProductId(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"select id from products where id=@id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        return reader.Read();
                    }
                }
            }
        }
    }
}
