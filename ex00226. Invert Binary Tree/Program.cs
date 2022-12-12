// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(4, new(2, new(1), new(3)), new(7, new(6), new(9)));
var output1 = solution.InvertTree(input1);
Console.WriteLine(output1.ToString()); // [4,7,2,9,6,3,1]

//var input2 = new int[] { 1, 1, 1, 1, 1 };
//var output2 = solution.RunningSum(input2);
//Console.WriteLine(string.Join(",", output2)); // [1,2,3,4,5]

//var input3 = new int[] { 3, 1, 2, 10, 1 };
//var output3 = solution.RunningSum(input3);
//Console.WriteLine(string.Join(",", output3)); // [3,4,6,16,17]


public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return root;

        if (root.left != null || root.right != null)
        {
            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);
        }

        return root;
    }
}

