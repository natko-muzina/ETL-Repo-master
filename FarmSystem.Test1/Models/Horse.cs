namespace FarmSystem.Test1.Models
{
    public sealed class Horse : Animal
    {
        public Horse() : base(null, 4, "Horse", "neigh")
        {
        }

        public Horse(string id, int noOfLegs, string name, string sound) : base(id, noOfLegs, name, sound)
        {
        }
    }
}