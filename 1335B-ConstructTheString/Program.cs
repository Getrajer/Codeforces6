using System;

namespace _1335B_ConstructTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());

            string[] words = new string[l];

            for(int i = 0; i < l; i++)
            {
                string[] input = Console.ReadLine().Split();

                int n = Convert.ToInt32(input[0]);
                int a = Convert.ToInt32(input[1]);
                int b = Convert.ToInt32(input[2]);

                int asci = 97;
                int counter = 0;

                string word = "";

                for(int j = 0; j < n; j++)
                {
                    if(counter == b)
                    {
                        asci = 97;
                        counter = 0;
                    }
                    word += Convert.ToString((char)asci);
                    asci++;
                    counter++;
                }

                words[i] = word;
            }

            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(words[i]);
            }

        }
    }
}
