using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyLibrary.Figures;

namespace TestFigures
{
    [TestClass]
    public class FiguresUnitTest
    {
        // Тест на отрицательный радиус круга
        [TestMethod]
        public void Circle_WithNegativeRadius_ShouldThrowArgumentOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        // Тест на отрицательные стороны треугольника
        [TestMethod]
        public void Triangle_WithNegativeSides_ShouldThrowArgumentOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-3, 4, 5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(3, -4, 5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(3, 4, -5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-3, -4, -5));
        }

        // Площадь круга
        [TestMethod]
        public void Circle_AreaCalculation()
        {
            var circle = new Circle(10);
            var circleArea = circle.Area;
            Assert.AreEqual(Math.PI*100, circleArea);
        }

        // Площадь треугольника
        [TestMethod]
        public void Triangle_AreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double triangleArea = triangle.Area;
            Assert.AreEqual(6, triangleArea);
        }

        // Тест на прямоугольность треугольника
        [TestMethod]
        public void Triangle_WithRightAngle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isTriangleRightAngled = triangle.IsRightAngled;
            Assert.IsTrue(isTriangleRightAngled);
        }

        // Тест на непрямоугольность треугольника
        [TestMethod]
        public void Triangle_WithoutRightAngle()
        {
            Triangle triangle = new Triangle(3, 5, 5);
            bool isTriangleRightAngled = triangle.IsRightAngled;

            Assert.IsFalse(isTriangleRightAngled);
        }
    }
}