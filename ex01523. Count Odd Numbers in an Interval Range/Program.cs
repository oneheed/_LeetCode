// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var low1 = 3;
var high1 = 7;
var output1 = solution.CountOdds(low1, high1);
Console.WriteLine(output1); // 3

var low2 = 8;
var high2 = 10;
var output2 = solution.CountOdds(low2, high2);
Console.WriteLine(output2); // 1

var low3 = 3;
var high3 = 8;
var output3 = solution.CountOdds(low3, high3);
Console.WriteLine(output3); // 3

var low4 = 4;
var high4 = 5;
var output4 = solution.CountOdds(low4, high4);
Console.WriteLine(output4); // 1

public class Solution
{
    public int CountOdds(int low, int high)
    {
        low = low % 2 == 1 ? low : low + 1;
        high = high % 2 == 1 ? high : high - 1;

        return (high - low) / 2 + 1;
    }
}