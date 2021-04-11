using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public class SortColorsClass
	{
		public static void SortColors(int[] nums)
		{
			int min = 0;
			int i = 0;
			int sortedI = 0;
			do
			{
				if (i == nums.Length)
				{
					i = sortedI;
					min++;
					continue;
				}

				if (nums[i] == min)
				{
					if (i == sortedI)
						sortedI++;
					else
					{
						var temp = nums[sortedI];
						nums[sortedI] = nums[i];
						nums[i] = temp;
						sortedI++;
					}
					i = sortedI;
					continue;
				}

				

				if (i > sortedI)
				{
					if (nums[i] == min)
					{
						var temp = nums[sortedI];
						nums[sortedI] = nums[i];
						nums[i] = temp;
					}
				}
				i++;
			} while (min < 3);
		}
	}
}
