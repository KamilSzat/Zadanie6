using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var z = new Zadanie6();
            int[] array = { 1, 2, 3, 2, 4, 2 };
            int count = z.CountOccurrences(array, 2);

            Console.WriteLine($"Liczba wystąpień: {count}");
            Console.ReadKey();
        }
    }
}
