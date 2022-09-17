using NUnit.Framework;
using System;

using MindBoxLibrary;
namespace MindBoxLibraryTest
{
    public class TriangleUT
    {
        [TestCase(2,4,5,4.0)]
        [TestCase(10,8,5,20.0)]
        [TestCase(10,10,10,43.0)]
        [TestCase(2,4,5,4.0)]
        [TestCase(3,2,1,0)]
        [TestCase(1,1,1,0)]
        public void GetSquare_WithGivenSides_ReturnsCorrectSquare(int sideA, int sideB, int sideC, double expectedResult)
        {
            //Arrange
            var triangle = new MindBoxLibrary.Triangle(sideA, sideB, sideC);
            //Act
            var actualResult = Math.Round(triangle.GetSquare());
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [TestCase(0,0,0)]
        [TestCase(-1,-1,-1)]
        [TestCase(-2,-2,2)]
        [TestCase(-5,5,5)]
        [TestCase(-10,-10,-10)]
        public void GetSquare_WithGivenSides_ReturnsNull(int sideA, int sideB, int sideC)
        {
            //Arrange
            var triangle = new MindBoxLibrary.Triangle(sideA, sideB, sideC);
            //Act
             var actualResult = Math.Round(triangle.GetSquare());
            //Assert
            Assert.IsNotNull(actualResult);
        }
        
        [TestCase(3,4,5,true)]
        [TestCase(8,6,10,true)]
        [TestCase(10,5,4,false)]
        [TestCase(0,0,0,false)]
        [TestCase(0,1,1,false)]
        [TestCase(-1,-1,-1,false)]
        [TestCase(5,5,5,false)]
        [TestCase(10,0,10,false)]
        public void IsRectangular_GivenSides_ReturnsResult(int sideA,int sideB,int sideC,bool expectedResult)
        {
            //Arrange
            var triangle = new MindBoxLibrary.Triangle(sideA, sideB, sideC);
            //Act
            var actualresult = triangle.IsRectangular();
            //Assert
            Assert.AreEqual(expectedResult,actualresult);
        }
    }
}