// See https://aka.ms/new-console-template for more information
var solution = new Solution();

Console.WriteLine("=1=");
var input1 = new int[] { -1, 0, 1, 2, -1, -4 };
var output1 = solution.ThreeSum(input1);
foreach (var item in output1)
{
    Console.WriteLine(string.Join(",", item)); // [[-1,-1,2],[-1,0,1]]
}

Console.WriteLine("=2=");
var input2 = new int[] { 0, 1, 1 };
var output2 = solution.ThreeSum(input2);
foreach (var item in output2)
{
    Console.WriteLine(string.Join(",", item)); // []
}

Console.WriteLine("=3=");
var input3 = new int[] { 0, 0, 0 };
var output3 = solution.ThreeSum(input3);
foreach (var item in output3)
{
    Console.WriteLine(string.Join(",", item)); // [[0,0,0]]
}

Console.WriteLine("=4=");
var input4 = new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };
var output4 = solution.ThreeSum(input4);
foreach (var item in output4)
{
    Console.WriteLine(string.Join(",", item)); // [[-4,0,4],[-4,1,3],[-3,-1,4],[-3,0,3],[-3,1,2],[-2,-1,3],[-2,0,2],[-1,-1,2],[-1,0,1]]
}

Console.WriteLine("=5=");
var input5 = new int[] { -4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0 };
var output5 = solution.ThreeSum(input5);
foreach (var item in output5)
{
    Console.WriteLine(string.Join(",", item)); // [[-5,1,4],[-4,0,4],[-4,1,3],[-2,-2,4],[-2,1,1]]
}


// -5,-5,-4,-4,-4,-2,-2,-2,0,0,0,1,1,3,4,4
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                        left++;
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return result;
    }
}

//-5,-5,-4,-4,-4,-2,-2,-2,0,0,0,1,1,3,4,4
public class Solution1
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        Array.Sort(nums);
        //Console.WriteLine(string.Join(",", nums));
        var i = 0;
        var k = nums.Length - 1;

        while (nums[i] <= 0 && k - i >= 2)
        {
            while (nums[k] >= 0 && k - i >= 2)
            {
                if (nums[i] + nums[k] > 0)
                {
                    for (var j = i + 1; j < k; j++)
                    {
                        //Console.WriteLine($"{i},{j},{k}");

                        if ((nums[i] + nums[j] + nums[k]) == 0)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[k] });
                            break;
                        }

                        if (nums[j] >= 0 || (nums[i] + nums[j] + nums[k]) > 0)
                            break;
                    }
                }
                else
                {
                    for (var j = k - 1; j > i; j--)
                    {
                        //Console.WriteLine($"{i},{j},{k}");

                        if ((nums[i] + nums[j] + nums[k]) == 0)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[k] });
                            break;
                        }

                        if (nums[j] < 0 || (nums[i] + nums[j] + nums[k]) < 0)
                            break;
                    }
                }

                do
                {
                    k--;
                }
                while (nums[k + 1] == nums[k] && k >= 1);
            }

            do
            {
                i++;
            }
            while (nums[i - 1] == nums[i] && i < nums.Length - 1);
            k = nums.Length - 1;
        }

        return result;
    }
}