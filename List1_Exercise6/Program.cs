using System;

namespace List1_Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int stop, previous1 = 1, result = 0, previous2;

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

                    previous2 = result;
                    result = previous1 + previous2;
                    previous1 = previous2;
                    Console.WriteLine(result);

                }
               
            }

            Console.ReadKey();

        }
    }
}
