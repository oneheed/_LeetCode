// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var input1 = new int[] { 2, 7, 11, 15 };
var target1 = 9;
var output1 = solution.TwoSum(input1, target1);
Console.WriteLine(string.Join(",", output1)); // [1, 2]

var input2 = new int[] { 2, 3, 4 };
var target2 = 6;
var output2 = solution.TwoSum(input2, target2);
Console.WriteLine(string.Join(",", output2)); // [1, 3]

var input3 = new int[] { -1, 0 };
var target3 = -1;
var output3 = solution.TwoSum(input3, target3);
Console.WriteLine(string.Join(",", output3)); // [1, 2]

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var head = 0;
        var tail = numbers.Length - 1;

        while (head < tail)
        {
            if (numbers[head] + numbers[tail] == target)
                return new int[] { head + 1, tail + 1 };

            if (numbers[head] + numbers[tail] > target)
                tail--;
            else
                head++;
        }

        return new int[2];
    }
}


public class Solution1
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var result = new int[2];

        for (int i = 0; i < numbers.Length; i++)
        {
            result[0] = i + 1;
            var diff = target - numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (diff == numbers[j])
                {
                    result[1] = j + 1;
                    return result;
                }
            }
        }

        return new int[2];
    }
}
