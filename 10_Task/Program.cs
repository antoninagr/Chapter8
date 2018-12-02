using System;

namespace _10_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = 0;

            Console.Write("Въведете число в двуична бройна система:  ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                dec += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine("Числото в десетична бройна система е {0}.", dec);
        }
    }
}
