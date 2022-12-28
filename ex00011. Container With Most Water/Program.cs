// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
var output1 = solution.MaxArea(input1);
Console.WriteLine(output1); // 49

var input2 = new int[] { 1, 1 };
var output2 = solution.MaxArea(input2);
Console.WriteLine(output2); // 1


public class Solution
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var result = int.MinValue;

        while (left < right)
        {
            var temp = Math.Min(height[left], height[right]) * (right - left);
            if (temp > result)
            {
                result = temp;
            }

            if (height[left] > height[right])
                right--;
            else
                left++;
        }

        return result;
    }
}