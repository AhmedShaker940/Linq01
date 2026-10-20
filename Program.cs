using LINQ.DataSources;
using LINQ.Models;

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

        }
    }
}
