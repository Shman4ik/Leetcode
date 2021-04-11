using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
	public class LetterCombinationsClass
	{
		private const string separation = ";";
		public static string[] two = new string[3] { "a", "b", "c" };
		public static string[] three = new string[3] { "d", "e", "f" };
		public static string[] four = new string[3] { "g", "h", "i" };
		public static string[] five = new string[3] { "j", "k", "l" };
		public static string[] six = new string[3] { "m", "n", "o" };
		public static string[] seven = new string[4] { "p", "q", "r", "s" };
		public static string[] eight = new string[3] { "t", "u", "v" };
		public static string[] nine = new string[4] { "w", "x", "y", "z" };

		public static Dictionary<char, string[]> test = new Dictionary<char, string[]>
		{
			{ '2', two },
			{ '3', three },
			{ '4', four },
			{ '5', five},
			{ '6', six },
			{ '7', seven },
			{ '8', eight },
			{ '9', nine }
		};

		//public static IList<string> LetterCombinations(string digits)
		//{
		//	var chars = digits.ToCharArray();
		//	if (chars.Length == 0)
		//		return null;

		//}

		//private static List<string> test(List<string> resul, string[] a, string[] b, string[] c, string[] d)
		//{
		//	resul.Add(a[0] + b[0] + c[0] + d[0]);
		//	test(resul, a.TakeLast(a.Length - 1).ToArray(), b, c, d);

		//	if (a.Length == 1 && b.Length == 1)
		//		return resul.Add(a.)

		//	return null;
		//}


		public static IList<string> LetterCombinations2(string digits)
		{
			var chars = digits.ToCharArray();
			if (chars.Length == 0)
				return new string[0];
			var str = new List<string>();
			if (chars.Length >= 1)
			{
				foreach (var item0 in test[chars[0]])
				{
					if (chars.Length >= 2)
					{
						foreach (var item1 in test[chars[1]])
						{
							if (chars.Length >= 3)
							{
								foreach (var item2 in test[chars[2]])
								{

									if (chars.Length >= 4)
									{
										foreach (var item3 in test[chars[3]])
										{
											str.Add(item0 + item1 + item2 + item3);
										}
									}
									else
									{
										str.Add(item0 + item1 + item2 );
									}
								}
							}
							else
							{
								str.Add(item0 + item1);
							}
						}
					}
					else
					{
						str.Add(item0);
					}

				}
			}
			return str;
		}
	}
}
