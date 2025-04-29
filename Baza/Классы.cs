namespace cs
{
    // Класс для работы с прямоугольником
    public class RectangleTask
    {
        private readonly Class1 _calculator;

        public RectangleTask()
        {
            _calculator = new Class1();
        }

        public void CalculateRectangleProperties(double width, double height)
        {
            double area = _calculator.RectangleArea(width, height);
            double perimeter = _calculator.RectanglePerimeter(width, height);

            Console.WriteLine($"Для прямоугольника {width} см x {height} см:");
            Console.WriteLine($"Площадь: {area:F2} см²");
            Console.WriteLine($"Периметр: {perimeter:F2} см");
        }
    }

    // Класс для работы с пирамидой
    public class PyramidTask
    {
        private readonly Class1 _calculator;

        public PyramidTask()
        {
            _calculator = new Class1();
        }

        public void CalculatePyramidProperties(double baseLength, double baseWidth, double height)
        {
            double volume = _calculator.PyramidVolume(baseLength, baseWidth, height);
            double totalArea = _calculator.PyramidTotalArea(baseLength, baseWidth, height);

            Console.WriteLine($"Для пирамиды с основанием {baseLength} см x {baseWidth} см и высотой {height} см:");
            Console.WriteLine($"Объем: {volume:F2} см³");
            Console.WriteLine($"Полная площадь поверхности: {totalArea:F2} см²");
        }
    }

    class Program
    {
        static void Main()
        {
            // Пример с прямоугольником
            RectangleTask rectangleTask = new RectangleTask();
            rectangleTask.CalculateRectangleProperties(5.0, 3.0);

            Console.WriteLine(); // Разделитель

            // Пример с пирамидой
            PyramidTask pyramidTask = new PyramidTask();
            pyramidTask.CalculatePyramidProperties(4.0, 6.0, 5.0);
        }
    }