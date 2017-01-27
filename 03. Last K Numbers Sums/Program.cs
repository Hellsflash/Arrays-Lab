using System;


namespace _03.Last_K_Numbers_Sums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var arrOFNums = new long[n];
            arrOFNums[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int prev = i - k; prev <= i - 1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += arrOFNums[prev];
                        arrOFNums[i] = sum;
                    }
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arrOFNums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
