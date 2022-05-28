namespace FarmSystem.Test1.Models
{
    public sealed class Cow : MilkableAnimal
    {
        public Cow() : base(null, 4, "Cow", "Moo")
        {
        }

        public Cow(string id, int noOfLegs, string name, string sound) : base(id, noOfLegs, name, sound)
        {
        }
    }
}