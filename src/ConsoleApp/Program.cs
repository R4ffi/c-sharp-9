using System;
using R4ffi.CSharp9.BeerDomain;

namespace R4ffi.CSharp9
{
    public class Program
    {
        public static void Main()
        {
            var beerSupplier = new BeerSupplier();
            var fridge = new Fridge(5);
            fridge.Fill(beerSupplier);

            var beerNo1 = fridge.GetBeer();
            var beerNo2 = fridge.GetBeer();

            if (beerNo1 == beerNo2)
            {
                Console.WriteLine("Once again?? I'd like some variety!");
            }

            fridge.Fill(beerSupplier);
        }
    }
}
