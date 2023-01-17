// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution1();

var input1 = new ListNode(1, new(2, new(3, new(4, new(5)))));
var output1 = solution.ReverseList(input1);
Console.WriteLine(output1); // [1, 2]

//var input2 = new int[] { 2, 3, 4 };
//var target2 = 6;
//var output2 = solution.ReverseList(input2, target2);
//Console.WriteLine(string.Join(",", output2)); // [1, 3]

//var input3 = new int[] { -1, 0 };
//var target3 = -1;
//var output3 = solution.ReverseList(input3, target3);
//Console.WriteLine(string.Join(",", output3)); // [1, 2]

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        var stack = new Stack<ListNode>();
        var current = head;
        while (current != null)
        {
            stack.Push(current);

            current = current.next;
        }

        if (stack.Any())
        {
            head = stack.Pop();
            current = head;
            while (stack.Any())
            {
                var node = stack.Pop();
                current.next = node;
                current = node;
            }

            current.next = null;
        }

        return head;
    }
}

public class Solution1
{
    public ListNode ReverseList(ListNode head)
    {
        var reverse = default(ListNode);

        while (head != null)
        {
            var temp = head.next;
            head.next = reverse;
            reverse = head;
            head = temp;
        }

        return reverse;
    }
}