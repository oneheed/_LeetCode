// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(1, new(1, new(1), new(1)), new(1, null, new(1)));
var output1 = solution.IsUnivalTree(input1);
Console.WriteLine(output1.ToString()); // true

var input2 = new TreeNode(2, new(2, new(5), new(2)), new(2));
var output2 = solution.IsUnivalTree(input2);
Console.WriteLine(output2.ToString()); // false


public class Solution
{
    public bool IsUnivalTree(TreeNode root)
    {
        if (root == null)
            return true;

        if (root.left != null && root.val != root.left.val)
            return false;

        if (root.right != null && root.val != root.right.val)
            return false;

        return IsUnivalTree(root.left) && IsUnivalTree(root.right);
    }
}