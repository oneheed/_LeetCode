// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var input1 = "abcabcbb";
var output1 = solution.LengthOfLongestSubstring(input1);
Console.WriteLine(output1); // 3

var input2 = "bbbbb";
var output2 = solution.LengthOfLongestSubstring(input2);
Console.WriteLine(output2); // 1

var input3 = "pwwkew";
var output3 = solution.LengthOfLongestSubstring(input3);
Console.WriteLine(output3); // 3

var input4 = " ";
var output4 = solution.LengthOfLongestSubstring(input4);
Console.WriteLine(output4); // 1

var input5 = "dvdf";
var output5 = solution.LengthOfLongestSubstring(input5);
Console.WriteLine(output5); // 3

var input6 = "abba";
var output6 = solution.LengthOfLongestSubstring(input6);
Console.WriteLine(output6); // 2

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var dic = new Dictionary<char, int>();
        var result = 0;
        var left = 0;
        for (int right = 0; right < s.Length; right++)
        {
            if (dic.ContainsKey(s[right]))
            {
                result = Math.Max(result, right - left);
                left = Math.Max(dic[s[right]] + 1, left);
                dic[s[right]] = right;
            }
            else
            {
                dic.Add(s[right], right);
            }
        }

        return Math.Max(result, s.Length - left);
    }
}