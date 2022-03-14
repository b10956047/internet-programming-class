using System;

namespace _220314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數字:");

            var input = Console.ReadLine();
            int num = int.Parse(input);

            if (num % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (num >= 2 && num <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (num >= 6 && num <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
