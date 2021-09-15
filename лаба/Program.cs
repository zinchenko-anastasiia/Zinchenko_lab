using System;

namespace лабораторна1
{
    class program
    {
        static void Main(string[] args)
        {
            double R1, R2;
            double R;
            Console.WriteLine("Введiть опiр першого резистора: ");
            R1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть опiр другого резистора: ");
            R2 = int.Parse(Console.ReadLine());
            R = (1 / R1) + (1 / R2);
            Console.WriteLine($"Отже, загальний опiр ланцюга {R}");

        }         
    }
}
