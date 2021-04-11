using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public static class StrobogrammaticNumber
	{
		public static bool IsStrobogrammatic(string num)
		{
			var chars = num.ToCharArray();
			int i = 0;
			do
			{
				if (!IsStrobogrammatic(chars[i], chars[chars.Length - 1 - i]))
					return false;
				i++;

			} while (i <= chars.Length / 2);

			return true;
		}

		public static bool IsStrobogrammatic(char a, char b)
		{
			if (a == b && ( a == '0' || a == '1' || a == '8'))
				return true;
			if (a == '6' && b == '9')
				return true;
			if (a == '9' && b == '6')
				return true;

			return false;
		}
	}
}
