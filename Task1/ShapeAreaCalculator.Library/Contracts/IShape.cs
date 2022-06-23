namespace ShapeAreaCalculator.Library.Contracts
{
    /// <summary>
    /// Интерфейс для реализации геометрической фигуры
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Значение площади геометрической фигуры
        /// </summary>
        public double Area { get; }
    }
}
