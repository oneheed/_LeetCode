// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

var solution = new Solution();

var input1 = "A man, a plan, a canal: Panama";
var output1 = solution.IsPalindrome(input1);
Console.WriteLine(output1.ToString()); // true

var input2 = "race a car";
var output2 = solution.IsPalindrome(input2);
Console.WriteLine(output2.ToString()); // false

var input3 = " ";
var output3 = solution.IsPalindrome(input3);
Console.WriteLine(output3.ToString()); // true

var input4 = ".,";
var output4 = solution.IsPalindrome(input4);
Console.WriteLine(output4.ToString()); // true


public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return true;

        int head = 0, tail = s.Length - 1;

        s = s.ToLower();
        while (head < tail)
        {
            while ((head < tail) && (s[head] < 'a' || s[head] > 'z') && (s[head] < '0' || s[head] > '9'))
                head++;

            while ((head < tail) && (s[tail] < 'a' || s[tail] > 'z') && (s[tail] < '0' || s[tail] > '9'))
                tail--;

            if (s[head] != s[tail])
                return false;

            head++;
            tail--;
        }

        return true;
    }
}

public class Solution2
{
    public bool IsPalindrome(string s)
    {
        var matches = Regex.Matches(s, @"[a-zA-Z]");
        for (int i = 0; i < matches.Count / 2; i++)
            if (matches[i].Value.ToLower() != matches[^(i + 1)].Value.ToLower())
                return false;

        return true;
    }
}


