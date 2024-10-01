using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class demo1
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var nQuery = from tmp in n1
                         where (tmp % 2) == 0
                         select tmp;
            foreach (var s in nQuery)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
