using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число минут, прошедних с начала часа: ");
            var minute = double.Parse(Console.ReadLine());

            while (minute >= 0)
            {
                minute -= 3;
                if (minute < 0)
                {
                    Console.WriteLine("Горит зеленый сигнал светофора");
                    break;
                }
                minute -= 2;
                if (minute < 0)
                {
                    Console.WriteLine("Горит красный сигнал светофора");
                    break;
                }
            }
        }
    }
}
