// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums1 = new int[] { 2, 7, 11, 15 };
var target1 = 9;
var output1 = solution.TwoSum(nums1, target1);
Console.WriteLine(string.Join(",", output1)); // 3

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i]))
            {
                return new int[] { dic[target - nums[i]], i };
            }

            dic[nums[i]] = i;
        }

        return new int[] { };
    }
}