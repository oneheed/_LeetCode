using System.Text;

namespace LeetCode.Core
{
    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            var current = this;

            while (current != null)
            {
                stringBuilder.Append($"{current.val},");
                current = current.next;
            }

            return $"[{stringBuilder.ToString(0, stringBuilder.Length - 1)}]";
        }
    }
}
