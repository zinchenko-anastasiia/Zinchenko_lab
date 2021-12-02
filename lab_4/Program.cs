using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("arr[" + i + "," + j + "]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());

                }

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int currentValue = arr[i, j];
                    if (currentValue % 2 == 0)
                    {
                        Console.WriteLine(arr[i, j] + " even");
                    }

                }
            }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int currentValue = arr[i, j];
                        if (currentValue % 2 != 0)
                        {
                            Console.WriteLine(arr[i, j] + " odds");
                        }
                    }

                }
            }
    }
}
    

