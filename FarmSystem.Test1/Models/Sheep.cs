namespace FarmSystem.Test1.Models
{
    public sealed class Sheep : Animal
    {
        public Sheep() : base(null, 4, "Sheep", "baa")
        {
        }

        public Sheep(string id, int noOfLegs, string name, string sound) : base(id, noOfLegs, name, sound)
        {
        }
    }
}