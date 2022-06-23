namespace ShapeAreaCalculator.Library.Contracts
{
    /// <summary>
    /// Интерфейс для реализации калькулятора площади геометрических фигур
    /// </summary>
    public interface IAreaCalculator
    {
        /// <summary>
        /// Метод вычисления площади геометрической фигуры <paramref name="shape"/>
        /// </summary>
        /// <param name="shape">Геометрическая фигура</param>
        /// <returns>Значение площади фигуры <paramref name="shape"/></returns>
        public double CalculateArea(IShape shape);
    }
}
