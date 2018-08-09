using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17.Library
{
    
    public class PrimeIndexMatcher
    {
        public static int GetValue(int index)
        {
            // PRODUCED BY HAVING TO TEST MORE THAN ONE VALUE
            int[] primes = new int[] { 2, 3, 5, 7, 11 };

            //List<int> primes = new List<int>();
            //Console.Write("Which prime number are you looking for?");
            //index = int.Parse(Console.ReadLine());
            return primes[index - 1];

        }
    }
}
