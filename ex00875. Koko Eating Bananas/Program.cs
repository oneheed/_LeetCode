// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = new int[] { 3, 6, 7, 11 };
var h1 = 8;
var output1 = solution.MinEatingSpeed(input1, h1);
Console.WriteLine(string.Join(",", output1)); // 4

var input2 = new int[] { 30, 11, 23, 4, 20 };
var h2 = 5;
var output2 = solution.MinEatingSpeed(input2, h2);
Console.WriteLine(string.Join(",", output2)); // 30

var input3 = new int[] { 30, 11, 23, 4, 20 };
var h3 = 6;
var output3 = solution.MinEatingSpeed(input3, h3);
Console.WriteLine(string.Join(",", output3)); // 23

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        var l = 1;
        var r = piles.Max();

        while (l < r)
        {
            var m = l + (r - l) / 2;
            var total = 0.0;
            foreach (var pile in piles)
            {
                total += Math.Ceiling((double)pile / m);
            }

            if (total > h)
                l = m + 1;
            else
                r = m;
        }

        return l;
    }
}