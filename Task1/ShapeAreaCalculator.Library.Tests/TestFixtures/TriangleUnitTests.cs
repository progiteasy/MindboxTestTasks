using NUnit.Framework;
using ShapeAreaCalculator.Library.Models;
using System;

namespace ShapeAreaCalculator.Library.Tests.TestFixtures
{
    [TestFixture]
    public class TriangleUnitTests
    {
        [Test]
        public void TC1_CallConstructor_WithValidShapeArgs_ShouldCreateProperlyInitializedObject()
        {
            var shapeArgs = new TriangleArgs(3.0, 4.0, 5.0);
            var shape = new Triangle(shapeArgs);

            Assert.Multiple(() =>
            {
                Assert.That(shape.ASide, Is.EqualTo(shapeArgs.ASide).Within(CommonData.CalculationPrecision));
                Assert.That(shape.BSide, Is.EqualTo(shapeArgs.BSide).Within(CommonData.CalculationPrecision));
                Assert.That(shape.CSide, Is.EqualTo(shapeArgs.CSide).Within(CommonData.CalculationPrecision));
            });
        }

        [Test]
        public void TC2_CallConstructor_WithInvalidShapeArgs_ShouldThrowArgumentException()
        {
            var shapeArgs = new TriangleArgs(2.0, -1.0, 7.0);

            Assert.That(() => new Triangle(shapeArgs), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test]
        public void TC3_CallConstructor_WithInvalidShapeArgs_ShouldThrowArgumentException()
        {
            var shapeArgs = new TriangleArgs(1.0, 2.0, 3.0);

            Assert.That(() => new Triangle(shapeArgs), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test]
        public void TC4_CallIsRightMethod_ShouldReturnExpectedValue()
        {
            var shapeArgs = new TriangleArgs(3.0, 4.0, 5.0);
            var shape = new Triangle(shapeArgs);
            var actualValue = shape.IsRight();
            var expectedValue = true;

            Assert.That(actualValue, Is.EqualTo(expectedValue));
        }

        [Test]
        public void TC5_CallPerimeterProperty_ShouldReturnExpectedValue()
        {
            var shapeArgs = new TriangleArgs(2.2, 3.6, 4.3);
            var shape = new Triangle(shapeArgs);
            var actualValue = shape.Perimeter;
            var expectedValue = 10.1;

            Assert.That(actualValue, Is.EqualTo(expectedValue).Within(CommonData.CalculationPrecision));
        }

        [Test]
        public void TC6_CallAreaProperty_ShouldReturnExpectedValue()
        {
            var shapeArgs = new TriangleArgs(3.5, 2.8, 4.3);
            var shape = new Triangle(shapeArgs);
            var actualValue = shape.Area;
            var expectedValue = 4.883;

            Assert.That(actualValue, Is.EqualTo(expectedValue).Within(CommonData.CalculationPrecision));
        }
    }
}
