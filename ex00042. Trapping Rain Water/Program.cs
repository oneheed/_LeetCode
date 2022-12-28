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

var input4 = new int[] { 5, 4, 1, 2 };
var output4 = solution.Trap(input4);
Console.WriteLine(output4); // 1

var input5 = new int[] { 1, 7, 5 };
var output5 = solution.Trap(input5);
Console.WriteLine(output5); // 0

var input6 = new int[] { 0, 1, 2, 0, 3, 0, 1, 2, 0, 0, 4, 2, 1, 2, 5, 0, 1, 2, 0, 2 };
var output6 = solution.Trap(input6);
Console.WriteLine(output6); // 26

var input7 = new int[] { 4, 3, 3, 9, 3, 0, 9, 2, 8, 3 };
var output7 = solution.Trap(input7);
Console.WriteLine(output7); // 23

var input8 = new int[] { 4, 9, 4, 5, 3, 2 };
var output8 = solution.Trap(input8);
Console.WriteLine(output8); // 1

public class Solution
{
    public int Trap(int[] height)
    {

        if (height == null || height.Length == 0)
            return 0;

        int i = 0, j = height.Length - 1, res = 0;
        int leftHighest = 0, rightHighest = 0;
        while (i <= j)
        {
            if (height[i] < height[j])
            {
                if (height[i] < leftHighest)
                    res += leftHighest - height[i];
                else
                    leftHighest = height[i];

                i++;
            }
            else
            {
                if (height[j] < rightHighest)
                    res += rightHighest - height[j];
                else
                    rightHighest = height[j];

                j--;
            }
        }

        return res;
    }
}