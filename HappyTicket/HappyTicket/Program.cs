using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер билета: ");
            int ticket = int.Parse(Console.ReadLine());

            int part1 = ticket / 1000;
            int part2 = ticket % 1000;

            int a = 0;
            while (part1 > 0) {
                a += part1 % 10;
                part1 /= 10;
            }

            int b = 0;
            while (part2 > 0) { 
                b += part2 % 10; 
                part2 /= 10;
            }

            if (a == b)
            {
                Console.WriteLine("Поздравляю, Ваш билет счастливый!");
            }
            else
            {
                Console.WriteLine("Немножко не повезло :(");
            }
        }
    }
}
