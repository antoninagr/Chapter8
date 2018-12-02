using System;
using System.Text;
using System.Linq;



namespace _06_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Десетична бройна система: ");
        Console.Write("Въведете число n = ");
        string line = Console.ReadLine();
            Console.WriteLine("Шеснадесетична бройна система: ");
        Console.Write("n = ");
        ConvertDecToHex(line);
    }
    public static void ConvertDecToHex(string line)
    {
        int dec = int.Parse(line);
        StringBuilder hex = new StringBuilder();
        if (dec == 0)
        {
            hex.Insert(0, '0');
        }
        else
        {
            int q = dec;
            while (q != 0)
            {
                int residual = Math.Abs(q % 16);
                if (residual < 10)
                {
                    hex.Insert(0, (char)(48 + residual));
                }
                else
                {
                    hex.Insert(0, (char)(65 + residual - 10));
                }
                q /= 16;
            }
        }
        if (dec < 0)
        {
            Console.WriteLine("-{0}", hex);
        }
        else
        {
            Console.WriteLine("{0}", hex);
        }
        }
    }
}
