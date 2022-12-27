// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var root1 = new TreeNode(1, new(0), new(2));
var low1 = 1;
var high1 = 2;
var output1 = solution.TrimBST(root1, low1, high1);
Console.WriteLine(output1.ToString()); // [1,null,2]

var root2 = new TreeNode(3, new(0, null, new(2, new(1))), new(4));
var low2 = 1;
var high2 = 3;
var output2 = solution.TrimBST(root2, low2, high2);
Console.WriteLine(output2.ToString()); // true

public class Solution
{
    public TreeNode TrimBST(TreeNode root, int low, int high)
    {
        if (root == null)
            return null;

        if (root.val < low)
            return TrimBST(root.right, low, high);

        if (root.val > high)
            return TrimBST(root.left, low, high);

        root.left = TrimBST(root.left, low, root.val);
        root.right = TrimBST(root.right, root.val, high);

        return root;
    }
}