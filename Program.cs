using LINQ.DataSources;
using LINQ.Models;
using System.Drawing;
using System.Numerics;

namespace Assignment01LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            //Get all products from the "Seafood" category. Print each product's name and price.
            //var seafood = Source.ProductList.Where(p => p.Category == "Seafood");
            //foreach (var p in seafood)
            //    Console.WriteLine($"{p.ProductName} {p.UnitPrice}");

            #endregion
            #region Question02
            //Get a list of only the product names from ProductList. Print each name.
            //var names = Source.ProductList.Select(p => p.ProductName);
            //foreach (var n in names)
            //    Console.WriteLine(n);

            #endregion
            #region Question03
            // Sort all products by UnitPrice (ascending). Print each product's name and price.
            //var byPrice = Source.ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var p in byPrice)
            //    Console.WriteLine($"{p.ProductName} {p.UnitPrice}");


            #endregion
            #region Question04
            //Get all products where UnitPrice is between 10 and 30
            //var between = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var p in between)
            //    Console.WriteLine(p);

            #endregion
            #region Question05
            //. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
            //var condiments = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments");
            //foreach (var p in condiments)
            //    Console.WriteLine(p);
            #endregion
            #region Question06

            /*
             * Create a new anonymous type with three properties:
             * ● Name → the product name
            ● Price → the unit price
            ● StockStatus → a string: "Available" if UnitsInStock > 0,
                otherwise "Out of Stock"
            ● Print the result.
            */

            //var Anonymous = Source.ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});
            //foreach (var a in Anonymous)
            //    Console.WriteLine(a.Name , a.Price , a.StockStatus);



            #endregion
            #region Question07
            /*
              Print each product's name along with its position (1-based)
              in the list. Expected format: 1. Chai, 2. Chang, etc.
             */

            //var Index = Source.ProductList.Select((p, i) => $"{i + 1}- {p.ProductName}");
            //foreach (var s in Index)
            //    Console.WriteLine(s);
            #endregion
            #region Question08
            //Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            //var sorted = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var p in sorted)
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            #endregion
            #region Question09
            //Get all products from the "Beverages" category, sorted by
            //UnitsInStock descending. Print name and stock.
            //var beverages = Source.ProductList.Where(p => p.Category == "Beverages")
            //                                  .OrderByDescending(p => p.UnitsInStock);
            //foreach (var p in beverages)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");

            #endregion
            #region Question10
            // Using QUERY SYNTAX with a compound from clause, list
            //all orders placed in 1997 or later showing CustomerID and
            //OrderDate.

            //var orders = Source.CustomerList
            //                   .SelectMany(c => c.Orders, (c, o) => new { c.CustomerID, o.OrderDate })
            //                   .Where(x => x.OrderDate.Year >= 1997);

            //foreach (var o in orders)
            //    Console.WriteLine($"{o.CustomerID} - {o.OrderDate}");

            #endregion
            #region Question11
            // Show position number alongside ProductName
            //var withPos = Source.ProductList.Select((p, i) => new { Position = i + 1, p.ProductName });
            //foreach (var x in withPos)
            //    Console.WriteLine($"{x.Position}: {x.ProductName}");


            #endregion
            #region Question12
            //Sort first by-word length and then by a
            //case -insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = Arr.OrderBy(w => w.Length)
            //                     .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var w in sortedWords)
            //    Console.WriteLine(w);

            // ChatGpt Used in StringComparer


            #endregion
            #region Question13
            
            #endregion
        }
    }
}
