using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class demo4
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 6, 0, 999, 11, 443, 6, 1, 24, 54 };

            
            var top5 = numbers.OrderByDescending(x => x).Take(5);

            
            foreach (var num in top5)
            {
                Console.WriteLine(num);
            }
        }
    }
}
