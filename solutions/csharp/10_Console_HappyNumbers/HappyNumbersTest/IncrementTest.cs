namespace HappyNumbersTest
{
    public class IncrementTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(10, 1)]
        [InlineData(4, 16)]
        [InlineData(24, 20)]
        public void Success(int currentN, int nextN)
        {
            var result = Exercise10.Increment(currentN);

            Assert.Equal(nextN, result);
        }
    }
}