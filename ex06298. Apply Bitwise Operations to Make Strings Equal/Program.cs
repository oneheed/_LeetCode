// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var s1 = "1010";
var target1 = "0110";
var output1 = solution.MakeStringsEqual(s1, target1);
Console.WriteLine(string.Join(",", output1)); // true

var s2 = "11";
var target2 = "00";
var output2 = solution.MakeStringsEqual(s2, target2);
Console.WriteLine(string.Join(",", output2)); // false

var s3 = "01011";
var target3 = "01010";
var output3 = solution.MakeStringsEqual(s3, target3);
Console.WriteLine(string.Join(",", output3)); // true

var s3 = "00";
var target3 = "10";
var output3 = solution.MakeStringsEqual(s3, target3);
Console.WriteLine(string.Join(",", output3)); // true




public class Solution
{
    public bool MakeStringsEqual(string s, string target)
    {
        var sCount = 0;
        var tCount = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
                sCount++;

            if (target[i] == '1')
                tCount++;
        }

        if (tCount == 0 && sCount > 1)
            return false;
        else if (sCount >= tCount)
            return true;
        else if (tCount >= sCount && sCount >= 1)
            return true;
        else
            return false;
    }
}