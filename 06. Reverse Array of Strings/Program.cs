using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] symbol = Console.ReadLine().Split(' ').ToArray();
           

            for (int i = 0; i < symbol.Length; i++)
            {
                var symbolNumbers = new string[symbol.Length];
                symbolNumbers[i] = symbol[symbol.Length - i - 1];

                Console.Write($"{symbolNumbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
