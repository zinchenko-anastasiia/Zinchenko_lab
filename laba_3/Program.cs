using System;

namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool check = true;
            Console.WriteLine("цiле число");
            n = int.Parse(Console.ReadLine());
            if (9 < n && n < 100)
            {
                if (n % 2 == 0)
                {
                    Console.Write(check);
                }
                else
                {
                    Console.Write(false);
                }
            }

            else
            {
                Console.Write(false);
            }



        }
    }
}
