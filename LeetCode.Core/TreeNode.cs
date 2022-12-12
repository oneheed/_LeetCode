namespace LeetCode.Core
{
    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode(int[] ints)
        {

        }

        public override string ToString()
        {
            var result = new List<string>();
            result.Add(this.val.ToString());
            Append(result, this);

            return $"[{string.Join(",", result)}]";
        }

        private void Append(List<string> result, TreeNode node)
        {
            if (node == null)
                return;

            if (node.left != null || node.right != null)
            {
                var leftValue = node.left == null ? "null" : node.left.val.ToString();
                var rightValue = node.right == null ? "null" : node.right.val.ToString();

                result.Add(leftValue);
                result.Add(rightValue);

                Append(result, node.left);
                Append(result, node.right);
            }
        }
    }
}