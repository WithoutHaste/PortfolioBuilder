namespace DiagnosticsTest
{
    public class QuickSortTest
    {

        [Fact]
        public void EmptyInput_NoError()
        {
            var input = new int[0];

            QuickSort.Sort(ref input);

            Utils.AssertMatch(new int[0], input);
        }

        [Fact]
        public void SingleValueInput_NoError()
        {
            var input = new int[] { 1 };

            QuickSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1 }, input);
        }

        [Fact]
        public void TwoValuesInput_NoError()
        {
            var input = new int[] { 1, 2 };

            QuickSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1, 2 }, input);
        }

        [Fact]
        public void ThreeValuesInput_DontMovePivot_Sorted()
        {
            var input = new int[] { 1, 2, 3 };

            QuickSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1, 2, 3 }, input);
        }

        [Fact]
        public void ThreeValuesInput_MovePivot_Sorted()
        {
            var input = new int[] { 1, 3, 2 };

            QuickSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1, 2, 3 }, input);
        }

        [Fact]
        public void AllValuesSmallerThanPivot_Sorted()
        {
            var input = new int[] { 1, 2, 1, 2, 3 };

            QuickSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1, 1, 2, 2, 3 }, input);
        }

        [Fact]
        public void AllValuesLargerThanPivot_Sorted()
        {
            var input = new int[] { 5, 4, 5, 4, 3 };

            QuickSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 3, 4, 4, 5, 5 }, input);
        }

        [Fact]
        public void UnorderedInput_Sorted()
        {
            var input = new int[] { 3, 7, 2, 6, 9, 4, 1 };

            QuickSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1, 2, 3, 4, 6, 7, 9 }, input);
        }

        [Fact]
        public void WorstCaseInput_Sorted()
        {
            var input = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            QuickSort.Sort(ref input);

            Utils.AssertMatch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, input);
        }
    }
}