// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var n1 = 3;
var input1 = new int[][] { new int[] { 1, 1, 2, 2 }, new int[] { 0, 0, 1, 1 } };
var output1 = solution.RangeAddQueries(n1, input1);
//Console.WriteLine(string.Join(",", output1)); // 50

var n2 = 2;
var input2 = new int[][] { new int[] { 0, 0, 1, 1 }, new int[] { 0, 0, 1, 1 } };
var output2 = solution.RangeAddQueries(n2, input2);
//Console.WriteLine(string.Join(",", output1)); // 50



public class Solution
{
    public int[][] RangeAddQueries(int n, int[][] queries)
    {
        var matrix = new int[n][];
        for (int i = 0; i < n; i++)
        {
            matrix[i] = new int[n];
        }

        foreach (var query in queries)
        {
            for (int i = query[0]; i <= query[2]; i++)
            {
                for (int j = query[1]; j <= query[3]; j++)
                {
                    matrix[i][j]++;
                }
            }
        }

        return matrix;
    }
}