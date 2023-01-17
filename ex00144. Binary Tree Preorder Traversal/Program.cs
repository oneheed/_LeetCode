// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var input1 = new TreeNode(1, null, new(2, new(3)));
var output1 = solution.PreorderTraversal(input1);
Console.WriteLine(string.Join(",", output1)); // [1,2,3]

var input2 = default(TreeNode);
var output2 = solution.PreorderTraversal(input2);
Console.WriteLine(string.Join(",", output2)); // []

var input3 = new TreeNode(1);
var output3 = solution.PreorderTraversal(input3);
Console.WriteLine(string.Join(",", output3)); // [1]

var input4 = new TreeNode(3, new(1), new(2));
var output4 = solution.PreorderTraversal(input4);
Console.WriteLine(string.Join(",", output4)); // [3,1,2]

public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        // Recersion
        //var result = new List<int>();
        //if (root == null)
        //    return result;

        //result.Add(root.val);
        //result.AddRange(PreorderTraversal(root.left));
        //result.AddRange(PreorderTraversal(root.right));

        //return result;

        // Iterative
        //var result = new List<int>();
        //if (root == null)
        //    return result;

        //var stack = new Stack<TreeNode>();
        //stack.Push(root);
        //while (stack.Any())
        //{
        //    var node = stack.Pop();
        //    result.Add(node.val);

        //    if (node.right != null)
        //        stack.Push(node.right);

        //    if (node.left != null)
        //        stack.Push(node.left);
        //}

        //return result;

        // MorrisTraversal (TODO)
        var result = new List<int>();

        TreeNode cur = root;
        TreeNode prev;

        while (cur != null)
        {
            if (cur.left == null)
            {
                result.Add(cur.val);
                cur = cur.right;
            }
            else
            {
                prev = cur.left;

                while (prev.right != null && prev.right != cur)
                    prev = prev.right;

                if (prev.right == null)
                {
                    result.Add(cur.val);  // the only difference with inorder-traversal

                    prev.right = cur;

                    cur = cur.left;
                }
                else
                {
                    prev.right = null;

                    cur = cur.right;
                }
            }
        }

        return result;
    }
}

