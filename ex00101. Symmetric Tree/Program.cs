// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(1, new(2, new(3), new(4)), new(2, new(4), new(3)));
var output1 = solution.IsSymmetric(input1);
Console.WriteLine(output1.ToString()); // true

var input2 = new TreeNode(1, new(2, null, new(3)), new(2, null, new(3)));
var output2 = solution.IsSymmetric(input2);
Console.WriteLine(output2.ToString()); // false

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null)
            return true;

        return IsSame(root.left, root.right);
    }

    public bool IsSame(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
            return true;

        if (left == null || right == null)
            return false;


        return left.val == right.val &&
            IsSame(left.left, right.right) &&
            IsSame(left.right, right.left);
    }
}



