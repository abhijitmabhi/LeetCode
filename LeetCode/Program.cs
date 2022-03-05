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
        }
    }
}
