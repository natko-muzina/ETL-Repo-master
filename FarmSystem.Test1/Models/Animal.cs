using System;

namespace FarmSystem.Test1.Models
{
    public abstract class Animal : IAnimal
    {
        public virtual string Id { get; protected set; }
        public virtual int NoOfLegs { get; protected set; }
        public virtual string Sound { get; protected set; }
        public virtual string Name { get; protected set; }

        public Animal(string id, int noOfLegs, string name, string sound)
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString() : id;
            NoOfLegs = noOfLegs;
            Name = string.IsNullOrWhiteSpace(name) ? this.GetType().Name : name;
            Sound = sound;
        }

        public virtual void Run()
        {
            Console.WriteLine($"{Name} is running");
        }

        public virtual void Talk()
        {
            var talk = string.IsNullOrWhiteSpace(Sound) ? null : $"says {Sound}";
            Console.WriteLine($"{Name} {(talk == null ? "stays quiet" : talk)}");
        }

        public virtual void Walk()
        {
            Console.WriteLine($"{Name} is walking");
        }
    }
}