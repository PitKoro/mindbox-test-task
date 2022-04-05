using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyLibrary.Figures;

namespace TestFigures
{
    [TestClass]
    public class FiguresUnitTest
    {
        // ���� �� ������������� ������ �����
        [TestMethod]
        public void Circle_WithNegativeRadius_ShouldThrowArgumentOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        // ���� �� ������������� ������� ������������
        [TestMethod]
        public void Triangle_WithNegativeSides_ShouldThrowArgumentOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-3, 4, 5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(3, -4, 5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(3, 4, -5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-3, -4, -5));
        }

        // ������� �����
        [TestMethod]
        public void Circle_AreaCalculation()
        {
            var circle = new Circle(10);
            var circleArea = circle.Area;
            Assert.AreEqual(Math.PI*100, circleArea);
        }

        // ������� ������������
        [TestMethod]
        public void Triangle_AreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double triangleArea = triangle.Area;
            Assert.AreEqual(6, triangleArea);
        }

        // ���� �� ��������������� ������������
        [TestMethod]
        public void Triangle_WithRightAngle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isTriangleRightAngled = triangle.IsRightAngled;
            Assert.IsTrue(isTriangleRightAngled);
        }

        // ���� �� ����������������� ������������
        [TestMethod]
        public void Triangle_WithoutRightAngle()
        {
            Triangle triangle = new Triangle(3, 5, 5);
            bool isTriangleRightAngled = triangle.IsRightAngled;

            Assert.IsFalse(isTriangleRightAngled);
        }
    }
}