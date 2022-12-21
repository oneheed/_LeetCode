// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var root1 = new TreeNode(3, new(4, new(1), new(2)), new(5));
var subRoot1 = new TreeNode(4, new(1), new(2));
var output1 = solution.IsSubtree(root1, subRoot1);
Console.WriteLine(output1.ToString()); // true

var root2 = new TreeNode(3, new(4, new(1), new(2, new(0))), new(5));
var subRoot2 = new TreeNode(4, new(1), new(2));
var output2 = solution.IsSubtree(root2, subRoot2);
Console.WriteLine(output2.ToString()); // false

// 要思考一下
var root3 = new TreeNode(1, new(1));
var subRoot3 = new TreeNode(1);
var output3 = solution.IsSubtree(root3, subRoot3);
Console.WriteLine(output3.ToString()); // true

//var input4 = new TreeNode(2147483647);
//var output4 = solution.DeleteNode(input4);
//Console.WriteLine(string.Join(",", output4)); // [3,4,6,16,17]

public class Solution
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null) return false;
        if (subRoot == null) return true;

        if (root.val == subRoot.val && SameTree(root, subRoot))
        {
            return true;
        }

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool SameTree(TreeNode root, TreeNode subRoot)
    {
        if (root == null && subRoot == null)
            return true;

        //Console.WriteLine($"{root?.val} {subRoot?.val}");

        if (root?.val == subRoot?.val)
            return SameTree(root.left, subRoot.left) && SameTree(root.right, subRoot.right);

        return false;
    }
}

public class Solution2
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null)
            return false;
        else if (root.val == subRoot.val && IsSameTree(root, subRoot))
            return true;
        else
            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool IsSameTree(TreeNode n1, TreeNode n2)
    {
        if (n1 == null && n2 == null)
            return true;
        else if (n1 == null && n2 != null || n1 != null && n2 == null)
            return false;

        return n1.val == n2.val && IsSameTree(n1.left, n2.left) && IsSameTree(n1.right, n2.right);
    }
}

