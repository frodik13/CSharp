using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество секунд: ");
            var sec = int.Parse(Console.ReadLine());

            int hour = sec / 3600;
            int minute = (sec - hour * 3600) / 60;
            int second = sec - hour * 3600 - minute * 60;



            Console.WriteLine("{0}:{1}:{2}", hour, minute, second);
        }
    }
}
