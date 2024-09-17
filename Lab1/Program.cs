using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Правила безопасности при работе с компьютером!");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Что можно делать за компьютером");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Работать и учиться");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Что нельзя делать за компьютером");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Открывать кучу программ и вкладок сразу");
            Console.WriteLine("Нажимать на подозрительные ссылки и скачивать разные программы/файлы с построронних сайтов");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Спасибо за внимание!");
            Console.ReadLine();
        }
    }
}
