// See https://aka.ms/new-console-template for more information
var solution = new Solution();

//var s1 = "ac";
//var k1 = "b";
//var output4 = solution.IsItPossible(s1, k1);
//Console.WriteLine(string.Join(",", output4)); // false

//var s2 = "abcc";
//var k2 = "aab";
//var output5 = solution.IsItPossible(s2, k2);
//Console.WriteLine(string.Join(",", output5)); // true

var s3 = "abcde";
var k3 = "fghij";
var output6 = solution.IsItPossible(s3, k3);
Console.WriteLine(string.Join(",", output6)); // true


public class Solution
{
    public bool IsItPossible(string word1, string word2)
    {
        var l1 = new int[26];
        var l2 = new int[26];

        foreach (var item in word1)
        {
            l1[item - 'a']++;
        }

        foreach (var item in word2)
        {
            l2[item - 'a']++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (l1[i] == 0) continue;
            l1[i]--;

            for (int j = 0; j < 26; j++)
            {
                if (l2[j] == 0) continue;
                l2[j]--;

                l1[j]++;
                l2[i]++;

                if (l1.Count(l => l > 0) == l2.Count(l => l > 0))
                    return true;

                l1[j]--;
                l2[i]--;

                l2[j]++;
            }

            l1[i]++;
        }

        return false;
    }
}