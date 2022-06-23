using ShapeAreaCalculator.Library.Contracts;
using System;

namespace ShapeAreaCalculator.Library.Models
{
    /// <summary>
    /// Класс, реализующий геометрическую фигуру "Круг"
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="args">Обёртка для аргументов, необходимых для инициализации данных при создании нового экземпляра класса</param>
        public Circle(CircleArgs args)
        {
            args.Validate();

            Radius = args.Radius;
        }

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Площадь
        /// </summary>
        public double Area => Math.PI * Math.Pow(Radius, 2);
    }
}
