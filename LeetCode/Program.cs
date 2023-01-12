using System;
using System.Linq;
using LeetCode.LinkedLists;

namespace LeetCode
{
	class Program
	{
		static void Main(string[] args)
		{
			var i = 1994;
			var result = $"  {i} = {IntegerToRoman.IntToRoman(i)}";
			Console.WriteLine(result);

			//for (int i = 1; i < 15; i++)
			//{
			//	Console.WriteLine($"{i} = {IntegerToRoman.IntToRoman(i)}");
			//}
			Console.ReadLine();

		}

		/*
		 * 
		 * Input: num = 3
Output: "III"
Explanation: 3 is represented as 3 ones.
Example 2:

Input: num = 58
Output: "LVIII"
Explanation: L = 50, V = 5, III = 3.
Example 3:

Input: num = 1994
Output: "MCMXCIV"
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
		 * */


		/*
		 * 
		 * 1 = I
2 = II
3 = III
4 = IV
5 = V
6 = VI
7 = VII
8 = VIII
9 = IX
10 = X
11 = XI
12 = XII
13 = XIII
14 = XIV
		 * */
	}
}
