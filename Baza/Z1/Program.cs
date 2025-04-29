using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza;

namespace cs
{
    public class SquareTask
    {
        private readonly Class1 _calculator;

        public SquareTask()
        {
            _calculator = new Class1();
        }

        public void CalculateSquareProperties(double sideLength)
        {
            double area = _calculator.SquareArea(sideLength);
            double perimeter = _calculator.SquarePerimeter(sideLength);

            Console.WriteLine($"Для квадрата со стороной {sideLength} см:");
            Console.WriteLine($"Площадь: {area} см²");
            Console.WriteLine($"Периметр: {perimeter} см");
        }
    }

    class Program
    {
        static void Main()
        {
            SquareTask squareTask = new SquareTask();
            double sideLength = 2.44;

            squareTask.CalculateSquareProperties(sideLength);
        }
    }
}

