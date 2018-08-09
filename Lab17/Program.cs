using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab17.Library;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {



            var primeGenerator = new PrimesGenerator();
            primeGenerator.FillList();

            foreach (var prime in primeGenerator)
            {
                Console.WriteLine(prime);
            }
            Console.ReadKey();
        }
    }
}
