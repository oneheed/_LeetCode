// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var key1 = 3;
var input1 = new TreeNode(5, new(3, new(2), new(4)), new(6, null, new(7)));
var output1 = solution.DeleteNode(input1, key1);
Console.WriteLine(output1?.ToString()); // [4,7,2,9,6,3,1]

var key2 = 0;
var input2 = new TreeNode(0);
var output2 = solution.DeleteNode(input2, key2);
Console.WriteLine(output2?.ToString()); // [4,7,2,9,6,3,1]

var key3 = 50;
var input3 = new TreeNode(50, new(30, null, new(40)), new(70, new(60), new(80)));
var output3 = solution.DeleteNode(input3, key3);
Console.WriteLine(string.Join(",", output3)); // [3,4,6,16,17]

//var input4 = new TreeNode(2147483647);
//var output4 = solution.DeleteNode(input4);
//Console.WriteLine(string.Join(",", output4)); // [3,4,6,16,17]


public class Solution
{
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null)
            return root;

        if (root.val == key)
        {
            if (root.right != null)
            {
                var temp = root.right;
                root.right = null;
                temp.left = root.left;
                root.left = null;

                return temp;
            }

            if (root.left != null)
            {
                var temp = root.left;
                root.left = null;

                return temp;
            }

            return null;
        }

        root.left = DeleteNode(root.left, key);
        root.right = DeleteNode(root.right, key);

        return root;
    }
}

