using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17.Library
{
    
    public class PrimeIndexMatcher
    {
        public readonly List<int> PrimeNumbers;

        public static int GetValue(int index)
        {
            int[] primes = new int[] { 2, 3 };
            return primes[index - 1];
        }
    }
}
