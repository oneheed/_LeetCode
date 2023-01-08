// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var input1 = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
var output1 = solution.GroupAnagrams(input1);
Console.WriteLine(string.Join(",", output1.Select(x => $"[{string.Join(",", x)}]"))); // [["bat"],["nat","tan"],["ate","eat","tea"]]


var input2 = new string[] { "bdddddddddd", "bbbbbbbbbbc" };
var output2 = solution.GroupAnagrams(input2);
Console.WriteLine(string.Join(",", output2.Select(x => $"[{string.Join(",", x)}]"))); // [["bbbbbbbbbbc"],["bdddddddddd"]]

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dic = new Dictionary<string, IList<string>>();
        foreach (var str in strs)
        {
            var chars = new char[26];
            foreach (var c in str)
            {
                chars[c - 'a']++;
            }

            var key = new string(chars);
            //Console.WriteLine(key);

            if (dic.ContainsKey(key))
            {
                dic[key].Add(str);
            }
            else
            {
                dic[key] = new List<string> { str };
            }
        }

        return dic.Values.ToList();
    }
}