using System;

namespace _13_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, d;

            Console.Write("Въведете N: ");
            string n = Console.ReadLine();

            do
            {
                Console.Write("Въведете S-основата на бройната система, от която е числото N/(S = 2, 8, 10 или 16): ");
                s = Int32.Parse(Console.ReadLine());
            } while (s != 2 && s != 8 && s != 10 && s != 16);

            do
            {
                Console.Write("Въведете D-основата на бройната система, към която да се преобразува (D = 2, 8, 10 или 16): ");
                d = Int32.Parse(Console.ReadLine());
            } while (d != 2 && d != 8 && d != 10 && d != 16);

            n = Convert.ToString(Convert.ToInt32(n, s), d);

            Console.WriteLine("Резултатът е {0}.", n);
        }
    }
}
