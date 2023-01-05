// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var root1 = new Node(1, new List<Node> { new Node(3, new List<Node> { new(5), new(6) }), new(2), new(4) });
var output1 = solution.Preorder(root1);
Console.WriteLine(string.Join(",", output1)); // [1,3,5,6,2,4]

public class Solution
{
    public IList<int> Preorder(Node root)
    {

        var result = new List<int>();

        if (root == null)
        {
            return result;
        }

        result.Add(root.val);

        if (root.children != null)
        {
            foreach (var node in root.children)
            {
                result.AddRange(Preorder(node));
            }
        }

        return result;
    }
}