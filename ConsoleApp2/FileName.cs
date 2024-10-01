using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FileName
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };
            foreach (string item in names.OrderBy(s => s))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
