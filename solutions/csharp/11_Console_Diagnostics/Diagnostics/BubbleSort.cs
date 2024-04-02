using System;
using System.Collections.Generic;

namespace Diagnostics
{
    internal static class BubbleSort
    {
        public static string Label = "Bubble Sort";

        /// <summary>Sorts array into ascending order in-place</summary>
        public static void Sort(ref int[] input)
        {
            var unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (var i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] > input[i+1])
                    {
                        unsorted = true;
                        input.Swap(i, i + 1);
                    }
                }
            }
        }
    }
}
