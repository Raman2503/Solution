using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Divisor
{
    public class Solution
    {
        public bool DivisorGame(int N, int x)
        {
            return (N % x == 0);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N zwischen 1 und 1000");
            int N = Convert.ToInt32(Console.ReadLine());

            Solution mySolution = new Solution();

            Console.WriteLine("Eingabe x");
            int x = Convert.ToInt32(Console.ReadLine());

            while (N > x)
            {
                bool test = mySolution.DivisorGame(N,x);

                Console.WriteLine("{0}", test);
                Console.ReadLine();
            }
        }
    }
}
