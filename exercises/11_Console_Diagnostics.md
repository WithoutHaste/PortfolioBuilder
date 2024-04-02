# 11 Console: Diagnostics

**Purpose**: This exercise will show that you can collect basic performance metrics, implement a few sorting algorithms, generate random numbers, and use recursion.

For this exercise, sorting algorithms should always sort the integers into ascending order.

**Requirements**:  
- Implement Bubble Sort or Insertion Sort
- Implement Merge Sort
- Implement Quick Sort
- Generate an array of 10,000 random integers with values in range 1 to 10,000.
  - Have one copy of the array in the original, random order.
  - Have another copy of the array sorted into descending order (worst case input for a sorting algorithm).
- Record how long it takes each sorting algorithm to sort into ascending order: (a) the random array and (b) the worst case array.
- Output the results to the console. Expected output will show:
  - Bubble (or Insertion) Sort is slow in both cases.
  - Quick sort is fast on random data, but slow on worst case data.
  - Merge sort is fast on both random data and worst case data.
- Write unit tests:
  - Test each sorting algorithm.
    - Can sort an already-in-order array.
	- Can sort an unordered array.
	- Can handle arrays of length 0 and 1.
  - Test that timing metrics are returned for all the sorting algorithms.

**Bubble Sort**: The list/array is traversed as many times as needed. For each element N, if it is larger than element N+1, the two are swapped. This loop is continued until the list/array is fully sorted.

**Insertion Sort**: Starting with the first element of the list/array, consider this element the "sorted part of the list/array". Look at the next element in the list/array and swap it backwards until it is in the correct position in the "sorted part of the list/array" (now the sorted part is one element longer than before). Continue this loop until you reach the end of the list/array and the whole thing is sorted.

**Merge Sort**: Divide the list/array in half and recursively call Merge Sort on each half. Once the halves are sorted, merge them together into one sorted result list/array by iterating through each half, copying the smaller of the two current elements to the result list/array, until all elements are copied over.  
[Wikipedia](https://en.wikipedia.org/wiki/Merge_sort) has a good visualization of this.  

**Quick Sort**: Select a pivot-element for the array (any element). Swap all smaller elements to the left of the pivot and all larger elements to the right of the pivot. Recursively call Quick Sort on each sub-range of values to the left and right of the current pivot.  
[Wikipedia](https://en.wikipedia.org/wiki/Quicksort) has a good visualization of this.  
