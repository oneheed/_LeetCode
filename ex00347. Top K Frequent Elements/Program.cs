// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums1 = new int[] { 1, 1, 1, 2, 2, 3 };
var k1 = 2;
var output1 = solution.TopKFrequent(nums1, k1);
Console.WriteLine(string.Join(",", output1)); // [1,2]

var nums2 = new int[] { 1 };
var k2 = 2;
var output2 = solution.TopKFrequent(nums2, k2);
Console.WriteLine(string.Join(",", output2)); // [1]


public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dic.ContainsKey(num))
                dic[num]++;
            else
                dic.Add(num, 1);
        }

        return dic.OrderByDescending(d => d.Value).Take(k).Select(x => x.Key).ToArray();
    }
}