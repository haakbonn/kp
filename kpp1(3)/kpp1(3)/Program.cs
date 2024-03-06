using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpp1_3_
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 3, -5, 7, -2, 9, -8, 10, -4 };

            int firstPositive = numbers.FirstOrDefault(n => n > 0);
            int lastNegative = numbers.LastOrDefault(n => n < 0);

            Console.WriteLine("Перший додатній елемент: " + firstPositive);
            Console.WriteLine("Останній від'ємний елемент: " + lastNegative);

            Console.ReadLine();
        }
    }
}
