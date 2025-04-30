namespace Baza
{
    public class Class1
    {
        // Методы для квадрата
        public double SquareArea(double sideLength)
        {
            return sideLength * sideLength;
        }

        public double SquarePerimeter(double sideLength)
        {
            return 4 * sideLength;
        }

        // Методы для треугольника
        public double TrianglePerimeter(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }

        // Альтернативный метод для треугольника (по формуле Герона)
        public double TriangleAreaHeron(double sideA, double sideB, double sideC)
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        // Методы для прямоугольника
        public double RectangleArea(double width, double height)
        {
            return width * height;
        }

        public double RectanglePerimeter(double width, double height)
        {
            return 2 * (width + height);
        }


        private const double Pi = Math.PI;
        // Метод для расчета площади круга
        public double CircleArea(double radius)
        {
            return Pi * radius * radius;
        }

        // Метод для расчета периметра (длины окружности) круга
        public double CirclePerimeter(double radius)
        {
            return 2 * Pi * radius;
        }

        //Лера
        public double CubeSurfaceArea(double side)
        {
            return 6 * side * side;
        }

        public double CubeVolume(double side)
        {
            return side * side * side;
        }


    }
}
