using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestPointInCircle()
        {
            // Arrange
            int pointX = 0;
            int pointY = 0;
            int circleX = 0;
            int circleY = 0;
            int circleRadius = 3;

            // Act
            Circle c = new Circle(circleX, circleY, circleRadius);
            
            // Assert
            Assert.IsTrue(c.IsInside(c, pointX, pointY));
        }

        //[TestMethod]
        //public void TestIfTwoCirclesOverlap()
        //{
        //    int circleOneX = 3;
        //    int circleOneY = 6;
        //    int circleOneR = 4;

        //    int circleTwoX = 3;
        //    int circleTwoY = 6;
        //    int circleTwoR = 5;

        //    Circle one = new Circle(circleOneX, circleOneY, circleOneR);
        //    Circle two = new Circle(circleTwoX, circleTwoY, circleTwoR);

        //    Assert.IsTrue(one.IsOverlapping(one, two));  
        //}
    }
}
