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
<<<<<<< HEAD
            Console.WriteLine(IsPalindrome(121));
            Console.ReadKey();
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int number = x;
            int reverse = 0;

            while (x != 0)
            {
                int reminder = x % 10;
                reverse = reverse * 10 + reminder;
                x /= 10;

            }
            return reverse == number ? true : false;
            Console.WriteLine("{0}", IsValid("(({}[({})]))"));
=======
            Console.WriteLine("{0}", RemoveDuplicates(new int[] {1,1,2,3,5,5}));
>>>>>>> Problem26_RemoveDuplicateFromSortedArray
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

<<<<<<< HEAD
            return endings.Count == 0;

            Console.Write("[{0}]", string.Join(", ", PlusOne(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 })));
            Console.ReadKey();
        }

        public static int[] PlusOne(int[] digits)
        {
            string joined = String.Empty;
            foreach(int digit in digits)
            {
                joined += digit.ToString();
            }
            BigInteger number = BigInteger.Parse(joined);
            number++;
            var arr = number.ToString().Select(x =>int.Parse(x.ToString())).ToArray();
            return arr;

=======
            return k+1;
>>>>>>> Problem26_RemoveDuplicateFromSortedArray
        }
    }
}
