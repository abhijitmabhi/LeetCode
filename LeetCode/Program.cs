using System;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes([0, 1, 0, 3, 12]);
        }

        public static int[] MoveZeroes(int[] nums)
        {
            int curr = 0;

            while (curr < nums.Length)
            {
                if(curr + 1 == nums.Length)
                {
                    return nums;
                }

                if (nums[curr] == 0)
                {
                    int tempCurr = curr + 1;

                    if (tempCurr + 1 == nums.Length && nums[nums.Length - 1] == 0)
                    {
                        return nums;
                    }

                    while (tempCurr < nums.Length)
                    {
                        if (nums[tempCurr] != 0)
                        {
                            int temp = nums[curr];
                            nums[curr] = nums[tempCurr];
                            nums[tempCurr] = temp;

                            curr++;
                            break;
                        }
                        else
                        {
                           tempCurr++;
                        }
                    }
                }
                else
                {
                    curr++;
                }

            }

            return nums;
        }
    }
}
