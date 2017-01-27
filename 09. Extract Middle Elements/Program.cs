using System;
using System.Linq;


namespace _09.Extract_Middle_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int middle = array.Length / 2;

            for (int i = 0; i < array.Length; i++)
            {



                if (array.Length == 1)
                {

                    Console.WriteLine($"{{ {array[0]} }}");

                }

                else if (array.Length % 2 == 0)
                {
                    Console.WriteLine($"{{ {array[middle - 1]}, {array[middle]} }}" );
                    break;
                }
                else
                {
                    Console.WriteLine($"{{ {array[middle - 1]}, {array[middle]}, {array[middle + 1]} }}");
                    break;
                }
            }
        }
    }
}



