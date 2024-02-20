using System;

namespace Uppgift_6_11
{
    class Prograam
    {
        static void Main()
        {
            RitaKvadrat(5, 'A', 3);
            RitaKvadrat(3, '@');
            RitaKvadrat(4, 'O', 2);

            Console.ReadKey();
        }

        static void RitaKvadrat(int bredd, char tecken, int mellanrum = 0)
        {
            for (int i = 0; i <= bredd; i++)
            {
                for (int j = 0; j <= bredd; j++)
                {
                    Console.Write(tecken);

                    for (int k = 0; k <= mellanrum - 1; k++)
                    {
                        Console.Write(" ");
                    }
                }

                for (int k = 0; k <= mellanrum; k++)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}