using System;
using ProductSelling.Models;
namespace ProductSelling
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Kartof";
            product.Price = 13.50;
            product.Count = 7;
            product.Sell();
            product.Sell();
            Console.WriteLine($"Hazirda {product.Name} mehsulunu  {product.Price} AZN qiymetine satiriq.");
            Console.WriteLine($"Indice Ferrux dayi bir qeder {product.Name} aldi ve elimizde {product.Count} dene {product.Name} qaldi.");
            Console.WriteLine($"Bununla da { product.TotalIncome} AZN gelir elde etdik.");
            Console.WriteLine("Urra! Bugun de ac qalmadiq! Tesekkurler Ferrux dayi!");
        }
    }
}
