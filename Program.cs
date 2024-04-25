using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создание объекта поинт с целочисленными координатами.
            Point<int> intPoint = new Point<int>(3, 4);
            Console.WriteLine("Целочисленные координаты:");
            intPoint.Print();

            // создание объекта поинт с вещественными координатами.
            Point<double> doublePoint = new Point<double>(1.5, 2.5);
            Console.WriteLine("\nВещественные координаты:");
            doublePoint.Print();

            // Создание объекта поинт с символьными координатами.
            Point<char> charPoint = new Point<char>('A', 'B');
            Console.WriteLine("\nСимвольные координаты:");
            charPoint.Print();

            Console.ReadKey();
        }
    }
}
    

