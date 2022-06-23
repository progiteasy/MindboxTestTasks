using ShapeAreaCalculator.Library.Contracts;
using System;

namespace ShapeAreaCalculator.Library.Models
{
    /// <summary>
    /// Класс-обёртка для аргументов, используемых при инициализации новой геометрической фигуры типа <see cref="Circle"/>
    /// </summary>
    public class CircleArgs : IShapeArgs<Circle>
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public CircleArgs() { }
        
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public CircleArgs(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Метод валидации аргументов
        /// </summary>
        /// <exception cref="ArgumentException">Генерируется в случае, если какой-либо аргумент имеет недопустимое значение</exception>
        public void Validate()
        {
            if (Radius <= 0)
                throw new ArgumentException($"{nameof(Radius)}: значение радиуса меньше либо равно 0");
        }

        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; set; }
    }
}
