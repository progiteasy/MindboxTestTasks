using System;

namespace ShapeAreaCalculator.Library.Extensions
{
    /// <summary>
    /// Класс-обёртка для методов-расширений типа Double
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Метод приблизительного сравнения двух чисел с плавающей точкой
        /// </summary>
        /// <param name="number1">1-е значение для сравнения</param>
        /// <param name="number2">2-е значение для сравнения</param>
        /// <returns>Истина, если значения приблизительно равны, в противном случае - ложь</returns>
        public static bool ApproximatelyEquals(this double number1, double number2)
            => Math.Abs(number1 - number2) < 1e-6;
    }
}
