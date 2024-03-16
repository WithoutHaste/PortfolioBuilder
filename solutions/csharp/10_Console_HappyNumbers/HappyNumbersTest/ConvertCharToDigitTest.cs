namespace HappyNumbersTest
{
    public class ConvertCharToDigitTest
    {
        [Theory]
        [InlineData('1',1)]
        [InlineData('2',2)]
        [InlineData('3',3)]
        [InlineData('4',4)]
        [InlineData('5',5)]
        [InlineData('6',6)]
        [InlineData('7',7)]
        [InlineData('8',8)]
        [InlineData('9',9)]
        [InlineData('0',0)]
        public void Success(char c, int n)
        {
            var result = Exercise10.ConvertCharToDigit(c);

            Assert.Equal(n, result);
        }

        [Theory]
        [InlineData(' ')]
        [InlineData('a')]
        [InlineData('A')]
        [InlineData('*')]
        public void Failure_ReturnZero(char c)
        {
            var result = Exercise10.ConvertCharToDigit(c);

            Assert.Equal(0, result);
        }
    }
}