using Microsoft.VisualBasic;
using System;

namespace HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];

            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                
                {
                    Console.Write(i + 1);
                    Console.Write(" ");
                }
            };

            Console.WriteLine(result++);

        }
    } 

}

            





