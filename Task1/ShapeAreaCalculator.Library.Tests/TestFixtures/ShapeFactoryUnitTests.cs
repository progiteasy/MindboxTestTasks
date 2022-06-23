using NUnit.Framework;
using ShapeAreaCalculator.Library.Contracts;
using ShapeAreaCalculator.Library.Factories;
using ShapeAreaCalculator.Library.Models;
using System;

namespace ShapeAreaCalculator.Library.Tests.TestFixtures
{
    [TestFixture]
    public class ShapeFactoryUnitTests
    {
        private IShapeFactory _shapeFactory;

        [SetUp]
        public void Setup()
        {
            _shapeFactory = new ShapeFactory();
        }

        [Test]
        public void TC1_CallCreateShapeMethod_WithValidArgument_ShouldReturnObjectOfExpectedType()
        {
            var shapeArgs = new CircleArgs(5.0);
            var shape = _shapeFactory.CreateShape(shapeArgs);
            var actualType = shape.GetType();
            var expectedType = typeof(Circle);

            Assert.That(actualType, Is.EqualTo(expectedType));
        }

        [Test]
        public void TC2_CallCreateShapeMethod_WithValidArgument_ShouldReturnObjectOfExpectedType()
        {
            var shapeArgs = new TriangleArgs(3.0, 4.0, 5.0);
            var shape = _shapeFactory.CreateShape(shapeArgs);
            var actualType = shape.GetType();
            var expectedType = typeof(Triangle);

            Assert.That(actualType, Is.EqualTo(expectedType));
        }

        [Test]
        public void TC3_CallCreateShapeMethod_WithValidArgument_ShouldReturnProperlyInitializedObject()
        {
            var shapeArgs = new TriangleArgs(3.0, 4.0, 5.0);
            var shape = _shapeFactory.CreateShape(shapeArgs) as Triangle;

            Assert.Multiple(() =>
            {
                Assert.That(shape.ASide, Is.EqualTo(shapeArgs.ASide).Within(CommonData.CalculationPrecision));
                Assert.That(shape.BSide, Is.EqualTo(shapeArgs.BSide).Within(CommonData.CalculationPrecision));
                Assert.That(shape.CSide, Is.EqualTo(shapeArgs.CSide).Within(CommonData.CalculationPrecision));
            });
        }

        [Test]
        public void TC4_CallCreateShapeMethod_WithUnitializedArgument_ShouldThrowArgumentNullException()
        {
            var shapeArgs = default(CircleArgs);

            Assert.That(() => _shapeFactory.CreateShape(shapeArgs), Throws.Exception.TypeOf<ArgumentNullException>());
        }
    }
}
