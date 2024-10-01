using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FileName1
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };
            var items = from word in names
                        where word.Contains("a")
                        select word;

            foreach (string s in items)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
