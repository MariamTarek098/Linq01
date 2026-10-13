using System.Linq;
using System.Collections.Generic;
using LINQ.DataSources;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
               var result = Source.ProductList
            .Where(p => p.Category == "Seafood")
            .Select(p => new { p.ProductName, p.UnitPrice });

            foreach (var p in result)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }
            Console.WriteLine("=======================");
            //Q2


            var result1 = Source.ProductList
                 .Where(p => p.Category == "Seafood")
                 .Select(p => p.ProductName );

            foreach (var p in result1)
            {
                Console.WriteLine($"{p} ");
            }
            Console.WriteLine("=======================");
            //Q3

            var result2 = Source.ProductList
                .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
         

            foreach (var p in result2)
            {
                Console.WriteLine($"{p.ProductName} ");
            }

            Console.WriteLine("=======================");

            //Q4

            var result3 = Source.ProductList
             .Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments");

            foreach (var p in result3)
            {
                Console.WriteLine($"{p.ProductName}");
            }

            Console.WriteLine("=======================");

            //Q5

            var result4 = Source.ProductList
            .Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });

            foreach (var p in result4)
            {
                Console.WriteLine($"{p.Name} - {p.Price} - {p.StockStatus}");
            }

            Console.WriteLine("=======================");

            //Q6

            var result5 = Source.ProductList
                .Select((p, index) => new
                {
                    Name = p.ProductName,
                    Position = index + 1
                });

            foreach (var p in result5)
            {
                Console.WriteLine($"{p.Position}. {p.Name}");
            }
        }
    }
}
