using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class LongestSubstringWithoutRepeatingCharactersSolution
	{
		public static int LengthOfLongestSubstring(string s)
		{
			if (string.IsNullOrEmpty(s))
				return 0;
			var symbols = s.ToCharArray();
			if (symbols.Length == 1)
				return 1;
			var result = 0; var i = 0; var l = 1;
			do
			{
				var sybstrings = s.Substring(i, l);
				if (result < sybstrings.Length)
					result = sybstrings.Length;
				if (i + l < symbols.Length)
				{
					if (sybstrings.Contains(symbols[i + l]))
					{
						i++;
						if (l > 1)
							l--;
					}
					else
					{
						l++;
					}
				}
				else
				{
					return result;
				}
			} while (i + l <= symbols.Length);
			return result;
		}
	}
}
