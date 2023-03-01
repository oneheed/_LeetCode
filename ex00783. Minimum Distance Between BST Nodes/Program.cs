// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(4, new(2, new(1), new(3)), new(6));
var output1 = solution.MinDiffInBST(root);
Console.WriteLine(output1.ToString()); // 4

// TODO:
public class Solution
{
    public int MinDiffInBST(TreeNode root)
    {

    }
}