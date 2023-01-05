// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var s1 = "ABAB";
var k1 = 2;
var output1 = solution.CharacterReplacement(s1, k1);
Console.WriteLine(output1.ToString()); // 4

var s2 = "AABABBA";
var k2 = 1;
var output2 = solution.CharacterReplacement(s2, k2);
Console.WriteLine(output2.ToString()); // 4

//var s3 = "ABAB";
//var k3 = 2;
//var output3 = solution.CharacterReplacement(s3, k3);
//Console.WriteLine(output3.ToString()); // 4

public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var dic = new Dictionary<char, int>();

        var left = 0;
        var right = 0;
        var result = 0;
        while (right < s.Length)
        {
            var c = s[right];
            if (dic.ContainsKey(c))
            {
                dic[c]++;
            }
            else
            {
                dic.Add(c, 1);
            }

            var sum = right - left + 1;
            var max = dic.Max(x => x.Value);
            if (sum - max > k)
            {
                result = Math.Max(result, max + k);
                dic[s[left]]--;
                left++;
            }

            right++;
        }

        return Math.Max(result, dic.Sum(x => x.Value));
    }
}