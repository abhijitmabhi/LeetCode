using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
            Console.ReadKey();
        }

        public static int RomanToInt(string s)
        {
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {

                switch (s[i])
                {

                    case 'I':
                        if ((i + 1 != s.Length) && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                        {
                            num += -1;
                        }
                        else
                        {
                            num += 1;
                        }
                        break;
                    case 'V':
                        num += 5;
                        break;
                    case 'X':
                        if ((i + 1 != s.Length) && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                        {
                            num += -10;
                        }
                        else
                        {
                            num += 10;
                        }
                        break;
                    case 'L':
                        num += 50;
                        break;
                    case 'C':
                        if ((i + 1 != s.Length) && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                        {
                            num += -100;
                        }
                        else
                        {
                            num += 100;
                        }
                        break;
                    case 'D':
                        num += 500;
                        break;
                    case 'M':
                        num += 1000;
                        break;

                }
            }

            return num;
        }


    }
}
