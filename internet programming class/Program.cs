using System;

namespace _220314
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] s = new string[,] { { "1", "Jack", "85", "70", "65" }, { "2", "Mary", "65", "67", "62" }, { "3", "Tom", "100", "93", "91" }, { "4", "Grace", "98", "25", "50" }, { "5", "Alice", "83", "82", "87" } };


            Console.WriteLine("請輸入座號(1-5):");
            var input = Console.ReadLine();
            int num = int.Parse(input);

            switch(input)
            {
                case "1":
                    Console.WriteLine($"1.姓　　名:{s[num - 1, 1]}");
                    Console.WriteLine($"2.電腦概論:{s[num - 1, 2]}");
                    Console.WriteLine($"3.程式設計:{s[num - 1, 3]}");
                    Console.WriteLine($"4.動畫設計:{s[num - 1, 4]}");
                    break;
                case "2":
                    Console.WriteLine($"1.姓　　名:{s[num - 1, 1]}");
                    Console.WriteLine($"2.電腦概論:{s[num - 1, 2]}");
                    Console.WriteLine($"3.程式設計:{s[num - 1, 3]}");
                    Console.WriteLine($"4.動畫設計:{s[num - 1, 4]}");
                    break;
                case "3":
                    Console.WriteLine($"1.姓　　名:{s[num - 1, 1]}");
                    Console.WriteLine($"2.電腦概論:{s[num - 1, 2]}");
                    Console.WriteLine($"3.程式設計:{s[num - 1, 3]}");
                    Console.WriteLine($"4.動畫設計:{s[num - 1, 4]}");
                    break;
                case "4":
                    Console.WriteLine($"1.姓　　名:{s[num - 1, 1]}");
                    Console.WriteLine($"2.電腦概論:{s[num - 1, 2]}");
                    Console.WriteLine($"3.程式設計:{s[num - 1, 3]}");
                    Console.WriteLine($"4.動畫設計:{s[num - 1, 4]}");
                    break;
                case "5":
                    Console.WriteLine($"1.姓　　名:{s[num - 1, 1]}");
                    Console.WriteLine($"2.電腦概論:{s[num - 1, 2]}");
                    Console.WriteLine($"3.程式設計:{s[num - 1, 3]}");
                    Console.WriteLine($"4.動畫設計:{s[num - 1, 4]}");
                    break;
                default:
                    Console.WriteLine("座號超出範圍");
                    break;
            }
        }
    }
}
