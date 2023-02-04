// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var words1 = new string[] { "hello", "leetcode" };
var order1 = "hlabcdefgijkmnopqrstuvwxyz";
var output1 = solution.IsAlienSorted(words1, order1);
Console.WriteLine(output1.ToString()); // true

var words2 = new string[] { "word", "world", "row" };
var order2 = "worldabcefghijkmnpqstuvxyz";
var output2 = solution.IsAlienSorted(words2, order2);
Console.WriteLine(output2.ToString()); // false

var words3 = new string[] { "apple", "app" };
var order3 = "abcdefghijklmnopqrstuvwxyz";
var output3 = solution.IsAlienSorted(words3, order3);
Console.WriteLine(output3.ToString()); // false

public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {
        var dic = new Dictionary<char, int>();
        for (int i = 0; i < order.Length; i++)
        {
            dic.Add(order[i], order.Length - i);
        }

        for (int i = 0; i < words.Length - 1; i++)
        {
            for (var j = 0; j < words[i].Length; j++)
            {
                if (j >= words[i + 1].Length)
                    return false;
                else if (dic[words[i][j]] > dic[words[i + 1][j]])
                    break;
                else if (dic[words[i][j]] < dic[words[i + 1][j]])
                    return false;
            }
        }

        return true;
    }
}