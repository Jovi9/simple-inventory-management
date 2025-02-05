﻿using simple_inventory_management_console.Functions;
using simple_inventory_management_console.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_inventory_management_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Console Inventory Management System");

            while (true)
            {
                List<int> options = new List<int> { 1, 2, 3, 4, 5, 6, };
                int option = 0;
                while (!options.Contains(option))
                {
                    try
                    {
                        Console.WriteLine("Choose from the following options which operation you wish to perform.");
                        Console.WriteLine("[1] List Products");
                        Console.WriteLine("[2] Add Product");
                        Console.WriteLine("[3] Update Product");
                        Console.WriteLine("[4] Remove Product");
                        Console.WriteLine("[5] Total Inventory");
                        Console.WriteLine("[6] Exit");

                        Console.Write("Enter Option: ");
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException) { }

                    if (!options.Contains(option))
                    {
                        Console.WriteLine("Please select a valid option, please try again.\n");
                    }
                }

                try
                {
                    switch (option)
                    {
                        case 1:
                            ListProducts();
                            Console.WriteLine();
                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("Please fill up the following product fields.");
                                Console.Write("Product ID: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Name: ");
                                string name = Console.ReadLine();

                                Console.Write("Quantity: ");
                                int quantity = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Price: ");
                                decimal price = Convert.ToDecimal(Console.ReadLine());

                                Product product = new Product()
                                {
                                    Id = id,
                                    Name = name,
                                    QuantityInStock = quantity,
                                    Price = price,
                                };

                                AddProduct(product);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Please fill up valid values for each fields.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine();

                            ListProducts();
                            break;
                        case 3:
                            try
                            {
                                Console.WriteLine("Please fill up the fields of product id and the value of new quantity.");
                                Console.Write("Product ID: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Quantity: ");
                                int quantity = Convert.ToInt32(Console.ReadLine());

                                UpdateProduct(id, quantity);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Please fill up valid values for each fields.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine();

                            ListProducts();

                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine("Please fill up the product id of the product to be removed.");
                                Console.Write("Product ID: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                RemoveProduct(id);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Please fill up valid values for each fields.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine();

                            ListProducts();
                            break;
                        case 5:
                            ListProducts();
                            GetTotalInventory();
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
        }

        private static void ListProducts()
        {
            InventoryManager inventoryManager = new InventoryManager();
            var products = inventoryManager.ListProducts();
            if (products.Count() == 0)
            {
                Console.WriteLine("No Products listed in Inventory.");
            }
            else
            {
                Console.WriteLine("PRODUCT ID\tNAME\t\t\tQUANTITY\tPRICE");
                foreach (var product in products.Values)
                {
                    Console.Write($"{product.Id}\t\t{product.Name}\t\t\t{product.QuantityInStock}\t\t{product.Price}\n");
                }
            }
            Console.WriteLine();
        }

        private static bool AddProduct(Product product)
        {
            InventoryManager inventoryManager = new InventoryManager();
            if (inventoryManager.AddProduct(product))
            {
                Console.WriteLine("Product succesfully added into inventory.\n");
                return true;
            }
            else
            {
                Console.WriteLine("Failed to add product, please try again.\n");
                return false;
            }
        }

        private static bool UpdateProduct(int productId, int quantity)
        {
            InventoryManager inventoryManager = new InventoryManager();
            if (inventoryManager.CheckProductId(productId))
            {
                if (inventoryManager.UpdateProduct(productId, quantity))
                {
                    Console.WriteLine("Product quantity succesfully updated.\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("Failed to update product quantity, please try again.\n");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No product Id found, please try again and make sure to enter a valid product Id.");
                return false;
            }
        }

        private static bool RemoveProduct(int productId)
        {
            InventoryManager inventoryManager = new InventoryManager();
            if (inventoryManager.CheckProductId(productId))
            {
                if (inventoryManager.RemoveProduct(productId))
                {
                    Console.WriteLine($"Product {productId} has been removed.\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("Failed to remove product, please try again.\n");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No product Id found, please try again and make sure to enter a valid product Id.");
                return false;
            }
        }

        private static void GetTotalInventory()
        {
            InventoryManager inventoryManager = new InventoryManager();
            var totalValue = inventoryManager.GetTotalValue();
            if (totalValue < 0)
            {
                Console.WriteLine("No Products listed in Inventory.");
            }
            else
            {
                Console.WriteLine($"Total Value of Inventory: {totalValue}");
            }
            Console.WriteLine();
        }
    }
}
