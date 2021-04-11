using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
	public class TrappingRainWaterSolution
	{
		// height = [0,1,0,2,1,0,1,3,2,1,2,1]  Output: 6
		// Input: height = [4,2,0,3,2,5]  Output: 9
		public static int Trap(int[] height)
		{
			var wall = 0;
			var water = new int[height.Length];
			for (var i = 0; i < water.Length; i++)
			{
				wall = Math.Max(wall, height[i]);
				water[i] = wall - height[i];
			}
			wall = 0;
			var sum = 0;
			for (var i = water.Length - 1; i >= 0; i--)
			{
				wall = Math.Max(wall, height[i]);
				water[i] = Math.Min(water[i], wall - height[i]);
				sum += water[i];
			}
			return sum;
		}


		public static int Trap3(int[] height)
		{
			if (height == null || height.Length <= 2)
				return 0;

			var maxHeight = height.Max();

			var result = 0;
			for (int j = 0; j < maxHeight; j++)
			{
				for (int i = 0; i < height.Length; i++)
				{
					if (height[i] <= j)
					{
						if (i - 1 >= 0 && height[i - 1] > j)
						{
							if (i + 1 < height.Length && height[i + 1] > j)
							{
								result++;
							}
							else
							{
								for (int k = i; k < height.Length; k++)
								{
									if (k + 1 < height.Length && height[k + 1] > j)
									{
										for (int t = i; t <= k; t++)
										{
											result++;
										}
										break;
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		public static int Trap2(int[] height)
		{
			if (height == null || height.Length <= 2)
				return 0;

			var maxHeight = height.Max();
			var map = new int[height.Length, maxHeight];

			for (int i = 0; i < height.Length; i++)
			{
				for (int j = 0; j < height[i]; j++)
				{
					map[i, j] = 1;
				}
			}
			for (int j = maxHeight - 1; j >= 0; j--)
			{
				for (int i = 0; i < height.Length; i++)
				{
					if (map[i, j] != 1)
					{
						if (i - 1 >= 0 && map[i - 1, j] > 0)
						{
							if (i + 1 < height.Length && map[i + 1, j] > 0)
							{
								map[i, j] = 2;
							}
							else
							{
								for (int k = i; k < height.Length; k++)
								{
									if (k + 1 < height.Length && map[k + 1, j] > 0)
									{
										for (int t = i; t < k; t++)
										{
											map[t, j] = 2;
										}
										break;
									}
								}
							}
						}
					}

					Console.Write(map[i, j]);

				}
				Console.Write(Environment.NewLine);
			}

			var result = 0;
			for (int i = 0; i < height.Length; i++)
			{
				for (int j = 0; j < maxHeight; j++)
				{
					if (map[i, j] == 2)
						result++;
				}
			}

			return result;
		}
	}
}
