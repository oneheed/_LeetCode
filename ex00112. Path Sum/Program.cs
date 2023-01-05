// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(5, new(4, new(11, new(7), new(2))), new(8, new(13), new(4, null, new(1))));
var targetSum1 = 22;
var output1 = solution.HasPathSum(input1, targetSum1);
Console.WriteLine(output1.ToString()); // true

var input2 = new TreeNode(1, new(2), new(3));
var targetSum2 = 5;
var output2 = solution.HasPathSum(input2, targetSum2);
Console.WriteLine(output2.ToString()); // false

var input3 = default(TreeNode);
var targetSum3 = 0;
var output3 = solution.HasPathSum(input3, targetSum3);
Console.WriteLine(output3.ToString()); // false

var input4 = new TreeNode(1, new(2));
var targetSum4 = 1;
var output4 = solution.HasPathSum(input4, targetSum4);
Console.WriteLine(output4.ToString()); // false

public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;

        if (root.val == targetSum && root.left == null && root.right == null)
            return true;

        return HasPathSum(root.left, targetSum - root.val) ||
            HasPathSum(root.right, targetSum - root.val);
    }
}