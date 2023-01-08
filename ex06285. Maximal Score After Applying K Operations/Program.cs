// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input4 = new int[] { 10, 10, 10, 10, 10 };
var k4 = 5;
var output4 = solution.MaxKelements(input4, k4);
Console.WriteLine(string.Join(",", output4)); // 50

var input5 = new int[] { 1, 10, 3, 3, 3 };
var k5 = 3;
var output5 = solution.MaxKelements(input5, k5);
Console.WriteLine(string.Join(",", output5)); // 17

public class Solution
{
    public long MaxKelements(int[] nums, int k)
    {
        var result = default(long);

        var pq = new PriorityQueue<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(nums[i], int.MaxValue - nums[i]);
        }

        for (int i = 0; i < k; i++)
        {
            var val = pq.Dequeue();
            result += val;

            val = (int)Math.Ceiling(val / 3m);

            pq.Enqueue(val, int.MaxValue - val);
        }

        return result;
    }
}