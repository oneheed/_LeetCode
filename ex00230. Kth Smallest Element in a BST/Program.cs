﻿// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(3, new(1, null, new(2)), new(4));
solution.KthSmallest(input1, 1);
//var output1 = solution.KthSmallest(input1, 1);
//Console.WriteLine(output1.ToString()); // 1

var input2 = new TreeNode(5, new(3, new(2, new(1)), new(4)), new(6));
//var output2 = solution.KthSmallest(input2, 3);
//Console.WriteLine(string.Join(",", output2)); // 3

//var input3 = new int[] { 3, 1, 2, 10, 1 };
//var output3 = solution.RunningSum(input3);
//Console.WriteLine(string.Join(",", output3)); // [3,4,6,16,17]

public class Solution
{
    public void KthSmallest(TreeNode root, int k)
    {
        if (root == null)
        {
            return;
        }

        KthSmallest(root.left, k);
        Console.WriteLine(root.val);
        KthSmallest(root.right, k);
    }
}