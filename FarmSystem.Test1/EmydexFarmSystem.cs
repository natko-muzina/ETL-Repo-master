using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private readonly IList<IAnimal> animals = new List<IAnimal>();

        public event EventHandler FarmEmptyEvent;

        //TEST 1
        public void Enter(IAnimal animal)
        {
            //Hold all the animals so it is available for future activities
            animals.Add(animal);
            Console.WriteLine($"{animal.Name} has entered the Emydex farm");
        }

        //TEST 2
        public void MakeNoise()
        {
            foreach (var animal in animals)
                animal.Talk();
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (var animal in animals)
                if (animal is IMilkableAnimal milkable)
                    milkable.ProduceMilk();
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            foreach (var animal in animals.ToList())
            {
                // yup, it's running away
                animal.Run();
                animals.Remove(animal);
                Console.WriteLine($"{animal.Name} has left the farm");
            }

            if (animals.Count == 0)
                FarmEmptyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}