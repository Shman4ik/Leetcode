﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/*
	Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given an integer, convert it to a roman numeral.
	
	 Example 1:

Input: num = 3
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
	*/

	public class IntegerToRoman
	{

		public static string IntToRoman(int num)
		{
			var temp = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
			var romans = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };

			StringBuilder sb = new StringBuilder();

			for (int i = temp.Length - 1; i >= 0; i--)
			{
				if (num / temp[i] == 1)
				{
					sb.Append(romans[i]);
					num -= temp[i];

				}
				else if (num / temp[i] > 1 && num / temp[i] < 2)
				{
					sb.Append(romans[i]);
					num -= temp[i];
				}
				else if (num / temp[i] >= 2)
				{
					sb.Append(romans[i]);
					num -= temp[i];
					i = temp.Length - 1;
				}
				else if (num / temp[i] < 1)
				{
					if (i == 0)
					{
						do
						{
							sb.Append(romans[i]);
							num -= temp[i];
						} while (num != 0);
					}

					continue;
				}
				if (num == 0)
					return sb.ToString();
			}
			return sb.ToString();
		}
	}
}
