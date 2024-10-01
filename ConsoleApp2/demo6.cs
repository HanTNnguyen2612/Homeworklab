using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PetOwner
    {
        public string Name { get; set; }
        public List<string> Pets { get; set; }
    }

    internal class demo6
    {
        public static void SelectManyEx3()
        {
            // Create an array of PetOwner objects
            PetOwner[] petOwners = {
            new PetOwner { Name="Higa", Pets = new List<string>{ "Scruffy", "Sam" } },
            new PetOwner { Name="Ashkenazi", Pets = new List<string>{ "Walker", "Sugar" } },
            new PetOwner { Name="Price", Pets = new List<string>{ "Scratches", "Diesel" } },
            new PetOwner { Name="Hines", Pets = new List<string>{ "Dusty" } }
        };

            // Use SelectMany to flatten the list of pets and filter based on pet names starting with 'S'
            var query = petOwners.SelectMany(
                petOwner => petOwner.Pets,              // Flatten Pets list
                (petOwner, petName) => new { petOwner, petName } // Combine each PetOwner with their pet
            )
            .Where(ownerAndPet => ownerAndPet.petName.StartsWith("S")) // Filter pets whose names start with 'S'
            .Select(ownerAndPet => new
            {
                Owner = ownerAndPet.petOwner.Name,
                Pet = ownerAndPet.petName
            });

            // Display the results
            foreach (var result in query)
            {
                Console.WriteLine($"{result.Owner} owns {result.Pet}");
            }
        }

        static void Main(string[] args)
        {
            SelectManyEx3();
        }
    }
}
