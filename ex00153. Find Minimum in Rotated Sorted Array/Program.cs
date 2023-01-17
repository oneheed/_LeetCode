// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums1 = new int[] { 3, 4, 5, 1, 2 };
var output1 = solution.FindMin(nums1);
Console.WriteLine(output1); // 1

var nums2 = new int[] { 4, 5, 6, 7, 0, 1, 2 };
var output2 = solution.FindMin(nums2);
Console.WriteLine(output2); // 0

var nums3 = new int[] { 11, 13, 15, 17 };
var output3 = solution.FindMin(nums3);
Console.WriteLine(output3); // 11

public class Solution
{
    public int FindMin(int[] nums)
    {
        var l = 0;
        var r = nums.Length - 1;

        while (l < r)
        {
            var m = l + (r - l) / 2;
            //Console.WriteLine($"{l} {m} {r}");
            if (nums[m] > nums[r])
                l = m + 1;
            else
                r = m;
        }

        return nums[r];
    }
}