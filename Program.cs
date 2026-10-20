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
            //    Console.WriteLine($"Product Name : {p.ProductName} , Unit Price : {p.UnitPrice}");

            #endregion
            #region Question02
            //Get a list of only the product names from ProductList. Print each name.
            //var names = Source.ProductList.Select(p => p.ProductName);
            //foreach (var n in names)
            //    Console.WriteLine(n);

            #endregion

        }
    }
}
