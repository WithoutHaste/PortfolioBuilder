using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("DiagnosticsTest")]

namespace Diagnostics;

public static class Exercise11
{
	static void Main(string[] args)
	{
		var results = TimeSortingAlgorithms();
		foreach (var result in results) 
		{
            Console.WriteLine(result);
        }
    }

	internal static TimingResult[] TimeSortingAlgorithms()
	{
		var results = new List<TimingResult>();
		var inputLabelRandom = "random input";
		var inputLabelWorstCase = "worst case input";

		var random = new Random();
		var inputRandom = new int[10000];
		for (var i = 0; i < inputRandom.Length; i++) 
		{
			inputRandom[i] = random.Next(1, 10001);
		}
		var inputWorstCase = inputRandom.ToList().OrderByDescending(n => n).ToArray();

        var bubbleSortInputRandom = inputRandom.ToList().ToArray(); //copy
        var bubbleSortInputWorstCase = inputWorstCase.ToList().ToArray(); //copy
        var quickSortInputRandom = inputRandom.ToList().ToArray(); //copy
        var quickSortInputWorstCase = inputWorstCase.ToList().ToArray(); //copy

        var stopwatch = new Stopwatch();
		stopwatch.Start();
		BubbleSort.Sort(ref bubbleSortInputRandom);
		stopwatch.Stop();
		results.Add(new TimingResult()
		{
			AlgorithmLable = BubbleSort.Label,
			InputLabel = inputLabelRandom,
			MillisecondRunTime = stopwatch.ElapsedMilliseconds,
		});

		stopwatch.Reset();
        stopwatch.Start();
        BubbleSort.Sort(ref bubbleSortInputWorstCase);
        stopwatch.Stop();
        results.Add(new TimingResult()
        {
            AlgorithmLable = BubbleSort.Label,
            InputLabel = inputLabelWorstCase,
            MillisecondRunTime = stopwatch.ElapsedMilliseconds,
        });

        stopwatch.Reset();
        stopwatch.Start();
        QuickSort.Sort(ref quickSortInputRandom);
        stopwatch.Stop();
        results.Add(new TimingResult()
        {
            AlgorithmLable = QuickSort.Label,
            InputLabel = inputLabelRandom,
            MillisecondRunTime = stopwatch.ElapsedMilliseconds,
        });

        stopwatch.Reset();
        stopwatch.Start();
        QuickSort.Sort(ref quickSortInputWorstCase);
        stopwatch.Stop();
        results.Add(new TimingResult()
        {
            AlgorithmLable = QuickSort.Label,
            InputLabel = inputLabelWorstCase,
            MillisecondRunTime = stopwatch.ElapsedMilliseconds,
        });

        stopwatch.Reset();
        stopwatch.Start();
        MergeSort.Sort(inputRandom);
        stopwatch.Stop();
        results.Add(new TimingResult()
        {
            AlgorithmLable = MergeSort.Label,
            InputLabel = inputLabelRandom,
            MillisecondRunTime = stopwatch.ElapsedMilliseconds,
        });

		stopwatch.Reset();
        stopwatch.Start();
        MergeSort.Sort(inputWorstCase);
        stopwatch.Stop();
        results.Add(new TimingResult()
        {
            AlgorithmLable = MergeSort.Label,
            InputLabel = inputLabelWorstCase,
            MillisecondRunTime = stopwatch.ElapsedMilliseconds,
        });

        return results.ToArray();
	}

	internal struct TimingResult
	{
		public string AlgorithmLable;
		public string InputLabel;
		public long MillisecondRunTime;

		public override string ToString() 
		{
			return String.Format("{0}: {1}: {2} ms", AlgorithmLable, InputLabel, MillisecondRunTime);
		}
	}
}
