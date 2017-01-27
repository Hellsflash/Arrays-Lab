using System;

namespace _01.Day_of_Week
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numberOfDay = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (numberOfDay > 0 && numberOfDay <= days.Length)
            {
                Console.WriteLine(days[numberOfDay-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
