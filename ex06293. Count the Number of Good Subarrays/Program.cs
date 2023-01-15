// See https://aka.ms/new-console-template for more information

var solution = new Solution();

//var input1 = new int[] { 1, 1, 1, 1, 1 };
//var k1 = 10;
//var output1 = solution.CountGood(input1, k1);
//Console.WriteLine(string.Join(",", output1)); // 50

//var input2 = new int[] { 3, 1, 4, 3, 2, 2, 4 };
//var k2 = 2;
//var output2 = solution.CountGood(input2, k2);
//Console.WriteLine(string.Join(",", output2)); // 50


var input3 = new int[] { 2, 1, 3, 1, 2, 2, 3, 3, 2, 2, 1, 1, 1, 3, 1 };
var k3 = 11;
var output3 = solution.CountGood(input3, k3);
Console.WriteLine(string.Join(",", output3)); // 21


public class Solution
{
    public long CountGood(int[] nums, int k)
    {
        var l = 0;
        var r = 0;
        var result = 0;
        var dic = new Dictionary<int, int>();
        var count = 0;

        while (r < nums.Length)
        {
            if (dic.ContainsKey(nums[r]))
            {
                var n = dic[nums[r]] - 1;
                count -= n * (n + 1) / 2;
                dic[nums[r]]++;
                n = n + 1;
                count += n * (n + 1) / 2;

                Console.WriteLine($"{nums[r]}:{count}");
                if (count >= k)
                    result++;
            }
            else
            {
                dic.Add(nums[r], 1);
            }

            r++;
        }

        while (l < nums.Length)
        {
            if (dic.ContainsKey(nums[l]))
            {
                var n = dic[nums[l]] - 1;
                count -= n * (n + 1) / 2;

                dic[nums[l]]--;
                n = n - 1;
                count += n * (n + 1) / 2;

                Console.WriteLine($"{nums[l]}:{count}");
                if (count >= k)
                    result++;

                var count1 = count;
                while (count1 > k && r >= l)
                {
                    var n1 = dic[nums[r]] - 1;
                    count1 -= n * (n + 1) / 2;

                    dic[nums[l]]--;
                    n = n - 1;
                    count += n * (n + 1) / 2;

                    r--;
                }
            }

            l++;
        }

        return result;
    }
}