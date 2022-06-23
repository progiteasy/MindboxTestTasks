using NUnit.Framework;
using ShapeAreaCalculator.Library.Contracts;
using ShapeAreaCalculator.Library.Factories;
using ShapeAreaCalculator.Library.Models;
using ShapeAreaCalculator.Library.Services;
using System;

namespace ShapeAreaCalculator.Library.Tests.TestFixtures
{
    [TestFixture]
    public class AreaCalculatorUnitTests
    {
        private IShapeFactory _shapeFactory;
        private IAreaCalculator _areaCalculator;

        [SetUp]
        public void Setup()
        {
            _shapeFactory = new ShapeFactory();
            _areaCalculator = new AreaCalculator();
        }

        [Test]
        public void TC1_CallCalculateAreaMethod_WithValidArgument_ShouldReturnExpectedValue()
        {
            var shapeArgs = new CircleArgs(5.0);
            var shape = _shapeFactory.CreateShape(shapeArgs);
            var actualValue = _areaCalculator.CalculateArea(shape);
            var expectedValue = 78.539;

            Assert.That(actualValue, Is.EqualTo(expectedValue).Within(CommonData.CalculationPrecision));
        }

        [Test]
        public void TC2_CallCalculateAreaMethod_WithValidArgument_ShouldReturnExpectedValue()
        {
            var shapeArgs = new TriangleArgs(3.0, 4.0, 5.0);
            var shape = _shapeFactory.CreateShape(shapeArgs);
            var actualValue = _areaCalculator.CalculateArea(shape);
            var expectedValue = 6.0;

            Assert.That(actualValue, Is.EqualTo(expectedValue).Within(CommonData.CalculationPrecision));
        }

        [Test]
        public void TC3_CallCalculateAreaMethod_WithUninitializedArgument_ShouldThrowArgumentNullException()
        {
            var shape = default(Triangle);

            Assert.That(() => _areaCalculator.CalculateArea(shape), Throws.Exception.TypeOf<ArgumentNullException>());
        }
    }
}
