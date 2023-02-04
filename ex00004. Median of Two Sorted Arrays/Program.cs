// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums11 = new int[] { 1, 3 };
var nums21 = new int[] { 2 };
var output1 = solution.FindMedianSortedArrays(nums11, nums21);
Console.WriteLine(output1); // 2

var nums12 = new int[] { 1, 2 };
var nums22 = new int[] { 3, 4 };
var output2 = solution.FindMedianSortedArrays(nums12, nums22);
Console.WriteLine(output2); // 2.5


public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var num = new int[nums1.Length + nums2.Length];
        var i = 0;

        foreach (var n in nums1)
        {
            num[i] = n; i++;
        }

        foreach (var n in nums2)
        {
            num[i] = n; i++;
        }

        Array.Sort(num);

        var index = (nums1.Length + nums2.Length) / 2;
        if ((nums1.Length + nums2.Length) % 2 == 1)
        {
            return num[index];
        }
        else
        {
            return (double)(num[index - 1] + num[index]) / 2;
        }
    }
}