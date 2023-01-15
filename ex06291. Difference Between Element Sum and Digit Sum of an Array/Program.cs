// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = new int[] { 1, 15, 6, 3 };
var output1 = solution.DifferenceOfSum(input1);
Console.WriteLine(string.Join(",", output1)); // 50

var input2 = new int[] { 1, 2, 3, 4 };
var output2 = solution.DifferenceOfSum(input2);
Console.WriteLine(string.Join(",", output2)); // 50



public class Solution
{
    public int DifferenceOfSum(int[] nums)
    {
        var sum = 0;
        var digit = 0;
        foreach (var num in nums)
        {
            sum += num;

            var item = num;
            while (item > 0)
            {
                digit += item % 10;
                item = (int)item / 10;
            }
        }

        return sum - digit;
    }
}