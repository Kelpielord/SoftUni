using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Orders
{
    class Product
    {
        public Product(string name, double price, int quantity)
        {
            this.ProductName = name;
            this.ProductPrice = price;
            this.ProductQuantity = quantity;
        }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "buy")
                {
                    break;
                }

                string productName = input[0];
                double productPrice = double.Parse(input[1]);
                int productQuantity = int.Parse(input[2]);

                if (!products.ContainsKey(input[0]))
                {
                    Product product = new Product(productName, productPrice, productQuantity);
                    products.Add(input[0], product);
                }
                else
                {
                    products[productName].ProductPrice = productPrice;
                    products[productName].ProductQuantity += productQuantity;
                }
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value.ProductPrice * product.Value.ProductQuantity;
                Console.WriteLine($"{product.Key:F2} -> {totalPrice:F2}");
            }
        }
    }
}
