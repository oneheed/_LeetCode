// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var scores1 = new int[] { 1, 3, 5, 10, 15 };
var ages1 = new int[] { 1, 2, 3, 4, 5 };
var output1 = solution.BestTeamScore(scores1, ages1);
Console.WriteLine(output1.ToString()); // 34


var scores2 = new int[] { 4, 5, 6, 5 };
var ages2 = new int[] { 2, 1, 2, 1 };
var output2 = solution.BestTeamScore(scores2, ages2);
Console.WriteLine(output2.ToString()); // 16

var scores3 = new int[] { 1, 2, 3, 5 };
var ages3 = new int[] { 8, 9, 10, 1 };
var output3 = solution.BestTeamScore(scores3, ages3);
Console.WriteLine(output3.ToString()); // 6

var scores4 = new int[] { 5, 2, 3, 1 };
var ages4 = new int[] { 8, 9, 10, 1 };
var output4 = solution.BestTeamScore(scores4, ages4);
Console.WriteLine(output4.ToString()); // 6


var scores5 = new int[] { 1, 2, 3, 1 };
var ages5 = new int[] { 1, 1, 1, 3 };
var output5 = solution.BestTeamScore(scores5, ages5);
Console.WriteLine(output5.ToString()); // 3


// TODO:
// 年輕玩家的得分嚴格高於年長玩家
// 同齡玩家之間不會發生衝突
public class Solution
{
    public int BestTeamScore(int[] scores, int[] ages)
    {
        int n = scores.Length;
        (int s, int a)[] data = new (int s, int a)[n];
        for (int i = 0; i < n; i++)
        {
            data[i] = (scores[i], ages[i]);
        }

        Array.Sort(data, (d1, d2) =>
        {
            var cmp = d1.a.CompareTo(d2.a);
            if (cmp != 0)
            {
                return cmp;
            }

            return d1.s.CompareTo(d2.s);
        });

        Console.WriteLine(string.Join(",", data));

        int[] dp = new int[n];

        for (int i = 0; i < n; i++)
        {
            dp[i] = data[i].s;

            for (int j = 0; j < i; j++)
            {
                if (data[j].a == data[i].a)
                {
                    Console.WriteLine($"!! {i}, {j}, {dp[i]}, {data[i].s + dp[j]}");
                    dp[i] = Math.Max(dp[i], data[i].s + dp[j]);
                }
                else if (data[j].a < data[i].a && data[j].s <= data[i].s)
                {
                    dp[i] = Math.Max(dp[i], data[i].s + dp[j]);
                }
            }
        }

        Console.WriteLine(string.Join(",", dp));

        int res = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            res = Math.Max(res, dp[i]);
        }

        return res;
    }
}