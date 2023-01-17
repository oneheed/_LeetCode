// See https://aka.ms/new-console-template for more information
var solution = new Solution1();

//var input1 = new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } };
//var newInterval1 = new int[] { 2, 5 };
//var output1 = solution.Insert(input1, newInterval1);
//Console.WriteLine(string.Join(",", output1.Select(x => $"[{string.Join(",", x)}]"))); // [[1,5],[6,9]]


var input2 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 6, 7 }, new int[] { 8, 10 }, new int[] { 12, 16 } };
var newInterval2 = new int[] { 4, 8 };
var output2 = solution.Insert(input2, newInterval2);
Console.WriteLine(string.Join(",", output2.Select(x => $"[{string.Join(",", x)}]"))); // [[1,2],[3,10],[12,16]]

var input3 = new int[][] { };
var newInterval3 = new int[] { 5, 7 };
var output3 = solution.Insert(input3, newInterval3);
Console.WriteLine(string.Join(",", output3.Select(x => $"[{string.Join(",", x)}]"))); // [[5, 7]]

var input4 = new int[][] { new int[] { 1, 5 } };
var newInterval4 = new int[] { 6, 8 };
var output4 = solution.Insert(input4, newInterval4);
Console.WriteLine(string.Join(",", output4.Select(x => $"[{string.Join(",", x)}]"))); // [[1,5],[6, 8]]

var input5 = new int[][] { new int[] { 1, 5 } };
var newInterval5 = new int[] { 0, 3 };
var output5 = solution.Insert(input5, newInterval5);
Console.WriteLine(string.Join(",", output5.Select(x => $"[{string.Join(",", x)}]"))); // [[0, 5]]

var input6 = new int[][] { new int[] { 3, 5 }, new int[] { 12, 15 } };
var newInterval6 = new int[] { 6, 6 };
var output6 = solution.Insert(input6, newInterval6);
Console.WriteLine(string.Join(",", output6.Select(x => $"[{string.Join(",", x)}]"))); // [[3, 5 ],[6, 6],[12, 15]]


public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new int[intervals.Length + 2][];
        var s = 0;
        var e = 0;

        if (intervals.Length == 0)
        {
            return new int[][] { newInterval };
        }

        if (newInterval[1] < intervals[0][0])
        {
            result[e] = newInterval;
            e++;
        }

        for (int i = 0; i < intervals.Length; i++)
        {
            if ((newInterval[0] >= intervals[i][0] && newInterval[0] <= intervals[i][1]) ||
                (newInterval[1] >= intervals[i][0] && newInterval[1] <= intervals[i][1]) ||
                (intervals[i][1] >= newInterval[0] && intervals[i][1] <= newInterval[1]))
            {
                while (i < intervals.Length &&
                    ((newInterval[0] >= intervals[i][0] && newInterval[0] <= intervals[i][1]) ||
                     (newInterval[1] >= intervals[i][0] && newInterval[1] <= intervals[i][1]) ||
                     (intervals[i][1] >= newInterval[0] && intervals[i][1] <= newInterval[1])))
                {
                    newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                    newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                    i++;

                    //Console.WriteLine($"{newInterval[0]}, {newInterval[1]}");
                }

                result[e] = newInterval;
                e++;
                i--;
            }
            else if (i > 0 && newInterval[0] > intervals[i - 1][1] && newInterval[1] < intervals[i][0])
            {
                result[e] = newInterval;
                e++;

                result[e] = intervals[i];
                e++;
            }
            else
            {
                result[e] = intervals[i];
                e++;
            }
        }

        if (newInterval[0] > intervals[intervals.Length - 1][1])
        {
            result[e] = newInterval;
            e++;
        }

        return result[s..e];
    }
}

public class Solution1
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();
        var i = 0;
        while (i < intervals.Length && intervals[i][1] < newInterval[0])
        {
            result.Add(intervals[i]);
            i++;
        }

        while (i < intervals.Length && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
            newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
            i++;
        }

        result.Add(newInterval);

        while (i < intervals.Length)
        {
            result.Add(intervals[i]);
            i++;
        }

        return result.ToArray();
    }
}