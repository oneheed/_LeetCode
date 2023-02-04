// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var s1 = "PAYPALISHIRING";
var numRows1 = 3;
var output1 = solution.Convert(s1, numRows1);
Console.WriteLine(output1); // "PAHNAPLSIIGYIR"
/*
 * P   A   H   N
 * A P L S I I G
 * Y   I   R
 */

var s2 = "PAYPALISHIRING";
var numRows2 = 4;
var output2 = solution.Convert(s2, numRows2);
Console.WriteLine(output2); // "PINALSIGYAHRPI"

var s3 = "A";
var numRows3 = 1;
var output3 = solution.Convert(s3, numRows3);
Console.WriteLine(output3); // "A"

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;

        var n = (numRows - 1) * 2;
        var result = string.Empty;
        for (int i = 0; i < numRows; i++)
        {
            for (int j = i; j < s.Length; j += n)
            {
                //Console.WriteLine(j);
                result += s[j];

                if (i != 0 && i != numRows - 1 && j + n - 2 * i < s.Length)
                {
                    //Console.WriteLine(j + n - 2 * i);
                    result += s[j + n - 2 * i];
                }
            }
        }

        return result;
    }
}