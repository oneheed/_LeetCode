// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(2, new(1), new(3));
var output1 = solution.IsValidBST(input1);
Console.WriteLine(output1.ToString()); // [4,7,2,9,6,3,1]

var input2 = new TreeNode(5, new(1), new(4, new(3), new(6)));
var output2 = solution.IsValidBST(input2);
Console.WriteLine(string.Join(",", output2)); // [1,2,3,4,5]

var input3 = new TreeNode(5, new(4), new(6, new(3), new(7)));
var output3 = solution.IsValidBST(input3);
Console.WriteLine(string.Join(",", output3)); // [3,4,6,16,17]

var input4 = new TreeNode(2147483647);
var output4 = solution.IsValidBST(input4);
Console.WriteLine(string.Join(",", output4)); // [3,4,6,16,17]


public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
            return true;

        return IsValidBSTInternal(root, int.MinValue, int.MaxValue);
    }

    private bool IsValidBSTInternal(TreeNode node, long min, long max)
    {
        if (node == null)
            return true;

        Console.WriteLine($"{node.val} {min} - {max}");

        if (node.val <= min || node.val >= max)
        {
            return false;
        }

        return IsValidBSTInternal(node.left, min, node.val)
            && IsValidBSTInternal(node.right, node.val, max);
    }
}

