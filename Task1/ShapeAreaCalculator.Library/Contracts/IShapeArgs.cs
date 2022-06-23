namespace ShapeAreaCalculator.Library.Contracts
{
    /// <summary>
    /// Интерфейс для реализации обёртки для аргументов, используемых при инициализации новой геометрической фигуры
    /// </summary>
    /// <typeparam name="T">Пользовательский тип, реализующий интерфейс IShape</typeparam>
    public interface IShapeArgs<T> where T: IShape
    {
        /// <summary>
        /// Метод валидации аргументов
        /// </summary>
        public void Validate();
    }
}
