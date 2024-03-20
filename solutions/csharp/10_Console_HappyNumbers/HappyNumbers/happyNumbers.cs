using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("HappyNumbersTest")]

namespace HappyNumbers;

public static class Exercise10
{
	static void Main(string[] args)
	{
		var max = 100;
		var happy = GenerateHappyNumbers(max);
		Console.WriteLine("Max: " + max);
		Console.WriteLine("Happy Numbers: " + string.Join(", ", happy));
	}

	///<returns>
	/// Happy numbers from 1 to max, in ascending order
	///</returns>	
	internal static int[] GenerateHappyNumbers(int max)
	{
		var happy = new HashSet<int>() { 1 };
		var unhappy = new HashSet<int>();
		
		for(int n = 2; n <= max; n++)
		{
			DetermineHappyOrNot(n, ref happy, ref unhappy);
		}
		
		return happy.Where(x => x <= max).OrderBy(x => x).ToArray();
	}

	/// <summary>
	/// Determines if N is happy or not
	/// And updates happy/unhappy collections along the way
	/// </summary>
	internal static void DetermineHappyOrNot(int n, ref HashSet<int> happy, ref HashSet<int> unhappy)
	{
		var path = new HashSet<int>() { n };
		var currentN = n;
		while(true) 
		{
			var nextN = Increment(currentN);
			if(path.Contains(nextN) || unhappy.Contains(nextN)) {
				unhappy.UnionWith(path);
				return;
			}
			if(happy.Contains(nextN)) {
				happy.UnionWith(path);
				return;
			}
			path.Add(nextN);
			currentN = nextN;
		}
	}

	/// <returns>
	/// Next number when applying Happy Number step calculation to N
	/// </returns>
	internal static int Increment(int n)
	{
		return Digits(n).Select(d => d*d).Sum();
	}

	/// <returns>
	/// Array of all digits in N, including repeats
	/// </returns>
	internal static int[] Digits(int n)
	{
		return n.ToString().ToCharArray().Select(c => ConvertCharToDigit(c)).ToArray();
	}

	internal static int ConvertCharToDigit(char c)
	{
		return c switch
		{
			'1' => 1,
			'2' => 2,
			'3' => 3,
			'4' => 4,
			'5' => 5,
			'6' => 6,
			'7' => 7,
			'8' => 8,
			'9' => 9,
			_ => 0
		};
	}
}
