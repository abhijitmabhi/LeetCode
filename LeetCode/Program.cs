using System;
using System.Collections.Generic;


namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.ReadKey();
        }


        public static bool IsValid(string s)
        {
            Stack<char> endings = new Stack<char>();

            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                        endings.Push(')');
                        break;
                    case '{':
                        endings.Push('}');
                        break;
                    case '[':
                        endings.Push(']');
                        break;

                    case ')':
                    case '}':
                    case ']':
                        if(endings.Count == 0 || endings.Pop() != c)
                        {
                            return false;
                        }
                        break;
                }
            }

            return endings.Count == 0;

        }

    }
}
