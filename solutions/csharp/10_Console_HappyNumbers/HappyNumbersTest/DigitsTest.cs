namespace HappyNumbersTest
{
    public class DigitsTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(10, 1, 0)]
        [InlineData(554, 5, 5, 4)]
        public void Success(int n, params int[] digits)
        {
            var result = Exercise10.Digits(n);

            Utils.AssertMatch(digits, result);
        }

        [Theory]
        [InlineData(-1, 0, 1)]
        public void Failure_UnknownCharsReturnedAsZero(int n, params int[] digits)
        {
            var result = Exercise10.Digits(n);

            Utils.AssertMatch(digits, result);
        }
    }
}