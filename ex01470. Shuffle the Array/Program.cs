// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var nums1 = new int[] { 2, 5, 1, 3, 4, 7 };
var n1 = 3;
var output1 = solution.Shuffle(nums1, n1);
Console.WriteLine(string.Join(",", nums1)); // [2,3,5,4,1,7] 0 3 1 4 2 5 

public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        var res = new int[nums.Length];
        var diff = nums.Length / n;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < diff; j++)
            {

                //Console.WriteLine($"{i} {j} {i + j * n}");
                //Console.WriteLine(i * diff + j);

                res[i * diff + j] = nums[i + j * n];
            }
        }

        return res;
    }
}