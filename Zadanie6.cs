using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie51
{
    public class Zadanie6
    {
        public int CountOccurrences(int[] array, int element)
        {
            return array.Count(e=> e==element);
        }
    }
}
