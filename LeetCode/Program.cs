using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
            Console.ReadKey()
;        }

        public static bool IsPalindrome(int x)
        {
            if(x < 0)
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
        }
    }
}
