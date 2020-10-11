using System;

namespace _460A_VasyaAndSocks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);

            int result = 0;
            int dayC = 1;

            while(n != 0)
            {
                result++;

                n--;
                if(dayC != m)
                {
                    dayC++;
                }
                else
                {
                    dayC = 1;
                    n++;
                }

            }

            Console.WriteLine(result);

        }
    }
}
