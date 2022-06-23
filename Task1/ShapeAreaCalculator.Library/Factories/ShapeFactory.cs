using ShapeAreaCalculator.Library.Contracts;
using System;

namespace ShapeAreaCalculator.Library.Factories
{
    /// <summary>
    /// Класс, реализующий фабрику, которая создаёт различные геометрические фигуры
    /// </summary>
    public class ShapeFactory : IShapeFactory
    {
        /// <summary>
        /// Метод создания геометрической фигуры заданного типа <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Пользовательский тип, реализующий интерфейс IShape</typeparam>
        /// <param name="shapeArgs">Обёртка для аргументов, используемых при инициализации новой геометрической фигуры</param>
        /// <returns>Геометрическая фигура типа <typeparamref name="T"/></returns>
        /// <exception cref="ArgumentNullException">Генерируется в случае, если переменная <paramref name="shapeArgs"/> не инициализирована</exception>
        public IShape CreateShape<T>(IShapeArgs<T> shapeArgs) where T: IShape
        {
            if (shapeArgs == null)
                throw new ArgumentNullException($"{nameof(shapeArgs)}: переменная не инициализирована");

            return Activator.CreateInstance(typeof(T), shapeArgs) as IShape;
        }
    }
}
