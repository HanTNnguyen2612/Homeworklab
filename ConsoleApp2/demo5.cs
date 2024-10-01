using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class demo5
    {
        public static void OrderByEx1()
        {
            // Create an array of Pet objects
            Pet[] pets = {
            new Pet { Name = "Barley", Age = 8 },
            new Pet { Name = "Boots", Age = 4 },
            new Pet { Name = "Whiskers", Age = 1 }
        };

            // Order the pets by Age in ascending order
            IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age);

            // Display the sorted pets
            foreach (var pet in query)
            {
                Console.WriteLine($"{pet.Name} is {pet.Age} years old.");
            }
        }
        static void Main(string[] args)
        {
            OrderByEx1();
        }
    }
}
