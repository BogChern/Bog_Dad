using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultArea = Data.Input();
            var calculate = new Calculator();

            var countPackTile = calculate.NumberPacksTiles(resultArea);
            Console.WriteLine("\nКоличество покупаемых упаковок плитки: {0}", countPackTile);
        }
    }

  

    class Calculator
    {
        public double TotalArea(double length, double width)
        {
            return length * width;
        }

        public double AdditionalArea(double length, double width)
        {
            return length * width;
        }

        public int NumberPacksTiles(double size)
        {
            if (size % 10 == 0)
                return (int)(size / 10);
            else
                return (int)(size / 10 + 1);
        }
    }

    class Data
    {
        public static double Input()
        {
            var calculate = new Calculator();
            Console.WriteLine("Введите размеры комнаты в формате: \nДлина \nШирина");
            var totalArea = calculate.TotalArea(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            Console.WriteLine("Полная площадь: {0}", totalArea);
            Console.WriteLine("\nВведите размеры дополнительной площади: \nДлина \nШирина");
            var additionalArea = calculate.AdditionalArea(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            Console.WriteLine("Дополнительная площадь: {0}", additionalArea);
            var resultArea = totalArea - additionalArea;
            Console.WriteLine("\nИтоговая площадь: {0}", resultArea);
            return resultArea;
        }
    }
}
