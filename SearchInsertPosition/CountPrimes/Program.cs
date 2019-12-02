using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CountPrimes
{
    public class Solution
    {
        public bool IsPrime(int numb)
        {
            for (int n = 2; n < numb; n++)
            {
                for (int div = 2; div < n; div++)
                {
                    if (n == 2) 
                    {
                        return true;

                    }
                    else if (numb % div == 0)
                    {
                        return false;

                    }
   

                }
            }

            return true;

        }

        public int CountPrimes(int numb)
        {

            int count = 0;
            for(int n = 2; n<numb;n++)
                if (IsPrime(n))
                    count++;
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int numb = Convert.ToInt32(Console.ReadLine());

            Solution mysolution = new Solution();

            int count = mysolution.CountPrimes(numb);
            bool Test = mysolution.IsPrime(numb);
            


            Console.WriteLine(count);
            Console.ReadLine();
        }
    }


}
    


