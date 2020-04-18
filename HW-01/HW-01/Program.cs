using System;

namespace HW_01
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
                    result += nums[i];
                }
            }

            Console.WriteLine("Сумма четных чисел от 1 до 20 = {0}", result);

            Console.ReadLine();
        }
    }
}
