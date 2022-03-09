using System;

namespace List1_Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int stop, ant1 = 1, result = 0, ant2;

            Console.Write("Enter a stop number: ");
            stop = int.Parse(Console.ReadLine());
            Console.WriteLine();
            

            for(int i = 0; i <= stop - 1; i++)
            {
                if (i == 0)
                {

                    Console.WriteLine(result);

                }
                else
                {

                    ant2 = result;
                    result = ant1 + ant2;
                    ant1 = ant2;
                    Console.WriteLine(result);

                }
               
            }

            Console.ReadKey();

        }
    }
}
