using System;

namespace ContainsDuplicates
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            for (int n = 0; n < nums.Length - 1; n++)
            {

                for (int j = n + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[n])
                        return true;
                }
            }
            return false;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            Console.WriteLine("Array-Eingabe");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Solution myDuplicate = new Solution();
            bool TestDuplicate = myDuplicate.ContainsDuplicate(array);

            Console.WriteLine(TestDuplicate);
            Console.ReadKey();

        }
    }
}