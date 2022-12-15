using LeetCode.Core;

var solution = new Solution();

var input = new TreeNode(1, new(2, new(4), new(5)), new(3, new(6), new(7)));
solution.PreOrder(input);
Console.WriteLine();
solution.InOrder(input);
Console.WriteLine();
solution.PostOrder(input);
Console.WriteLine();
solution.LevelOrder(input);

public class Solution
{
    public void PreOrder(TreeNode root)
    {
        if (root == null)
            return;

        Console.Write(root.val);
        PreOrder(root.left);
        PreOrder(root.right);
    }

    public void InOrder(TreeNode root)
    {
        if (root == null)
            return;

        InOrder(root.left);
        Console.Write(root.val);
        InOrder(root.right);
    }

    public void PostOrder(TreeNode root)
    {
        if (root == null)
            return;

        PostOrder(root.left);
        PostOrder(root.right);
        Console.Write(root.val);
    }

    public void LevelOrder(TreeNode root)
    {
        Queue<TreeNode> level = new Queue<TreeNode>();

        level.Enqueue(root);

        while (level.Count != 0)
        {
            var sizeInLevel = level.Count;

            while (sizeInLevel != 0)
            {
                var currentNode = level.Dequeue();

                if (currentNode.left != null)
                    level.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    level.Enqueue(currentNode.right);

                Console.Write(currentNode.val);

                sizeInLevel--;
            }
        }
    }
}