using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Въведете римско число: ");
            string romanInput = Console.ReadLine();
            char[] romans = romanInput.ToCharArray();

            Dictionary<char, short> romanTable = new Dictionary<char, short>();

            romanTable.Add('M', 1000);
            romanTable.Add('C', 100);
            romanTable.Add('L', 50);
            romanTable.Add('X', 10);
            romanTable.Add('V', 5);
            romanTable.Add('I', 1);
            romanTable.Add('m', 1000);
            romanTable.Add('c', 100);
            romanTable.Add('l', 50);
            romanTable.Add('x', 10);
            romanTable.Add('v', 5);
            romanTable.Add('i', 1);

            for (int i = 0; i < romans.Length; i++)
            {
                if (i == romans.Count() - 1)
                {
                    sum += romanTable[romans[i]];
                }
                else
                {
                    if (romanTable[romans[i + 1]] > romanTable[romans[i]])
                    {
                        sum -= romanTable[romans[i]];
                    }
                    else
                    {
                        sum += romanTable[romans[i]];
                    }
                }
            }
            Console.WriteLine("Арабско число: ");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
