using System;
using System.Collections.Generic;

namespace Diagnostics
{
    internal static class MergeSort
    {
        public static string Label = "Merge Sort";

        /// <returns>new array, sorted ascending</returns>
        public static int[] Sort(int[] input)
        {
            if (input.Length <= 1) 
                return input;

            var centerIndex = GetCenter(0, input.Length);
            var leftSide = Sort(input[0..centerIndex]);
            var rightSide = Sort(input[centerIndex..input.Length]);
            var result = new int[input.Length];

            var leftIndex = 0;
            var rightIndex = 0;
            var resultIndex = 0;
            while(leftIndex < leftSide.Length && rightIndex < rightSide.Length)
            {
                if (leftSide[leftIndex] > rightSide[rightIndex])
                {
                    result[resultIndex] = rightSide[rightIndex];
                    resultIndex++;
                    rightIndex++;
                }
                else
                {
                    result[resultIndex] = leftSide[leftIndex];
                    resultIndex++;
                    leftIndex++;
                }
            }
            while (leftIndex < leftSide.Length) 
            {
                result[resultIndex] = leftSide[leftIndex];
                resultIndex++;
                leftIndex++;
            }
            while (rightIndex < rightSide.Length) 
            {
                result[resultIndex] = rightSide[rightIndex];
                resultIndex++;
                rightIndex++;
            }

            return result;
        }

        internal static int GetCenter(int min, int max)
        {
            return (int)Math.Floor((min + max) / 2m);
        }
    }
}
