using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Product
    {
        private Product product;

        public string Category { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
        public String ImageLocation { get; set; }

        public Product(string category, int productID, string name, string description, decimal price, int quantity, string color, string imageLocation)
        {
            Category = category;
            ProductID = productID;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Color = color;
            ImageLocation = imageLocation;
        }

        public Product(Product p)
        {
            Category = p.Category;
            ProductID = p.ProductID;
            Name = p.Name;
            Description = p.Description;
            Price = p.Price;
            Quantity = p.Quantity;
            Color = p.Color;
            ImageLocation = p.ImageLocation;
        }
    }
    static class productList
    {
        public static List<Product> items = new List<Product>();
    }
}
