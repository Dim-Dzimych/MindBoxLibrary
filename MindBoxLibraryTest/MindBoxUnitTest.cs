using NUnit.Framework;
using System;

namespace MindBoxLibraryTest
{
    public class MindBoxUnitTest
    {

        [Test]
        public void ShapeAreaForCircle_CertainNumbers_CertainResult()
        {
            //Arrange
            var radius = 2.5;
            var circle = new MindBoxLibrary.Circle(radius);
            var expectedResult = Math.Pow(radius, 2) * Math.PI;
            //Act
            var actualResult = circle.GetSquare();
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }
        [Test]
        public void ShapeAreaForTriangle_CertainNumbers_CertainResult()
        {
            //Arrange
            var sideOne = 2;
            var sideTwo = 3;
            var sideThree = 6;
            var triangle = new MindBoxLibrary.Triangle(sideOne, sideTwo, sideThree);
            double polyPerimetr = (sideOne + sideTwo + sideThree) / 2;
            var expectedResult = Math.Sqrt(polyPerimetr * (polyPerimetr - sideOne) * (polyPerimetr - sideTwo) * (polyPerimetr - sideThree));
            //Act
            var actualResult = triangle.GetSquare();
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}