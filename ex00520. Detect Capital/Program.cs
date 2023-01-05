// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var word1 = "USA";
var output1 = solution.DetectCapitalUse(word1);
Console.WriteLine(output1.ToString()); // true

var word2 = "FlaG";
var output2 = solution.DetectCapitalUse(word2);
Console.WriteLine(output2.ToString()); // false


var word3 = "Goolge";
var output3 = solution.DetectCapitalUse(word3);
Console.WriteLine(output3.ToString()); // true


public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (string.IsNullOrEmpty(word))
            return false;

        var result = 0;

        if (word[0] >= 'A' && word[0] <= 'Z')
            word = word[1..^0];

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] >= 'A' && word[i] <= 'Z')
                result++;

            if (i + 1 != result && result != 0)
                return false;
        }

        return true;
    }
}
