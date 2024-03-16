using NuGet.Frameworks;
using System.Collections.Generic;

namespace HappyNumbersTest
{
    public class GenerateHappyNumbersTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(30, 1, 7, 10, 13, 19, 23, 28)]
        public void Success(int max, params int[] happy)
        {
            var result = Exercise10.GenerateHappyNumbers(max);

            Utils.AssertMatch(happy, result);
        }
    }
}