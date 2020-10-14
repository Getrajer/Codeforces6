using System;

namespace _1337B_KanaAndDragonQuestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] results = new string[n];

            for(int i = 0; i < n; i++)
            {
                string[] inptut = Console.ReadLine().Split();

                int hp = Convert.ToInt32(inptut[0]);

                int void_count = Convert.ToInt32(inptut[1]);

                int lighting_count = Convert.ToInt32(inptut[2]);

                bool fight = true;
                

                while(hp > 20 && void_count > 0)
                {
                    hp = hp / 2 + 10;
                    lighting_count--;
                }

                while(hp > 0 && lighting_count > 0)
                {
                    hp -= 10;
                    lighting_count--;
                }

                if(hp <= 0)
                {
                    results[i] = "YES";
                }
                else
                {
                    results[i] = "NO";
                }
            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
