using NUnit.Framework;
using ShapeAreaCalculator.Library.Models;
using System;

namespace ShapeAreaCalculator.Library.Tests.TestFixtures
{
    [TestFixture]
    public class CircleUnitTests
    {
        [Test]
        public void TC1_CallConstructor_WithValidArguments_ShouldCreateProperlyInitializedObject()
        {
            var shapeArgs = new CircleArgs(8.0);
            var shape = new Circle(shapeArgs);

            Assert.That(shape.Radius, Is.EqualTo(shapeArgs.Radius).Within(CommonData.CalculationPrecision));
        }

        [Test]
        public void TC2_CallConstructor_WithInvalidArguments_ShouldThrowArgumentException()
        {
            var shapeArgs = new CircleArgs(-3.0);

            Assert.That(() => new Circle(shapeArgs), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test]
        public void TC3_CallAreaProperty_ShouldReturnExpectedValue()
        {
            var shapeArgs = new CircleArgs(8.0);
            var shape = new Circle(shapeArgs);
            var actualValue = shape.Area;
            var expectedValue = 201.061;

            Assert.That(actualValue, Is.EqualTo(expectedValue).Within(CommonData.CalculationPrecision));
        }
    }
}
