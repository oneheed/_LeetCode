// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(1, new(2, null, new(5)), new(3));
var output1 = solution.BinaryTreePaths(input1);
Console.WriteLine(string.Join(",", output1)); // ["1->2->5","1->3"]


var input2 = new TreeNode(1);
var output2 = solution.BinaryTreePaths(input2);
Console.WriteLine(string.Join(",", output2)); // ["1"]

public class Solution
{
    private IList<string> result = new List<string>();

    public IList<string> BinaryTreePaths(TreeNode root)
    {
        if (root == null)
            return result;

        if (root.left == null && root.right == null)
            result.Add(root.val.ToString());

        if (root.left != null)
            Paths(root.left, root.val.ToString());

        if (root.right != null)
            Paths(root.right, root.val.ToString());

        return result;
    }

    private void Paths(TreeNode root, string path)
    {
        if (root == null) return;

        if (root.left == null && root.right == null)
            result.Add($"{path}->{root.val}");

        if (root.left != null)
            Paths(root.left, $"{path}->{root.val}");

        if (root.right != null)
            Paths(root.right, $"{path}->{root.val}");
    }
}

