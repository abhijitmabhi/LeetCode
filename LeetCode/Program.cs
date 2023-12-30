using System;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes([1,0,1,0,12]);
        }

        // Add a test comment
        public static void MoveZeroes(int[] nums)
        {
            int lastZeroPos = 0;

            for (int i =0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[lastZeroPos], nums[i]) = (nums[i], nums[lastZeroPos]);
                    lastZeroPos++;
                }
            }
        }
    }
}
