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


public class Solution
{
    private TreeNode prev = null;

    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        if (!IsValidBST(root.left) || prev != null && prev.val >= root.val)
        {
            return false;
        }

        prev = root;

        return IsValidBST(root.right);
    }
}

