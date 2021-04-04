using System;
using FuzzBuzz.Library;

namespace FuzzBuzz.ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FuzzerBuzzer.GetValue(i));
            }

            Console.ReadLine();
        }
    }
}
