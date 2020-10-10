using System;

namespace GameWithSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);

            int w = 0;

            while(a != 0 && b != 0)
            {
                a--;
                b--;

                if (w == 0) w = 1; else w = 0;
            }

            if(w == 0) Console.WriteLine("Malvika"); else Console.WriteLine("Akshat");

        }
    }
}
