using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 0m;
            for (int i = 0; i < 50000000; i++)
            {
                a += 0.000001m;
            }
            Console.WriteLine(a);//50.0000
            Console.ReadKey();
            //
            float b = 0f;
            for (int i = 0; i < 50000000; i++)
            {
                b += 0.000001f;
            }
            Console.WriteLine(b);//32
            Console.ReadKey();
            //
            double c = 0d;
            for (int i = 0; i < 50000000; i++)
            {
                c += 0.000001d;
            }
            Console.WriteLine(c);//49.9999999657788
            Console.ReadKey();
        }
    }
}
