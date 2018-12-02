using System;

namespace _02_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1111010110011110 (2) в шеснадесетична бройна система: ");
            Console.WriteLine(Convert.ToInt32("1111010110011110", 2).ToString("X"));

            Console.WriteLine("1111010110011110 (2) в десетична бройна система: ");
            Console.WriteLine(Convert.ToInt32("1111010110011110", 2));

            Console.ReadKey();
        }
    }
}
