namespace LeetCodeTest;

public class RunningSumOf1dArray
{
    public int[] RunningSumLinq(int[] nums)
    {
        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums.Take(i + 1).Sum();
        }
        return result;
    }

    public int[] RunningSumMy(int[] nums)
    {
        var result = new int[nums.Length];
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                result[i] += nums[j];
            }
        }
        return result;
    }

    public int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i - 1] + nums[i];
        }

        return nums;
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
    public void Test1(int[] input, int[] expected)
    {
        var result = RunningSum(input);
        result.Should().Equal(expected);
    }
}
