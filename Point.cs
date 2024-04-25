using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Point<T>
    {
        // внутренние поля для координат x и y
        private T x;
        private T y;

        // конструктор с двумя параметрами для инициализации координат
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        // свойства доступа к координатам x и y
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        // метод для вывода значений координат
        public void Print()
        {
            Console.WriteLine($"Точка с координатами ({x}, {y})");
        }
    }
}

