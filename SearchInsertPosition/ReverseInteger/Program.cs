using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            int rev = 0;
            while (x > 0 || x<0)
            {
                rev = (rev * 10) + (x % 10);
                x = x / 10;
                
            }
            return (rev);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eingabe");
            int num = Convert.ToInt32(Console.ReadLine());
            Solution mysolution = new Solution();
            int rev = mysolution.Reverse(num);

            Console.WriteLine(rev);
            Console.ReadLine();

        }
    }
}
