// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums1 = new int[] { 7, 2, 5, 10, 8 };
var t1 = 2;
var output1 = solution.SplitArray(nums1, t1);
Console.WriteLine(output1); // true

var nums2 = new int[] { 1, 2, 3, 4, 5 };
var t2 = 2;
var output2 = solution.SplitArray(nums2, t2);
Console.WriteLine(output2); // false


public class Solution
{
    public int SplitArray(int[] nums, int k)
    {
        var l = nums.Max();
        var r = nums.Sum();

        while (l < r)
        {
            var m = l + (r - l) / 2;
            var sum = 0;
            var count = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sum > m)
                {
                    sum = nums[i];
                    count++;
                }
            }

            if (count > k)
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }

        return l;
    }
}