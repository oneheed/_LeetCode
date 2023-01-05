// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var pattern1 = "abba";
var s1 = "dog cat cat dog";
var output1 = solution.WordPattern(pattern1, s1);
Console.WriteLine(output1.ToString()); // true

var pattern2 = "abba";
var s2 = "dog cat cat fish";
var output2 = solution.WordPattern(pattern2, s2);
Console.WriteLine(output2.ToString()); // false

var pattern3 = "aaaa";
var s3 = "dog cat cat dog";
var output3 = solution.WordPattern(pattern3, s3);
Console.WriteLine(output3.ToString()); // false

var pattern4 = "abba";
var s4 = "dog dog dog dog";
var output4 = solution.WordPattern(pattern4, s4);
Console.WriteLine(output4.ToString()); // false


public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var splits = s.Split(" ");
        var pairs = new Dictionary<char, string>();
        var hash = new HashSet<string>();
        if (pattern.Length != splits.Length)
            return false;

        for (int i = 0; i < pattern.Length; i++)
        {
            var c = pattern[i];

            if (pairs.TryGetValue(c, out string item))
            {
                if (item != splits[i])
                    return false;
            }
            else
            {
                if (hash.Contains(splits[i]))
                {
                    return false;
                }
                else
                {
                    hash.Add(splits[i]);
                    pairs.Add(c, splits[i]);
                }
            }
        }

        return true;
    }
}