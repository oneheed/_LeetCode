// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

//var input1 = new TreeNode(1, new(2, new(4), new(5)), new(3));
//var output1 = solution.DiameterOfBinaryTree(input1);
//Console.WriteLine(output1); //3

//var input2 = new TreeNode(1, new(2));
//var output2 = solution.DiameterOfBinaryTree(input2);
//Console.WriteLine(output2); //1

var input3 = new TreeNode(4, new(-7), new(-3, new(-9, new(9, new(6, new(0, null, new(-1)), new(6, new(-4)))), new(-7, new(-6, new(-5)), new(-6, new(9, new(-2))))), new(-3, new(-4))));
var output3 = solution.DiameterOfBinaryTree(input3);
Console.WriteLine(output3); //8

public class Solution
{
    private int max = 0;

    public int DiameterOfBinaryTree(TreeNode root)
    {
        if (root == null)
            return 0;

        Deepth(root);

        return max;
    }

    public int Deepth(TreeNode root)
    {
        if (root == null) return 0;


        var left = Deepth(root.left);
        var right = Deepth(root.right);

        max = Math.Max(max, left + right);

        return Math.Max(left, right) + 1;
    }
}

