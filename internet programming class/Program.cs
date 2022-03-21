using System;

namespace internet_programming_class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRandom(1,100);

           static private int MyRandom(int minNum, int maxNum)
           {
                Random random = new Random();
                return random.Next(minNum, maxNum + 1);
           }
        }
    }
}
