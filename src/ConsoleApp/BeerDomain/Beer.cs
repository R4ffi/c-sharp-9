namespace R4ffi.CSharp9.BeerDomain
{
    internal class Beer
    {
        public Beer(string name, BeerType type, double alcoholInPercent)
        {
            Name = name;
            Type = type;
            AlcoholInPercent = alcoholInPercent;
        }

        public string Name { get; private set; }

        public BeerType Type { get; private set; }

        public double AlcoholInPercent { get; private set; }

        public override bool Equals(object? obj)
        {
            return obj != null
                && obj is Beer otherBeer
                && Name == otherBeer.Name
                && Type == otherBeer.Type
                && AlcoholInPercent == otherBeer.AlcoholInPercent;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode()
                ^ Type.GetHashCode()
                ^ AlcoholInPercent.GetHashCode();
        }

        public static bool operator ==(Beer obj1, object? obj2)
        {
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Beer obj1, object? obj2)
        {
            return !(obj1.Equals(obj2));
        }
    }
}
