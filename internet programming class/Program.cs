using System;

namespace B10956047
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("分支測試!");

            //var input = Console.ReadLine();
            //Console.WriteLine("你輸入的是:" + input);

            double meal_cost = 100;
            int real_meal_cost = (int)meal_cost;
            int tip_percent = 15;
            int tax_percent = 8;
            String test1 = $"用餐費用:{meal_cost}元";
            String test2 = $"服務費:{tip_percent}元";
            String test3 = $"稅率:{tax_percent}元";
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test3);
            int total_cost = real_meal_cost + tip_percent + tax_percent;
            String test4 = $"用餐總費用:{total_cost}元";
            Console.WriteLine(test4);
        }
    }
}

