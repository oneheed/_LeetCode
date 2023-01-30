// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var n1 = 2;
var trust1 = new int[][] { new int[] { 1, 2 } };
var output1 = solution.FindJudge(n1, trust1);
Console.WriteLine(output1.ToString()); // true


var n2 = 3;
var trust2 = new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 } };
var output2 = solution.FindJudge(n2, trust2);
Console.WriteLine(output2.ToString()); // true


var n3 = 3;
var trust3 = new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 3, 1 } };
var output3 = solution.FindJudge(n3, trust3);
Console.WriteLine(output3.ToString()); // true



public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        var temp = new int[n + 1];

        foreach (var t in trust)
        {
            temp[t[1]]++;
        }
        //Console.WriteLine(string.Join(",", temp));
        var index = temp.Select((v, i) => (v, i)).SingleOrDefault(t => t.v == n - 1);

        return index == default || temp.Count(t => t > 0) > 1 ? -1 : index.i;
    }
}