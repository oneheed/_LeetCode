// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var s1 = "ADOBECODEBANC";
var t1 = "ABC";
var output1 = solution.MinWindow(s1, t1);
Console.WriteLine(output1); // BANC

var s2 = "a";
var t2 = "a";
var output2 = solution.MinWindow(s2, t2);
Console.WriteLine(output2); // a

var s3 = "abc";
var t3 = "b";
var output3 = solution.MinWindow(s3, t3);
Console.WriteLine(output3); // b

var s4 = "a";
var t4 = "b";
var output4 = solution.MinWindow(s4, t4);
Console.WriteLine(output4); //

var s5 = "cabwefgewcwaefgcf";
var t5 = "cae";
var output5 = solution.MinWindow(s5, t5);
Console.WriteLine(output5); //cwae

var s6 = "acbbaca";
var t6 = "aba";
var output6 = solution.MinWindow(s6, t6);
Console.WriteLine(output6); //baca

var s7 = "aaaaaaaaaaaabbbbbcdd";
var t7 = "abcdd";
var output7 = solution.MinWindow(s7, t7);
Console.WriteLine(output7); //abbbbbcdd

var s8 = "acbdbaab";
var t8 = "aabd";
var output8 = solution.MinWindow(s8, t8);
Console.WriteLine(output8); //dbaa

var s9 = "caccaacaaaabbcaccaccc";
var t9 = "acccacbccc";
var output9 = solution.MinWindow(s9, t9);
Console.WriteLine(output9); //dbaa


// TODO: Timeout
public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length)
            return string.Empty;

        var result = string.Empty;
        var need = new Dictionary<char, int>();
        var queue = new LinkedList<char>();

        foreach (var c in t)
        {
            if (need.ContainsKey(c))
            {
                need[c]++;
            }
            else
            {
                need[c] = 1;
            }
        }

        for (int r = 0; r < s.Length; r++)
        {
            queue.AddLast(s[r]);

            if (need.ContainsKey(s[r]))
                need[s[r]]--;

            if (need.All(c => c.Value <= 0))
            {
                //Console.WriteLine("1 : " + string.Join("", queue.ToArray()));

                if (need.All(c => c.Value <= 0) && (result.Length > queue.Count || result == string.Empty))
                {
                    result = string.Join("", queue.ToArray());
                }

                while (need.All(c => c.Value <= 0))
                {
                    var c = queue.First();

                    if (need.ContainsKey(c))
                        need[c]++;

                    queue.RemoveFirst();

                    //Console.WriteLine("2 : " + string.Join("", queue.ToArray()));

                    if (need.All(c => c.Value <= 0) && (result.Length > queue.Count || result == string.Empty))
                    {
                        result = string.Join("", queue.ToArray());
                    }
                }
            }
        }

        while (queue.Any() && !need.ContainsKey(queue.Last()))
        {
            queue.RemoveLast();
        }

        if (need.All(c => c.Value <= 0) && (result.Length > queue.Count || result == string.Empty))
        {
            result = string.Join("", queue.ToArray());
        }

        return result;
    }
}