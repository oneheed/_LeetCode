// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = new int[] { 1, 2, 3, 1 };
var output1 = solution.ContainsDuplicate(input1);
Console.WriteLine(output1); // true

var input2 = new int[] { 1, 2, 3, 4 };
var output2 = solution.ContainsDuplicate(input2);
Console.WriteLine(output2); // false

var input3 = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
var output3 = solution.ContainsDuplicate(input3);
Console.WriteLine(output3); // true


public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hash = new HashSet<int>();

        foreach (var num in nums)
        {
            if (hash.Contains(num))
                return true;

            hash.Add(num);
        }

        return false;
    }
}