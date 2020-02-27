using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.Tests
{
    [TestClass]
    public class DurationTest
    {
        [TestMethod]
        public void TestDuration()
        {
            // Arrange
            int inputSeconds = 20;
            int inputMinutes = 4;
            int inputHours = 60;
            int expectedSeconds = 216260;
            Duration durationTest = new Duration(inputHours, inputMinutes, inputSeconds);

            // Act
            var result = durationTest.totalSeconds;

            // Assert
            Assert.AreEqual(expectedSeconds, result);
        }

        [TestMethod]
        public void TestAddDuration()
        {
            // Arrange
            int inputSecondsOne = 2;
            int inputSecondsTwo = 30;
            int inputMinutesOne = 0;
            int inputMinutesTwo = 0;
            int inputHoursOne = 0;
            int inputHoursTwo = 0;
            int expected = 32;
            Duration durationOne = new Duration(inputHoursOne, inputMinutesOne, inputSecondsOne);
            Duration durationTwo = new Duration(inputHoursTwo, inputMinutesTwo, inputSecondsTwo);

            // Act
            durationOne.Add(durationTwo);
            var result = durationOne.totalSeconds;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSubDuration()
        {
            // Arrange
            int inputSecondsOne = 5;
            int inputSecondsTwo = 2;
            int inputMinutesOne = 0;
            int inputMinutesTwo = 0;
            int inputHoursOne = 0;
            int inputHoursTwo = 0;
            int expected = 3;
            Duration durationOne = new Duration(inputHoursOne, inputMinutesOne, inputSecondsOne);
            Duration durationTwo = new Duration(inputHoursTwo, inputMinutesTwo, inputSecondsTwo);

            // Act
            durationOne.Sub(durationTwo);
            var result = durationOne.totalSeconds;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMultiplyDuration()
        {
            // Arrange
            int inputSeconds = 5;
            int inputMinutes = 4;
            int inputHours = 0;
            int multiplier = 3;
            int expected = 735;
            Duration duration = new Duration(inputHours, inputMinutes, inputSeconds);

            // Act
            duration.Mul(multiplier);
            var result = duration.totalSeconds;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
