using System;

namespace _1199B_WaterLily
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double h = Convert.ToInt32(input[0]);
            double l = Convert.ToInt32(input[1]);

            double result = 0;

            double h_sq = Math.Pow(h, 2);
            l = Math.Pow(l, 2);

            result = (l - h_sq) / (h * 2);

            result = Math.Round(result, 6);

            Console.WriteLine(result);
             
        }
    }
}
