using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 5, 5 }));
            Console.ReadKey();
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> myHash = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!myHash.Add(nums[i]))
                {
                    return true;
                }
            }

            return false;

        }

    }
}
