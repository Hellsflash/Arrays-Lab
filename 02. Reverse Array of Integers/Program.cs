using System;


namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
           var numberOfLines = int.Parse(Console.ReadLine());

            int [] numbers = new int [numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());    
            }

            for (int i = numberOfLines-1; i >= 0; i--)
            {
                Console.Write(numbers[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
