using System;
using R4ffi.CSharp9.BeerDomain;

namespace R4ffi.CSharp9
{
    public class Program
    {
        public static void Main()
        {
            var beerSupplier = new BeerSupplier();
            var fridge = new Fridge { TotalCapacity = 5 };

            var beersToAdd = beerSupplier.GetDifferentBeers(fridge.FreeCapacity);
            fridge.Fill(beersToAdd);

            var beerNo1 = fridge.GetRandomBeer();
            Console.WriteLine(GetMyComment(beerNo1));

            var beerNo2 = fridge.GetRandomBeer();
            if (beerNo1 == beerNo2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Once again?? I'd like some variety! :-(");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mmmh, I've never tried that before! :-D");
            }
        }

        private static string GetMyComment(Beer beer)
        {
            if (!(beer.Type is BeerType.WheatBeer))
            {
                if (beer.AlcoholInPercent < 4)
                {
                    return "Mmmh... Refreshing!";
                }

                if (beer.AlcoholInPercent >= 4 && beer.AlcoholInPercent < 9)
                {
                    return "Just the way I like it!";
                }

                return "This is too strong for me"!;
            }
            else
            {
                return "I don't like wheat beer!";
            }
        }
    }
}
