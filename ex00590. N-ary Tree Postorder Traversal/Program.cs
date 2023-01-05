// See https://aka.ms/new-console-template for more information

using LeetCode.Core;

var solution = new Solution();

var root1 = new Node(1, new List<Node> { new Node(3, new List<Node> { new(5), new(6) }), new(2), new(4) });
var output1 = solution.Postorder(root1);
Console.WriteLine(string.Join(",", output1)); // [5,6,3,2,4,1]

public class Solution
{
    public IList<int> Postorder(Node root)
    {
        var result = new List<int>();

        if (root == null)
        {
            return result;
        }

        if (root.children != null)
        {
            foreach (var node in root.children)
            {
                result.AddRange(Postorder(node));
            }
        }

        result.Add(root.val);


        return result;
    }
}