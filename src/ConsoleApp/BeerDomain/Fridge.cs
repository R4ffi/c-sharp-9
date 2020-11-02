using System;
using System.Collections.Generic;

namespace R4ffi.CSharp9.BeerDomain
{
    internal class Fridge
    {
        private readonly List<Beer> beers;
        private readonly Random random;

        public Fridge(int capacity)
        {
            Capacity = capacity;
            beers = new List<Beer>(capacity);
            random = new Random();
        }

        public int Capacity { get; private set; }

        public void Fill(BeerSupplier beerSupplier)
        {
            Console.WriteLine("Filling the fridge with beer...");

            var numberOfBeersToAdd = Capacity - beers.Count;
            beers.AddRange(beerSupplier.GetBeers(numberOfBeersToAdd));

            Console.WriteLine($"Added {numberOfBeersToAdd} beers to the fridge.");
        }

        public Beer GetBeer()
        {
            Console.WriteLine("Getting a random beer from the fridge...");

            var nextBeerIndex = random.Next(0, beers.Count);
            var selectedBeer = beers[nextBeerIndex];
            beers.RemoveAt(nextBeerIndex);

            Console.WriteLine($"Selected a {selectedBeer.Name}. Remaining beers: {beers.Count}");

            return selectedBeer;
        }
    }
}
