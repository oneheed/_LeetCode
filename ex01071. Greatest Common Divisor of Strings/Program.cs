// See https://aka.ms/new-console-template for more information
var solution = new Solution();

//var str11 = "ABCABC";
//var str21 = "ABC";
//var output1 = solution.GcdOfStrings(str11, str21);
//Console.WriteLine(output1.ToString()); // "ABC"

var str12 = "TAUXXTAUXXTAUXXTAUXXTAUXX";
var str22 = "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX";
var output2 = solution.GcdOfStrings(str12, str22);
Console.WriteLine(output2.ToString()); // "TAUXX"

var str13 = "CXTXNCXTXNCXTXNCXTXNCXTXN";
var str23 = "CXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXNCXTXN";
var output3 = solution.GcdOfStrings(str13, str23);
Console.WriteLine(output3.ToString()); // "CXTXN"


// TODO
// 最大公約數 GCD
public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (!(str1 + str2).Equals(str2 + str1)) return string.Empty;

        int gcdVal = gcd(str1.Length, str2.Length);
        return str2.Substring(0, gcdVal);
    }

    public int gcd(int p, int q)
    {
        if (q == 0) return p;
        else return gcd(q, p % q);
    }
}