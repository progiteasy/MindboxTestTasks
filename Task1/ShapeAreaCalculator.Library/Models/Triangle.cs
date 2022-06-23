using ShapeAreaCalculator.Library.Contracts;
using ShapeAreaCalculator.Library.Extensions;
using System;
using System.Linq;

namespace ShapeAreaCalculator.Library.Models
{
    /// <summary>
    /// Класс, реализующий геометрическую фигуру "Треугольник"
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Метод для проверки существования треугольника с заданными сторонами
        /// </summary>
        /// <param name="aSide">Длина стороны A</param>
        /// <param name="bSide">Длина стороны B</param>
        /// <param name="cSide">Длина стороны C</param>
        /// <returns>Истина, если такой треугольник существует, в противном случае - ложь</returns>
        public static bool Exists(double aSide, double bSide, double cSide)
            => aSide > 0 && bSide > 0 && cSide > 0 &&
               aSide + bSide > cSide && aSide + cSide > bSide && bSide + cSide > aSide;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="args">Обёртка для аргументов, необходимых для инициализации данных при создании нового экземпляра класса</param>
        public Triangle(TriangleArgs args)
        {
            args.Validate();

            ASide = args.ASide;
            BSide = args.BSide;
            CSide = args.CSide;
        }

        /// <summary>
        /// Метод для определения, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Истина, если треугольник является прямоугольным, в противном случае - ложь</returns>
        public bool IsRight()
        {
            var sidesOrderedByLength = (new double[] { ASide, BSide, CSide }).
                OrderBy(sideLength => sideLength);
            var leg1 = sidesOrderedByLength.ElementAt(0);
            var leg2 = sidesOrderedByLength.ElementAt(1);
            var hypotenuse = sidesOrderedByLength.ElementAt(2);

            return (Math.Pow(leg1, 2) + Math.Pow(leg2, 2)).ApproximatelyEquals(Math.Pow(hypotenuse, 2));
        }

        /// <summary>
        /// Длина стороны A
        /// </summary>
        public double ASide { get; }

        /// <summary>
        /// Длина стороны B
        /// </summary>
        public double BSide { get; }

        /// <summary>
        /// Длина стороны C
        /// </summary>
        public double CSide { get; }

        /// <summary>
        /// Периметр
        /// </summary>
        public double Perimeter => ASide + BSide + CSide;

        /// <summary>
        /// Площадь
        /// </summary>
        public double Area => Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - ASide) * (Perimeter / 2 - BSide) * (Perimeter / 2 - CSide));
    }
}
