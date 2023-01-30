// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = new int[] { 4, 5, 0, -2, -3, 1 };
var k1 = 5;
var output1 = solution.SubarraysDivByK(input1, k1);
Console.WriteLine(output1); // 7


// TODO 
public class Solution
{
    public int SubarraysDivByK(int[] nums, int k)
    {
        var result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var sum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                if (sum % k == 0)
                {
                    result++;
                }
            }
        }

        return result;
    }
}