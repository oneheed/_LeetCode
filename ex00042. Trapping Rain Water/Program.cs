// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
var output1 = solution.Trap(input1);
Console.WriteLine(output1); // 6

var input2 = new int[] { 4, 2, 0, 3, 2, 5 };
var output2 = solution.Trap(input2);
Console.WriteLine(output2); // 9

var input3 = new int[] { 4, 2, 3 };
var output3 = solution.Trap(input3);
Console.WriteLine(output3); // 1

public class Solution
{
    public int Trap(int[] height)
    {
        var result = 0;

        var left = 0;

        while (height[left] == 0)
            left++;

        while (left < height.Length - 2)
        {
            var diff = height[left + 1];
            var right = left + 2;
            var temp = Math.Min(height[left], height[right]) * (right - left - 1) - diff;

            while (temp < 0)
            {
                diff += height[right];
                right++;
                temp = Math.Min(height[left], height[right]) * (right - left - 1) - diff;
            }

            if (right == height.Length - 1 && temp > 0)
            {
                result += temp;
                break;
            }

            while (right < height.Length - 1)
            {
                diff += height[right];
                right++;

                var temp2 = Math.Min(height[left], height[right]) * (right - left - 1) - diff;
                if (temp > temp2)
                {
                    result += temp;
                    left = right - 1;
                    break;
                }

                temp = temp2;
            }
        }

        return result;
    }
}