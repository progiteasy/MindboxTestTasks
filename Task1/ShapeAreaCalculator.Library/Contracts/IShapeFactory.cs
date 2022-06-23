namespace ShapeAreaCalculator.Library.Contracts
{
    /// <summary>
    /// Интерфейс для реализации фабрики, создающей различные геометрические фигуры
    /// </summary>
    public interface IShapeFactory
    {
        /// <summary>
        /// Метод создания геометрической фигуры заданного типа <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Пользовательский тип, реализующий интерфейс IShape</typeparam>
        /// <param name="shapeArgs">Обёртка для аргументов, используемых при инициализации новой геометрической фигуры</param>
        /// <returns>Геометрическая фигура типа <typeparamref name="T"/></returns>
        public IShape CreateShape<T>(IShapeArgs<T> shapeArgs) where T: IShape;
    }
}
