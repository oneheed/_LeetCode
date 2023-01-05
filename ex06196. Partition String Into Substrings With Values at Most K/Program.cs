// See https://aka.ms/new-console-template for more information
var solution = new Solution();
// TODO: 還需要優化

var s1 = "165462";
var k1 = 60;
var output1 = solution.MinimumPartition(s1, k1);
Console.WriteLine(output1.ToString()); // 4

var s2 = "238182";
var k2 = 5;
var output2 = solution.MinimumPartition(s2, k2);
Console.WriteLine(output2.ToString()); // -1


public class Solution
{
    public int MinimumPartition(string s, int k)
    {
        var result = 0;
        var count = k.ToString().Length;
        for (int i = 0; i < s.Length; i++)
        {
            var temp = 0;
            var l = i;
            for (int j = i + 1; j <= i + count; j++)
            {
                if (j > s.Length)
                    break;

                var temp1 = int.Parse(s[i..j].ToString());

                if (temp1 > k)
                {
                    if (j == i + 1)
                    {
                        return -1;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    temp = temp1;
                    l = j - 1;
                }
            }

            //Console.WriteLine(temp);
            if (temp > k)
                return -1;
            else
            {
                i = l;
                result++;
            }
        }

        return result;
    }
}