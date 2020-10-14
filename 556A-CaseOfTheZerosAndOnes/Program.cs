using System;

namespace _556A_CaseOfTheZerosAndOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();


            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == '0')
                {
                    if(i != 0)
                    {
                        if(input[i - 1] == '1')
                        {
                            input = input.Remove(i - 1, i);
                            i--;
                        }
                        else if(input.Length - 1 != i)
                        {
                            if(input[i + 1] == '1')
                            {
                                input = input.Remove(i, i + 1);
                            }
                        }
                    }
                }
            }

            Console.WriteLine(input.Length);

        }
    }
}
