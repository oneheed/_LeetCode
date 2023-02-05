// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var s1 = "cbaebabacd";
var p1 = "abc";
var output1 = solution.FindAnagrams(s1, p1);
Console.WriteLine(string.Join(",", output1)); // [0,6]

var s2 = "abab";
var p2 = "ab";
var output2 = solution.FindAnagrams(s2, p2);
Console.WriteLine(string.Join(",", output2)); //[0,1,2]


public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var result = new List<int>();
        var need = new Dictionary<char, int>();

        foreach (var c in p)
        {
            if (need.ContainsKey(c))
            {
                need[c]++;
            }
            else
            {
                need.Add(c, 1);
            }
        }

        var l = 0;
        for (int r = 0; r < s.Length; r++)
        {
            if (need.ContainsKey(s[r]))
            {
                need[s[r]]--;
            }

            if (r - l > p.Length - 1)
            {
                if (need.ContainsKey(s[l]))
                {
                    need[s[l]]++;
                }

                l++;
            }

            if (need.All(n => n.Value == 0))
            {
                result.Add(l);
            }
        }

        return result;
    }
}