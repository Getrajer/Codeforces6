using System;

namespace _1343A_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());

            int[] results = new int[l];

            for(int i = 0; i < l; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());


                for(int k = 2; k <= 35; k++)
                {
                    int pow = (int)Math.Pow(2, k) - 1;
                    if(n % pow != 0)
                    {
                        continue;
                    }

                    results[i] = n / pow;
                    break;
                }

               
            }

            for(int i = 0; i < l; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
