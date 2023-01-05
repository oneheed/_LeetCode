// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(1, new(2, new(4), new(5)), new(3));
var output1 = solution.DiameterOfBinaryTree(input1);
Console.WriteLine(output1); //3

var input2 = new TreeNode(1, new(2));
var output2 = solution.DiameterOfBinaryTree(input2);
Console.WriteLine(string.Join(",", output2)); // 1

public class Solution
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        if (root == null)
            return 0;

        var left = Deepth(root.left);
        var right = Deepth(root.right);


        return left + right;
    }

    public int Deepth(TreeNode root)
    {
        if (root == null) return 0;

        return Math.Max(Deepth(root.left) + 1, Deepth(root.right) + 1);
    }
}

