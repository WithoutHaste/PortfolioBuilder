using System;
using System.Collections.Generic;

namespace Diagnostics
{
    internal static class QuickSort
    {
        public static string Label = "Quick Sort";

        /// <summary>sorts array into ascending order, in-place sort</summary>
        public static void Sort(ref int[] input) 
        {
            Sort(ref input, 0, input.Length);
        }

        /// <summary>
        /// sorts array into ascending order, in-place sort
        /// </summary>
        /// <param name="input"></param>
        /// <param name="startIndex">first index included in range</param>
        /// <param name="endIndex">first index excluded from range</param>
        private static void Sort(ref int[] input, int startIndex, int endIndex)
        {
            if (endIndex - startIndex <= 1)
                return;

            var pivotIndex = endIndex - 1;
            var smallIndex = startIndex;
            var largeIndex = pivotIndex - 1;
            while (smallIndex < largeIndex) 
            {
                if (input[largeIndex] >= input[pivotIndex])
                {
                    largeIndex--;
                }
                else if (input[smallIndex] <= input[pivotIndex])
                {
                    smallIndex++;
                }
                else
                {
                    input.Swap(smallIndex, largeIndex);
                    smallIndex++;
                    largeIndex--;
                }
            }
            if (input[largeIndex] < input[pivotIndex]) 
            {
                largeIndex++;
            }
            if(largeIndex != pivotIndex)
            {
                input.Swap(pivotIndex, largeIndex);
                pivotIndex = largeIndex;
            }

            Sort(ref input, startIndex, pivotIndex);
            Sort(ref input, pivotIndex + 1, endIndex);
        }

        internal static int GetCenter(int min, int max)
        {
            return (int)Math.Floor((min + max) / 2m);
        }
    }
}
