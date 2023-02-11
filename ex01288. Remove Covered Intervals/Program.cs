// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var intervals1 = new int[][] { new int[] { 1, 4 }, new int[] { 3, 6 }, new int[] { 2, 8 } };
var output1 = solution.RemoveCoveredIntervals(intervals1);
Console.WriteLine(output1.ToString()); // 2

var intervals2 = new int[][] { new int[] { 1, 4 }, new int[] { 3, 6 }, new int[] { 2, 8 } };
var output2 = solution.RemoveCoveredIntervals(intervals2);
Console.WriteLine(output2.ToString()); // 2



public class Solution
{
    public int RemoveCoveredIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) =>
        {
            if (x[0] == y[0])
            {
                return y[1] - x[1];
            }

            return x[0] - y[0];
        });

        var res = 0;
        var r = 0;
        for (int i = 0; i < intervals.Length; i++)
        {
            if (intervals[i][1] > r)
            {
                res++;
                r = intervals[i][1];
            }
        }

        return res;
    }
}