using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ims_winforms.Models;

namespace ims_winforms.Functions
{
    public class InventoryManager : Connection
    {
        /// <summary>
        /// This function returns a boolean value if the product is successfully added or not. It accepts one parameter which is the instance of Product class. This function performs the insert operation to the table and uses a parameterized query to prevent SQL Injection. And will also throw an exception if the product id that will be inserted is already added into the products table.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// This function also returns a boolean value whether the product is successfuly removed or not. And this accepts one parameter which is the product id. And also uses a parameterized query.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This function updates the quantity of the specific product and will return a boolean value whether the quantity is successfully updated or not. THis accepts two parameteres which is the product id and the new quantity of the product. And also uses parameterized query.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="newQuantity"></param>
        /// <returns></returns>
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


        /// <summary>
        /// This function retrieves all the products stored in the products table. THe retrieved records are stored in Dictionary which will be used to access the retrieved records. THe dictionary value is the instance of the Product class, so each Product retrieved will be stored in the Dictionary. After retrieving all the products, the dictionary will be returned and if no products is available in the inventory this function will return an empty dictionary.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Product> ListProducts(string search = "")
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"select * from products where name like @name;";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = $"%{search}%";
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

        public Product GetProduct(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"select * from products where id=@id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.Read())
                        {
                            return new Product()
                            {
                                Id = id,
                                Name = reader.GetString(1),
                                QuantityInStock = Convert.ToInt32(reader.GetValue(2)),
                                Price = Convert.ToDecimal(reader.GetValue(3)),
                            };
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// This function calculates the total inventory value quantity * price of each product. And returns the grand total.
        /// </summary>
        /// <returns></returns>
        public int GetTotalValue()
        {
            try
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
            }catch(InvalidCastException ex)
            {
                if (ex.Message.Contains("DBNull"))
                {
                    return 0;
                }
            }
            return 0;
        }

        /// <summary>
        /// This function is used to check whether the product is already added in the inventory or not, this will return a boolean value if the product is found or no. This accepts one paramtere which is the product id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
