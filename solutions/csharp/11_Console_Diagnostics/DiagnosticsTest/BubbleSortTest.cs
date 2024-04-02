namespace DiagnosticsTest
{
    public class BubbleSortTest
    {
        [Fact]
        public void EmptyInput_NoError()
        {
            var input = new int[0];

            BubbleSort.Sort(ref input);

            Utils.AssertMatch(new int[0], input);
        }

        [Fact]
        public void SingleValueInput_NoError()
        {
            var input = new int[] { 1 };

            BubbleSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1 }, input);
        }

        [Fact]
        public void UnorderedInput_Sorted()
        {
            var input = new int[] { 3, 7, 2, 6, 9, 4, 1 };

            BubbleSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1, 2, 3, 4, 6, 7, 9 }, input);
        }

        [Fact]
        public void WorstCaseInput_Sorted()
        {
            var input = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            BubbleSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, input);
        }
    }
}