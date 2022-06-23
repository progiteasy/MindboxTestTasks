using ShapeAreaCalculator.Library.Contracts;
using System;

namespace ShapeAreaCalculator.Library.Models
{
    /// <summary>
    /// Класс-обёртка для аргументов, используемых при инициализации новой геометрической фигуры типа <see cref="Triangle"/>
    /// </summary>
    public class TriangleArgs : IShapeArgs<Triangle>
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public TriangleArgs() { }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="aSide">Длина стороны A треугольника</param>
        /// <param name="bSide">Длина стороны B треугольника</param>
        /// <param name="cSide">Длина стороны C треугольника</param>
        public TriangleArgs(double aSide, double bSide, double cSide)
        { 
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        /// <summary>
        /// Метод валидации аргументов
        /// </summary>
        /// <exception cref="ArgumentException">Генерируется в случае, если какой-либо аргумент имеет недопустимое значение</exception>
        public void Validate()
        {
            if (ASide <= 0)
                throw new ArgumentException($"{nameof(ASide)}: длина стороны A меньше либо равна 0");
            else if (BSide <= 0)
                throw new ArgumentException($"{nameof(BSide)}: длина стороны B меньше либо равна 0");
            else if (CSide <= 0)
                throw new ArgumentException($"{nameof(CSide)}: длина стороны C меньше либо равна 0");
            else if (!Triangle.Exists(ASide, BSide, CSide))
                throw new ArgumentException("Треугольник с заданными значениями сторон не существует");
        }

        /// <summary>
        /// Длина стороны A треугольника
        /// </summary>
        public double ASide { get; set; }

        /// <summary>
        /// Длина стороны B треугольника
        /// </summary>
        public double BSide { get; set; }

        /// <summary>
        /// Длина стороны C треугольника
        /// </summary>
        public double CSide { get; set; }
    }
}
