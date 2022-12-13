// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(3, new(9), new(20, new(15), new(7)));
var output1 = solution.MaxDepth(input1);
Console.WriteLine(output1.ToString()); // 3

//var input2 = new int[] { 1, 1, 1, 1, 1 };
//var output2 = solution.RunningSum(input2);
//Console.WriteLine(string.Join(",", output2)); // [1,2,3,4,5]

//var input3 = new int[] { 3, 1, 2, 10, 1 };
//var output3 = solution.RunningSum(input3);
//Console.WriteLine(string.Join(",", output3)); // [3,4,6,16,17]


public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}

