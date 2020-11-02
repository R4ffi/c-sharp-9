﻿using System.Collections.Generic;
using System.Linq;
using R4ffi.CSharp9.BeerDomain;

namespace R4ffi.CSharp9
{
    internal class BeerSupplier
    {
        public IEnumerable<Beer> GetBeers(int numberOfBeers)
        {
            var beers = new List<Beer>(numberOfBeers);

            for (var index = 0; index < numberOfBeers; index += 6)
            {
                beers.Add(new Beer("Felsenau Bärner Müntschi", BeerType.Lager, 4.8));
                beers.Add(new Beer("Moritz Original", BeerType.Lager, 5.4));
                beers.Add(new Beer("Degen Kobra", BeerType.IndiaPaleAle, 5.2));
                beers.Add(new Beer("Brooklyn Brewery East IPA", BeerType.IndiaPaleAle, 6.8));
                beers.Add(new Beer("Paulaner Weissbier Kristallklar", BeerType.WheatBeer, 5.2));
                beers.Add(new Beer("Erdinger Weissbier", BeerType.WheatBeer, 5.3));
            }

            return beers.Take(numberOfBeers);
        }
    }
}
