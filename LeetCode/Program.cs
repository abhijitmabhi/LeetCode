using System;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "floight"}));
            Console.ReadKey();
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            string temp;
            for (int i = 0; i < strs[0].Length; i++)
            {
                temp = strs[0].Substring(i, 1);

                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length == i || temp != strs[j].Substring(i, 1))
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }


    }
}
