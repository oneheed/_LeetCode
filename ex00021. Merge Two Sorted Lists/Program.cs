// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var list11 = new ListNode(1, new(2, new(4)));
var list21 = new ListNode(1, new(3, new(4)));
var output1 = solution.MergeTwoLists(list11, list21);
Console.WriteLine(output1); // [1,1,2,3,4,4]

var list12 = default(ListNode);
var list22 = default(ListNode);
var output2 = solution.MergeTwoLists(list12, list22);
Console.WriteLine(output2); // []

//var input3 = new int[] { -1, 0 };
//var target3 = -1;
//var output3 = solution.ReverseList(input3, target3);
//Console.WriteLine(string.Join(",", output3)); // [1, 2]


public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var result = new ListNode();
        var current = result;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        if (list1 != null)
            current.next = list1;
        else
            current.next = list2;

        return result.next;
    }
}