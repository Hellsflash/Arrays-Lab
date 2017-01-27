using System;
using System.Linq;

namespace _05.Rounding_Numbers
{
    public class Program
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                var result = numbers[i];
                var roundedNumber = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{result} => {roundedNumber}");
            }
        }
    }
}
