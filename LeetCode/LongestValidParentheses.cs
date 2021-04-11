using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
	public class LongestValidParenthesesSolution
	{
		public static int LongestValidParentheses(string s)
		{
			if (string.IsNullOrEmpty(s))
				return 0;

			var chars = s.ToCharArray();
			var results = new List<int>();
			int result = 0;
			for (int i = 1; i < chars.Length; i++)
			{
				if (chars[i - 1] == '(' && chars[i - 1] != chars[i])
				{
					result += 2;
					i++;
				}
				else
				{
					results.Add(result);
					result = 0;
				}
			}
			results.Add(result);
			return results.Max();
		}
	}
}
