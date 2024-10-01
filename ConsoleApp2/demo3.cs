using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class demo3
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" };

            var selectedAnimals = animals.Where(s => s.Length >= 5).Select(x => x.ToUpper());

            foreach (var animal in selectedAnimals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
