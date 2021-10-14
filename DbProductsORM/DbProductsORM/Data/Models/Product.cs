using DbProductsORM.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProductsORM.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

    }
    private void Add()
    {
        Product product = new Product();
        Console.WriteLine("Enter name:");
        product.Name = Console.ReadLine();
        Console.WriteLine("Enter price:");
        product.Price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter stock:");
        product.Stock = int.Parse(Console.ReadLine());
        productBusiness.Add(product);
    }
}
