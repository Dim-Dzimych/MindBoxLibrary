using NUnit.Framework;
using System;
using MindBoxLibrary;
namespace MindBoxLibraryTest
{
    public class CircleUT
    {
        
        [TestCase(0,0)]
        [TestCase(1,3)]
        [TestCase(2,13)]
        [TestCase(10,314)]
        public void GetSquare_GivenRadius_CorrectSquare(int radius,double expectedResult)
        {
            //Arrange
            var circle = new MindBoxLibrary.Circle(radius);
            //Act
            var actualResult = circle.GetSquare();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [TestCase(-1)]
        [TestCase(-20)]
        public void GetSquare_GivenRadius_NegaviteSquare(int radius)
        {
            //Arrange
            var circle = new MindBoxLibrary.Circle(radius);
            //Act
            var actualResult = circle.GetSquare();
            //Assert
            Assert.Negative(actualResult);
        }
    }
}