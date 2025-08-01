using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_PalindromeNumber__Easy_
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Solution solution = new Solution();

                int x;

                Console.Write("Enter a number : ");
                x = int.Parse(Console.ReadLine());

            }

            public class Solution
            {
                public bool IsPalindrome(int x)
                {

                    if (x % 10 == ((x - (x % 100)) / 100) && x > 0)
                    {
                        return true;
                    }
                    else if ((x - x % 10) - ((x % 10) * 10) == 0 && x > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
        }
    }

