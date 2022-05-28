using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1.Models
{
    public abstract class MilkableAnimal : Animal, IMilkableAnimal
    {
        public MilkableAnimal(string id, int noOfLegs, string name, string sound) : base(id, noOfLegs, name, sound)
        {
        }

        public void ProduceMilk()
        {
            Console.WriteLine($"{Name} producted milk");
        }
    }
}