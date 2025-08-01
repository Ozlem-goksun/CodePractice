using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TwoSum__Easy_
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Solution solution = new Solution();

                int[] nums;
                int target, num;

                Console.Write("Enter the length of the array:");
                num = int.Parse(Console.ReadLine());

                nums = new int[num];

                for (int i = 0; i < num; i++)
                {
                    Console.Write(i + ". Element : ");
                    nums[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter the target num: ");
                target = int.Parse(Console.ReadLine());

                int[] result = solution.TwoSum(nums, target);

                if (result.Length > 0)
                {
                    Console.WriteLine($"Result: [{result[0]}, {result[1]}]");
                }
                else
                {
                    Console.WriteLine("Couldn't found a match.");
                }
            }

            public class Solution
            {
                public int[] TwoSum(int[] nums, int target)
                {
                    for (int i = 0; i < nums.Count() - 1; i++)
                    {
                        for (int j = i + 1; j < nums.Count(); j++)
                        {
                            if (nums[i] + nums[j] == target)
                            {
                                return new int[2] { i, j };
                            }
                        }
                    }
                    return new int[0];
                }
            }
        }
    }
