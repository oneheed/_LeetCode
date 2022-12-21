// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var preorder1 = new int[] { 3, 9, 20, 15, 7 };
var inorder1 = new int[] { 9, 3, 15, 20, 7 };
var output1 = solution.BuildTree(preorder1, inorder1);
Console.WriteLine(output1.ToString()); // 3

//var input2 = new int[] { 1, 1, 1, 1, 1 };
//var output2 = solution.RunningSum(input2);
//Console.WriteLine(string.Join(",", output2)); // [1,2,3,4,5]

//var input3 = new int[] { 3, 1, 2, 10, 1 };
//var output3 = solution.RunningSum(input3);
//Console.WriteLine(string.Join(",", output3)); // [3,4,6,16,17]


public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder == null) return null;

        var root = new TreeNode(preorder[0]);
        var j = 0;
        for (int i = 1; i < preorder.Length; i++)
        {
            root.left = new TreeNode(preorder[i]);
            if (preorder[i] == inorder[j])
                break;
        }

        return root;
    }

    private void Test(TreeNode root, int[] preorder, int[] inorder, int i, int j)
    {

    }
}

