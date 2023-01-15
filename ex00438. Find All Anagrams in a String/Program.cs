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
                need[c]++;
            else
                need.Add(c, 1);
        }

        var l = 0;

        for (var r = 0; r < s.Length; r++)
        {
            //Console.WriteLine($"{l} {r}");

            var c = s[r];
            if (need.ContainsKey(c))
                need[c]--;

            if (need.All(c => c.Value == 0))
            {
                result.Add(r - p.Length + 1);

                var c2 = s[l];
                if (need.ContainsKey(c2))
                {
                    need[c2]++;
                }

                l++;
            }

            if (r - l == p.Length - 1)
            {
                var c2 = s[l];
                if (need.ContainsKey(c2))
                {
                    need[c2]++;
                }

                l++;
            }
        }

        return result;
    }
}