// See https://aka.ms/new-console-template for more information

var solution = new Solution1();

var input1 = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
var k1 = 3;
var output1 = solution.MaxSlidingWindow(input1, k1);
Console.WriteLine(string.Join(",", output1)); // [3,3,5,5,6,7]

var input2 = new int[] { 1 };
var k2 = 1;
var output2 = solution.MaxSlidingWindow(input2, k2);
Console.WriteLine(string.Join(",", output2)); // [1]


public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var result = new int[nums.Length - k + 1];

        var m = -1;

        var test = new Queue<int>();

        for (int l = 0; l < nums.Length - k + 1; l++)
        {
            var r = l + k - 1;
            if (m < l)
            {
                m = l;
                for (int j = l + 1; j <= r; j++)
                {
                    if (nums[j] > nums[m])
                    {
                        m = j;
                    }
                }
            }
            else if (nums[r] > nums[m])
            {
                m = r;
            }

            result[l] = nums[m];
        }

        return result;
    }
}


public class Solution1
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var result = new int[nums.Length - k + 1];
        var deque = new LinkedList<int>();

        for (int l = 0; l < nums.Length; l++)
        {
            if (deque.Count > 0 && deque.First() < l - k + 1)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && nums[deque.Last()] < nums[l])
            {
                deque.RemoveLast();
            }

            deque.AddLast(l);

            if (l >= k - 1)
            {
                result[l - k + 1] = nums[deque.First()];
            }
        }

        return result;
    }
}