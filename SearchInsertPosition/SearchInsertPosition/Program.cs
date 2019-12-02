using System;

namespace SearchInsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {

            for (int n = 0; n < nums.Length; n++)
            {
                if (nums[n] == target)
                    return n;
                else if (nums[n] > target)
                    return n;

            }
            return nums.Length;


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            Console.WriteLine("Array-Eingabe");
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Target-Eingabe");
            int trgt = Convert.ToInt32(Console.ReadLine());
            Solution mysolution = new Solution();

            int indx = mysolution.SearchInsert(numbers, trgt);

            Console.WriteLine("{0}", indx);
            Console.ReadLine();

        }
    }
}