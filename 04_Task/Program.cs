using System;
using System.Linq;
using System.Text;


namespace _04_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Десетична бройна система: ");
            Console.Write("Въведете n = ");
            string line = Console.ReadLine();
            Console.WriteLine("Двуична бройна система: ");
            Console.Write("n = ");
            ConvertDecToBin(line);
        }
        public static void ConvertDecToBin(string line)
        {
            int dec = int.Parse(line);
            StringBuilder bin = new StringBuilder();
            if (dec == 0)
            {
                bin.Insert(0, '0');
            }
            else
            {
                int q = dec;
                while (q != 0)
                {
                    if (q % 2 == 0)
                    {
                        bin.Insert(0, '0');
                    }
                    else
                    {
                        bin.Insert(0, '1');
                    }
                    q /= 2;
                }
            }
            if (dec < 0)
            {
                Console.WriteLine("-{0}", bin);
            }
            else
            {
                Console.WriteLine("{0}", bin);
            }
        }
    }
}
