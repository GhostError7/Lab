using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string birth;
            const int Year = 2024;
            Console.WriteLine("Введите свой год рождения");
            birth = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Вы родились в " + birth + " году. Сейчас " + Year + " год.");
            Console.ReadLine();
        }
    }
}
