using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
	public class ValidPalindrome
	{
		public static bool IsPalindrome(string s)
		{
			if (string.IsNullOrEmpty(s))
				return false;

			var alphabetOnly = s.ToLower().ToCharArray()
	.Where(p => Char.IsLetterOrDigit(p)).ToArray();

			if (alphabetOnly.Length == 1)
				return true;

			for (int i = 0; i < alphabetOnly.Length / 2; i++)
			{
				if (alphabetOnly[i] != alphabetOnly[alphabetOnly.Length - i - 1])
					return false;
			}
			return true;

		}
	}
}
