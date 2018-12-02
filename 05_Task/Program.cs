using System;

namespace _05_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Двуична бройна система: ");
            Console.Write("Въведете число n :  ");
            string line = Console.ReadLine();
            Console.WriteLine("Десетична бройна система: ");
            Console.Write("Число n = ");
            ConvertBinToDec(line);
        }
        public static void ConvertBinToDec(string bin)
        {
            int dec = 0;
            foreach (char c in bin)
            {
                if (c == '0')
                {
                    dec *= 2;
                }
                else if (c == '1')
                {
                    dec *= 2;
                    dec++;
                }
                else if (c != '-')
                {
                    throw new Exception("Невалидно число!");
                }
            }
            if (bin[0] == '-')
            {
                Console.WriteLine("-{0}", dec);
            }
            else
            {
                Console.WriteLine("{0}", dec);
            }
        }
    }
}
