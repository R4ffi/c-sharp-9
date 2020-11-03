using System;
using System.Collections.Generic;
using System.Linq;

namespace R4ffi.CSharp9.BeerDomain
{
    internal class Fridge
    {
        private readonly List<Beer> beers = new List<Beer>();
        private readonly Random random = new Random();

        public int TotalCapacity { get; set; }

        public int FreeCapacity => TotalCapacity - beers.Count;

        public void Fill(IEnumerable<Beer> beersToAdd)
        {
            beers.AddRange(beersToAdd.Take(FreeCapacity));

            Console.WriteLine($"Added {beersToAdd.Count()} beers to the fridge.");
        }

        public Beer GetRandomBeer()
        {
            var nextBeerIndex = random.Next(0, beers.Count);
            var selectedBeer = beers[nextBeerIndex];
            beers.RemoveAt(nextBeerIndex);

            Console.WriteLine($"Selected a {selectedBeer.Name}. Remaining beers: {beers.Count}");

            return selectedBeer;
        }
    }
}
