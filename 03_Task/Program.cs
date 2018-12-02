using System;

namespace _03_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexValues = "2A3E FA FFFF 5A0E9";
            string[] hexValuesSplit = hexValues.Split(' ');
            foreach (String hex in hexValuesSplit)
            {
                int value = Convert.ToInt32(hex, 16);
                Console.Write("{0,5}(16) = {1,6}(10) , ", hex, value);
                Console.WriteLine("{0,19}(2)", Convert.ToString(value, 2));
            }
            Console.ReadKey();
        }
    }
}
