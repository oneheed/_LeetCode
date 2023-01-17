// See https://aka.ms/new-console-template for more information
var solution = new Solution();

//var s1 = "00110";
//var output1 = solution.MinFlipsMonoIncr(s1);
//Console.WriteLine(string.Join(",", output1)); // 1

var s2 = "010110";
var output2 = solution.MinFlipsMonoIncr(s2);
Console.WriteLine(string.Join(",", output2)); // 2

//var s3 = "00011000";
//var output3 = solution.MinFlipsMonoIncr(s3);
//Console.WriteLine(string.Join(",", output3)); // 2

//var s4 = "0101100011";
//var output4 = solution.MinFlipsMonoIncr(s4);
//Console.WriteLine(string.Join(",", output4)); // 3

var s5 = "1111100011";
var output5 = solution.MinFlipsMonoIncr(s5);
Console.WriteLine(string.Join(",", output5)); // 3


public class Solution
{
    public int MinFlipsMonoIncr(string s)
    {
        var result = 0;
        var count0 = 0;
        var count1 = 0;

        foreach (var c in s)
        {
            if (c == '0')
                count0++;
        }

        result = s.Length - count0;

        foreach (var c in s)
        {
            //Console.WriteLine($"{count0} {count1}");
            if (c == '0')
                count0--;
            else
            {
                result = Math.Min(result, count0 + count1);

                count1++;
            }
        }

        return result;
    }
}


// 不好思考
public class Solution1
{
    public int MinFlipsMonoIncr(string s)
    {
        int num1s = 0, ans = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                ans = Math.Min(num1s, ans + 1);// we have two options to decide 
                //we either have to turn current zero to 1  
                //or turn previous '1's to '0's
            }
            else
                num1s++;//if s[i] = 1, we add it to the count of ones 
        }
        return ans;
    }
}