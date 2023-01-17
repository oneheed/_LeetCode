// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = new int[] { -1, 0, 3, 5, 9, 12 };
var target1 = 9;
var output1 = solution.Search(input1, target1);
Console.WriteLine(output1.ToString()); // 4

var input2 = new int[] { -1, 0, 3, 5, 9, 12 };
var target2 = 2;
var output2 = solution.Search(input2, target2);
Console.WriteLine(output2.ToString()); // -1

var input3 = new int[] { 5 };
var target3 = 5;
var output3 = solution.Search(input3, target3);
Console.WriteLine(output3.ToString()); // 0


public class Solution
{
    public int Search(int[] nums, int target)
    {
        var l = 0;
        var r = nums.Length - 1;
        while (l <= r)
        {
            var index = (l + r) / 2;

            if (nums[index] == target)
                return index;
            else if (nums[index] > target)
                r = index - 1;
            else
                l = index + 1;
        }

        return -1;
    }
}