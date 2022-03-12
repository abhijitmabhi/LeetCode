using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", RemoveDuplicates(new int[] {1,1,2,3,5,5}));
            Console.ReadKey();
        }


        public static int RemoveDuplicates(int[] nums)
        {
            int k = 0;

            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[k] != nums[i])
                {
                    k++;
                    nums[k] = nums[i];
                }
            }

            return k+1;
        }
    }
}
