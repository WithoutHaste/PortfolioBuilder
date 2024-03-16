using NuGet.Frameworks;
using System.Collections.Generic;

namespace HappyNumbersTest
{
    public class DetermineHappyOrNotTest
    {
        [Fact]
        public void HappyNumber_FromInit()
        {
            //Arrange
            var happy = new HashSet<int>() { 1 };
            var unhappy = new HashSet<int>();
            var n = 10;

            //Act
            Exercise10.DetermineHappyOrNot(n, ref happy, ref unhappy);

            //Assert
            Assert.Contains(1, happy);
            Assert.Contains(n, happy);
            Assert.Empty(unhappy);
        }

        [Fact]
        public void UnhappyNumber_FromInit()
        {
            //Arrange
            var happy = new HashSet<int>() { 1 };
            var unhappy = new HashSet<int>();
            var n = 2;

            //Act
            Exercise10.DetermineHappyOrNot(n, ref happy, ref unhappy);

            //Assert
            Assert.Single(happy);
            Assert.Contains(1, happy);
            Assert.Contains(2, unhappy);
            Assert.Contains(4, unhappy);
            Assert.Contains(16, unhappy);
            Assert.Contains(37, unhappy);
            Assert.Contains(58, unhappy);
            Assert.Contains(89, unhappy);
            Assert.Contains(145, unhappy);
            Assert.Contains(42, unhappy);
            Assert.Contains(20, unhappy);
        }
    }
}