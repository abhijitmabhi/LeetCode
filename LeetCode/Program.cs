using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
