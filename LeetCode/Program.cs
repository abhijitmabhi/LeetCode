using System;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5 ,6}, 4));
            Console.ReadKey();
        }

        public static int SearchInsert(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target || nums[i] > target)
                {
                    return i;
                }
            }

            return nums.Length;
        }


    }
}
