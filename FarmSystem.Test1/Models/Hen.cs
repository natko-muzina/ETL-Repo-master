namespace FarmSystem.Test1.Models
{
    public sealed class Hen : Animal
    {
        public Hen() : base(null, 2, "Hen", "CLUCKAAAAAWWWWK")
        {
        }

        public Hen(string id, int noOfLegs, string name, string sound) : base(id, noOfLegs, name, sound)
        {
        }
    }
}