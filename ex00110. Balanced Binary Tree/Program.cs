// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(3, new(9), new(20, new(15), new(7)));
var output1 = solution.IsBalanced(input1);
Console.WriteLine(output1.ToString()); // true

var input2 = new TreeNode(1, new(2, new(3, new(4), new(4)), new(3)), new(2));
var output2 = solution.IsBalanced(input2);
Console.WriteLine(string.Join(",", output2)); // false

var input3 = new TreeNode(1, null, new(2, null, new(3)));
var output3 = solution.IsBalanced(input3);
Console.WriteLine(string.Join(",", output3)); // false

var input4 = new TreeNode(1, new(2, new(3, new(4), null), null), new(2, null, new(3, null, new(4))));
var output4 = solution.IsBalanced(input4);
Console.WriteLine(string.Join(",", output4)); // false

public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
            return true;

        return Math.Abs(Depth(root.left) - Depth(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private int Depth(TreeNode root)
    {
        if (root == null)
            return 0;

        return Math.Max(Depth(root.left), Depth(root.right)) + 1;
    }
}

