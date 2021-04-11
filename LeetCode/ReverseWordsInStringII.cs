using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class ReverseWordsInStringII
	{
		public static void ReverseWords(char[] s)
		{
			var str = string.Concat(s);
			var words = str.Trim().Split(" ");
			Array.Reverse(words);
			var result = string.Join(" ", words).ToCharArray();
			for (int i = 0; i < s.Length; i++)
			{
				s[i] = result[i];
			}
		}

		public static void ReverseWords2(char[] s)
		{
			var str = string.Concat(s);
			var words = str.Trim().Split(" ");
			Array.Reverse(words);
			var result = string.Join(" ", words).ToCharArray();
			for (int i = 0; i < s.Length; i++)
			{
				s[i] = result[i];
			}
		}
	}
}
