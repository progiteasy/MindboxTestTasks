using ShapeAreaCalculator.Library.Contracts;
using System;

namespace ShapeAreaCalculator.Library.Services
{
    /// <summary>
    /// Класс, реализующий калькулятор площади геометрических фигур
    /// </summary>
    public class AreaCalculator : IAreaCalculator
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public AreaCalculator() {  }

        /// <summary>
        /// Метод вычисления площади геометрической фигуры <paramref name="shape"/>
        /// </summary>
        /// <param name="shape">Геометрическая фигура</param>
        /// <returns>Значение площади фигуры <paramref name="shape"/></returns>
        /// <exception cref="ArgumentNullException">Генерируется в случае, если переменная <paramref name="shape"/> не инициализирована</exception>
        public double CalculateArea(IShape shape)
        {
            if (shape == null)
                throw new ArgumentNullException($"{nameof(shape)}: переменная не инициализирована");

            return shape.Area;
        }
    }
}
