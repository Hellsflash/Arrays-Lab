using System;
using System.Linq;

namespace _04.Tripple_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int a = arr[i];
                    int b = arr[j];
                    int sum = a + b;
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", a, b, sum);
                        result = true;
                    }
                }
                
            }

            if (result == false)
                Console.WriteLine("No");
        }
    }

}
