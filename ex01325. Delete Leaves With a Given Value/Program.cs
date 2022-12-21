// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var root1 = new TreeNode(1, new(2, new(2)), new(3, new(2), new(4)));
var target1 = 2;
var output1 = solution.RemoveLeafNodes(root1, target1);
Console.WriteLine(output1.ToString()); // [1,null,3,null,4]

var root2 = new TreeNode(1, new(3, new(3), new(2)), new(3));
var target2 = 3;
var output2 = solution.RemoveLeafNodes(root2, target2);
Console.WriteLine(output2.ToString()); // [1,3,null,null,2]

var root3 = new TreeNode(1, new(2, new(2, new(2, new(2)))));
var target3 = 2;
var output3 = solution.RemoveLeafNodes(root3, target3);
Console.WriteLine(output3.ToString()); // [1]

public class Solution
{
    public TreeNode RemoveLeafNodes(TreeNode root, int target)
    {
        if (root == null)
            return null;

        root.left = RemoveLeafNodes(root.left, target);
        root.right = RemoveLeafNodes(root.right, target);

        if (root.left == null && root.right == null && root.val == target)
        {
            root = null;
        }

        return root;
    }
}