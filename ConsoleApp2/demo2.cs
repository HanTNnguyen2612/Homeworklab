using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class demo2
    {
        static void Main(string[] args)
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var nQuery = from tmp in n1
                         where tmp > 0
                         where tmp < 12
                         select tmp;
            foreach (var s in nQuery)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
