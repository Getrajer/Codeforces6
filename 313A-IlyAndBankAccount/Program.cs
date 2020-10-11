using System;

namespace _313A_IlyAndBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string ammount = Console.ReadLine();

            if(ammount[0] != '-')
            {
                Console.WriteLine(ammount);
            }
            else
            {
                if(ammount.Length == 2)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    string opt1_s = ammount.Remove(ammount.Length - 1, 1);
                    string opt2_s = ammount.Remove(ammount.Length - 2, 1);

                    int opt1 = Convert.ToInt32(opt1_s);
                    int opt2 = Convert.ToInt32(opt2_s);

                    if(opt1 >= opt2)
                    {
                        if(opt1 == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(opt1_s);
                        }
                    }
                    else
                    {
                        if (opt2 == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(opt2_s);
                        }
                    }
                }
            }
        }
    }
}
