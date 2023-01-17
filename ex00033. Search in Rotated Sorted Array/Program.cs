// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums1 = new int[] { 4, 5, 6, 7, 0, 1, 2 };
var target1 = 0;
var output1 = solution.Search(nums1, target1);
Console.WriteLine(output1); // 4

var nums2 = new int[] { 4, 5, 6, 7, 0, 1, 2 };
var target2 = 3;
var output2 = solution.Search(nums2, target2);
Console.WriteLine(output2); // -1

var nums3 = new int[] { 1 };
var target3 = 0;
var output3 = solution.Search(nums3, target3);
Console.WriteLine(output3); // -1

var nums4 = new int[] { 1 };
var target4 = 1;
var output4 = solution.Search(nums4, target4);
Console.WriteLine(output4); // 0

var nums5 = new int[] { 1, 2, 3, 4, 5, 6 };
var target5 = 4;
var output5 = solution.Search(nums5, target5);
Console.WriteLine(output5); // 3
public class Solution
{
    public int Search(int[] nums, int target)
    {
        var l = 0;
        var r = nums.Length - 1;

        while (l <= r)
        {
            var m = l + (r - l) / 2;

            if (nums[m] == target)
                return m;

            if (nums[m] >= nums[l])
            {
                if (target >= nums[l] && target <= nums[m])
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            else
            {
                if (target >= nums[m] && target <= nums[r])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
        }

        return -1;
    }
}