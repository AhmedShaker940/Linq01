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
            var seafood = Source.ProductList.Where(p => p.Category == "Seafood");
            foreach (var p in seafood)
                Console.WriteLine($"Product Name : {p.ProductName} , Unit Price : {p.UnitPrice}");

            #endregion


        }
    }
}
