// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = "ab";
var s1 = "eidbaooo";
var output1 = solution.CheckInclusion(input1, s1);
Console.WriteLine(output1); // true

var input2 = "ab";
var s2 = "eidboaoo";
var output2 = solution.CheckInclusion(input2, s2);
Console.WriteLine(output2); // false

var input3 = "adc";
var s3 = "dcda";
var output3 = solution.CheckInclusion(input3, s3);
Console.WriteLine(output3); // true

var input4 = "trinitrophenylmethylnitramine";
var s4 = "dinitrophenylhydrazinetrinitrophenylmethylnitramine";
var output4 = solution.CheckInclusion(input4, s4);
Console.WriteLine(output4); // true

var input5 = "hello";
var s5 = "ooolleoooleh";
var output5 = solution.CheckInclusion(input5, s5);
Console.WriteLine(output5); // true

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        var need = new Dictionary<char, int>();

        foreach (var c in s1)
        {
            if (need.ContainsKey(c))
                need[c]++;
            else
                need.Add(c, 1);
        }

        var l = 0;
        for (int r = 0; r < s2.Length; r++)
        {
            var c = s2[r];

            if (need.ContainsKey(s2[r]))
            {
                need[c]--;
            }


            if (r - l >= s1.Length)
            {
                //Console.WriteLine($"{l} {r}");
                if (need.ContainsKey(s2[l]))
                {
                    need[s2[l]]++;
                }

                l++;
            }


            if (need.All(n => n.Value == 0))
                return true;

            //Console.WriteLine($"{l} {r}");
        }

        return need.All(n => n.Value == 0);
    }
}