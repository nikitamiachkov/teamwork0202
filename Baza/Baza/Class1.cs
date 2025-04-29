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

        // Методы для пирамиды 

        public double PyramidBaseArea(double baseLength, double baseWidth) => baseLength * baseWidth;

        public double PyramidVolume(double baseLength, double baseWidth, double height)
            => (baseLength * baseWidth * height) / 3;

        public double PyramidLateralArea(double baseLength, double baseWidth, double height)
        {
            double apothemLength = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseLength / 2, 2));
            double apothemWidth = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseWidth / 2, 2));
            return baseLength * apothemWidth + baseWidth * apothemLength;
        }

        public double PyramidTotalArea(double baseLength, double baseWidth, double height)
            => PyramidBaseArea(baseLength, baseWidth) + PyramidLateralArea(baseLength, baseWidth, height);

    }
}
