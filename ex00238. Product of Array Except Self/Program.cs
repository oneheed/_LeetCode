// See https://aka.ms/new-console-template for more information
var solution = new Solution2();

var nums1 = new int[] { 1, 2, 3, 4 };
var output1 = solution.ProductExceptSelf(nums1);
Console.WriteLine(string.Join(",", output1)); // [24,12,8,6]

var nums2 = new int[] { -1, 1, 0, -3, 3 };
var output2 = solution.ProductExceptSelf(nums2);
Console.WriteLine(string.Join(",", output2)); // [0,0,9,0,0]

public class Solution
{
    // O(n * n)
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = Enumerable.Repeat(1, nums.Length).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                    result[i] *= nums[j];
            }
        }

        return result;
    }
}

public class Solution1
{
    // O(n)
    public int[] ProductExceptSelf(int[] nums)
    {
        var left = new int[nums.Length];
        var right = new int[nums.Length];
        var result = new int[nums.Length];
        // ,       1,   1*2    1*2*3
        // 2*3*4, 3*4, 4,     ,

        left[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            left[i] = left[i - 1] * nums[i - 1];
            //Console.WriteLine(left[i]);
        }

        right[nums.Length - 1] = 1;
        result[nums.Length - 1] = left[nums.Length - 1];
        for (int j = nums.Length - 2; j >= 0; j--)
        {
            right[j] = right[j + 1] * nums[j + 1];
            result[j] = left[j] * right[j];
            //Console.WriteLine(result[j]);
        }

        return result;
    }
}

public class Solution2
{
    // ,       1,   1*2    1*2*3
    // 2*3*4, 3*4, 4,  
    // O(n)
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        Array.Fill(result, 1);

        var left = 1;
        var right = 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            left *= nums[i];
            right *= nums[nums.Length - 1 - i];

            result[i + 1] *= left;
            result[nums.Length - 2 - i] *= right;

            //Console.WriteLine($"{left} {right}");
        }

        return result;
    }
}