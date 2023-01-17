// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var s11 = "parker";
var s21 = "morris";
var base1 = "parser";
var output1 = solution.SmallestEquivalentString(s11, s21, base1);
Console.WriteLine(output1.ToString()); // makkek

var s12 = "parker";
var s22 = "morris";
var base2 = "parser";
var output2 = solution.SmallestEquivalentString(s12, s22, base2);
Console.WriteLine(output2.ToString()); // hdld


// TODO
public class Solution
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        var dic = new Dictionary<char, SortedList<char, char>>();

        for (int i = 0; i < s1.Length; i++)
        {
            if (dic.ContainsKey(s1[i]) && !dic[s1[i]].ContainsKey(s2[i]))
            {
                dic[s1[i]].Add(s2[i], s2[i]);

                foreach (var item in dic[s1[i]])
                {
                    if (dic.ContainsKey(item.Key))
                    {
                        dic[item.Key] = dic[s1[i]];
                    }
                    else
                    {
                        dic.Add(item.Key, dic[s1[i]]);
                    }
                }
            }
            else if (!dic.ContainsKey(s1[i]))
            {
                var list = new SortedList<char, char>
                {
                    { s2[i], s2[i] }
                };

                dic.Add(s1[i], list);
            }
        }



        return string.Empty;
    }
}