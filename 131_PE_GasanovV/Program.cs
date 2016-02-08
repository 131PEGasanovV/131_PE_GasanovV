using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_PE_GasanovV
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите дневную выручку продовца");
            x = Convert.ToInt32(Console.ReadLine());
            int min = 300;

            if (0.05 * x < min)
                 Console.WriteLine("Выручка = {0} ", min );
            else
                if (x <= 10000)
                    Console.WriteLine("Выручка = {0} ", 0.05 * x);
            else
                    Console.WriteLine("Выручка = {0} ", (10000 * 0.05) + ((x - 10000) * 0.1));
            Console.ReadKey();
        }
    }
}
