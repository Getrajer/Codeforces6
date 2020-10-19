using System;

namespace _1204A_BowWowAndTheTimetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double decimal_number = 0;
            double c = 0;
            double t = 2;

            for(int i = input.Length - 1; i >= 0; i--)
            {
                if(input[i] == '1')
                {
                    double n = Math.Pow(t, c);
                    decimal_number += n;
                }

                c++;
            }

            double checker = 0;
            t = 4;

            while(decimal_number >= Math.Pow(t, checker))
            {
                checker++;
            }

            Console.WriteLine(checker);

        }
    }
}
