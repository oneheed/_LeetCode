// See https://aka.ms/new-console-template for more information
var solution = new Solution1();

var input1 = new int[][] { new int[] { 10, 16 }, new int[] { 2, 8 }, new int[] { 1, 6 }, new int[] { 7, 12 } };
var output1 = solution.FindMinArrowShots(input1);
Console.WriteLine(output1.ToString()); // 2

var input2 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 } };
var output2 = solution.FindMinArrowShots(input2);
Console.WriteLine(output2.ToString()); // 4

var input3 = new int[][] { new int[] { 3, 9 }, new int[] { 7, 12 }, new int[] { 3, 8 }, new int[] { 6, 8 }, new int[] { 9, 10 }, new int[] { 2, 9 }, new int[] { 0, 9 }, new int[] { 3, 9 }, new int[] { 0, 6 }, new int[] { 2, 8 } };
var output3 = solution.FindMinArrowShots(input3);
Console.WriteLine(output3.ToString()); // 2

var input4 = new int[][] { new int[] { 1, 9 }, new int[] { 7, 16 }, new int[] { 2, 5 }, new int[] { 7, 12 }, new int[] { 9, 11 }, new int[] { 2, 10 }, new int[] { 9, 16 }, new int[] { 3, 9 }, new int[] { 1, 3 } };
var output4 = solution.FindMinArrowShots(input4);
Console.WriteLine(output4.ToString()); // 2

var input5 = new int[][] { new int[] { 1, 3 }, new int[] { 4, 4 }, new int[] { 3, 5 } };
var output5 = solution.FindMinArrowShots(input5);
Console.WriteLine(output5.ToString()); // 2


public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (p1, p2) => p1[0].CompareTo(p2[0]));
        Console.WriteLine(string.Join(",", points.Select(p => $"[{p[0]}, {p[1]}]")));
        var result = 0;

        var i = 0;
        while (i < points.Count() - 1)
        {
            var left = points[i];
            for (int j = i + 1; j < points.Count(); j++)
            {
                i = j;
                if (left[1] < points[j][0])
                {
                    result++;
                    break;
                }

                left[0] = Math.Max(left[0], points[j][0]);
                left[1] = Math.Min(left[1], points[j][1]);
                //Console.WriteLine($"{i} :[{left[0]}, {left[1]}]");
            }
        }

        return result + 1;
    }
}

public class Solution1
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (p1, p2) => p1[0].CompareTo(p2[0]));
        //Console.WriteLine(string.Join(",", points.Select(p => $"[{p[0]}, {p[1]}]")));
        var result = 1;

        var left = points[0];
        for (int i = 1; i < points.Count(); i++)
        {
            //Console.WriteLine($"{i} [{points[i][0]}, {points[i][1]}] :[{left[0]}, {left[1]}]");
            if (left[1] < points[i][0])
            {
                result++;
                left = points[i];
            }
            else
            {
                left[1] = Math.Min(left[1], points[i][1]);
            }
        }

        return result;
    }
}


public class Solution2
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (x, y) => x[1].CompareTo(y[1]));
        Console.WriteLine(string.Join(",", points.Select(p => $"[{p[0]}, {p[1]}]")));
        int currentIndex = points[0][1];
        int shots = 1;


        for (int i = 1; i < points.Length; i++)
        {
            if (points[i][0] > currentIndex)
            {
                shots++;
                currentIndex = points[i][1];
            }
        }

        return shots;
    }
}