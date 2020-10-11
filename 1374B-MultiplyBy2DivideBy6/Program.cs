using System;

namespace _1374B_MultiplyBy2DivideBy6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] results = new int[n];

            for(int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                int s1 = 0;
                int s2 = 0;

                while(number%2 == 0)
                {
                    s1++;
                    number /= 2;
                }

                while(number%3 == 0)
                {
                    s2++;
                    number /= 3;
                }

                if(number == 1)
                {
                    if(s1 <= s2)
                    {
                        int answer = Math.Min(s1, s2);
                        s1 -= answer;
                        s2 -= answer;
                        answer += s2 * 2;
                        results[i] = answer;
                    }
                    else
                    {
                        results[i] = -1;
                    }
                }
                else
                {
                    results[i] = -1;
                }

            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(results[i]);
            }

        }
    }
}
