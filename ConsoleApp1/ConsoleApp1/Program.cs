using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mezisoucet=0;
            for (int i = 0; i <= 100; i++)
            {
                mezisoucet += i;               
            }
            Console.WriteLine(mezisoucet);
        }
    }
}
