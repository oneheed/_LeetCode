// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution2();

var preorder1 = new int[] { 3, 9, 20, 15, 7 };
var inorder1 = new int[] { 9, 3, 15, 20, 7 };
var output1 = solution.BuildTree(preorder1, inorder1);
Console.WriteLine(output1.ToString()); // [3,9,20,null,null,15,7]

var preorder2 = new int[] { -1 };
var inorder2 = new int[] { -1 };
var output2 = solution.BuildTree(preorder2, inorder2);
Console.WriteLine(output2.ToString()); // [-1]

public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder == null) return null;

        var index = Array.FindIndex(inorder, x => x == preorder[0]);


        if (index == -1) return null;

        var left = inorder[0..index];
        var right = inorder[(index + 1)..^0];

        var root = new TreeNode(preorder[0]);

        root.left = BuildTree(preorder[1..(left.Count() + 1)], left);
        root.right = BuildTree(preorder[(left.Count() + 1)..^0], right);

        return root;
    }
}


public class Solution2
{
    private int p, i = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        p = 0;
        i = 0;
        return Build(preorder, inorder);
    }

    private TreeNode Build(int[] preorder, int[] inorder, int stop = int.MinValue)
    {
        if (i < inorder.Count() && inorder[i] != stop)
        {
            Console.WriteLine($"{inorder[i]} != {stop}");
            var root = new TreeNode(preorder[p++]);
            root.left = Build(preorder, inorder, root.val);
            i++;
            root.right = Build(preorder, inorder, stop);
            return root;
        }

        return null;
    }
}
