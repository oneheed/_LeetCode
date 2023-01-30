// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var end1 = new ListNode(4);
var strat1 = new ListNode(2, new(3, end1));
end1.next = strat1;
var list11 = new ListNode(1, strat1);

var output1 = solution.HasCycle(list11);
Console.WriteLine(output1); // true

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;

        var p1 = head;
        var p2 = head;

        while (p2.next != null && p2.next.next != null)
        {
            p1 = p1.next;
            p2 = p2.next.next;

            if (p1 == p2)
                return true;
        }

        return false;
    }
}