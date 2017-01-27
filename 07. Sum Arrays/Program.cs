using System;
using System.Linq;


namespace _07.Sum_Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var maxLenght = Math.Max(firstArray.Length, secondArray.Length);
            var sumOfArrays = new int[maxLenght];

            for (int i = 0; i < maxLenght; i++)
            {
                sumOfArrays[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }
            Console.WriteLine(string.Join(" ",sumOfArrays));
        }
    }
}
