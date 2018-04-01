using System;
using Newtonsoft.Json;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.ID = 101;
            p1.Name = "Apple";
            p1.Price = 1.5;

            // Product p2 = new Product();
            // p2.ID = 102;
            // p2.Name = "Orange";
            // p2.Price = 1.0;

            // Product p3 = new Product();
            // p3.ID = 103;
            // p3.Name = "Banana";
            // p3.Price = 0.75;

            var json = JsonConvert.SerializeObject(p1);

            System.Console.WriteLine(json);

            Product p2 = JsonConvert.DeserializeObject<Product>(json);
            
            System.Console.WriteLine($"ID: {p2.ID} Name: {p2.Name} Price: {p2.Price}");



        }
    }
}
