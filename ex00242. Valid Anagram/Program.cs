// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var s1 = "anagram";
var t1 = "nagaram";
var output1 = solution.IsAnagram(s1, t1);
Console.WriteLine(output1); // true

var s2 = "rat";
var t2 = "car";
var output2 = solution.IsAnagram(s2, t2);
Console.WriteLine(output2); // false

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var dic = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            var c1 = s[i];
            var c2 = t[i];

            if (dic.ContainsKey(c1))
                dic[c1]++;
            else
                dic[c1] = 1;

            if (dic.ContainsKey(c2))
                dic[c2]--;
            else
                dic[c2] = -1;
        }

        return dic.All(x => x.Value == 0);
    }
}

public class Solution1
{
    public bool IsAnagram(string s, string t)
    {
        int[] alphabet = new int[26];
        for (int i = 0; i < s.Length; i++) alphabet[s[i] - 'a']++;
        for (int i = 0; i < t.Length; i++) alphabet[t[i] - 'a']--;
        foreach (int i in alphabet) if (i != 0) return false;
        return true;
    }
}