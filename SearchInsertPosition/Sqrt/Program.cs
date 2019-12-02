using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt
{
    public class Solution
    {
        public int MySqrt(int x)
        {

            double res = Math.Truncate(Math.Sqrt(x));

            int sqrt = Convert.ToInt32(res);

            return sqrt;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int x = Convert.ToInt32(Console.ReadLine());

            Solution mySolution = new Solution();

            int sqrt = mySolution.MySqrt(x);

            Console.WriteLine(sqrt);
            Console.ReadLine();
        }
    }
}
