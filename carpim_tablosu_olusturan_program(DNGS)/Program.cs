using System;

namespace carpim_tablosu_olusturan_program_DNGS_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0,5} \t x {1,5}={2,5}", i, j, i*j);
                }
                Console.WriteLine("\n\n------------------------------------------\n\n");
            }
        }
    }
}
