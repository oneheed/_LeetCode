// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var word1 = new string[] { "cba", "daf", "ghi" };
var output1 = solution.MinDeletionSize(word1);
Console.WriteLine(output1.ToString()); // 1

var word2 = new string[] { "a", "b" };
var output2 = solution.MinDeletionSize(word2);
Console.WriteLine(output2.ToString()); // 0


var word3 = new string[] { "zyx", "wvu", "tsr" };
var output3 = solution.MinDeletionSize(word3);
Console.WriteLine(output3.ToString()); // 3


public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        if (strs?.Length == 0)
        {
            return 0;
        }

        var result = 0;

        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 0; j < strs.Length - 1; j++)
            {
                if (strs[j][i] > strs[j + 1][i])
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }
}
