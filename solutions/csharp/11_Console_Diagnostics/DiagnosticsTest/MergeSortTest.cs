namespace DiagnosticsTest
{
    public class MergeSortTest
    {
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0,1,0)]
        [InlineData(0,2,1)] //real use case
        [InlineData(0,3,1)] //real use case
        [InlineData(0,4,2)] //real use case
        [InlineData(3,3,3)]
        [InlineData(3,4,3)]
        [InlineData(3,5,4)] //real use case
        [InlineData(3,6,4)] //real use case
        public void GetCenter(int min, int max, int expected)
        {
            var result = MergeSort.GetCenter(min, max);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void EmptyInput_NoError()
        {
            var input = new int[0];

            var result = MergeSort.Sort(input);

            Utils.AssertMatch(new int[0], result);
        }

        [Fact]
        public void SingleValueInput_NoError()
        {
            var input = new int[] { 1 };

            var result = MergeSort.Sort(input);

            Utils.AssertMatch(new int[] { 1 }, result);
        }

        [Fact]
        public void UnorderedInput_Sorted()
        {
            var input = new int[] { 3, 7, 2, 6, 9, 4, 1 };

            var result = MergeSort.Sort(input);

            Utils.AssertMatch(new int[] { 1, 2, 3, 4, 6, 7, 9 }, result);
        }

        [Fact]
        public void WorstCaseInput_Sorted()
        {
            var input = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var result = MergeSort.Sort(input);

            Utils.AssertMatch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, result);
        }
    }
}