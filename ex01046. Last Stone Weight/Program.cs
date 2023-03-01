// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var stones1 = new int[] { 2, 7, 4, 1, 8, 1 };
var output1 = solution.LastStoneWeight(stones1);
Console.WriteLine(output1.ToString()); // 1

var stones2 = new int[] { 2, 2, 2, 2 };
var output2 = solution.LastStoneWeight(stones2);
Console.WriteLine(output2.ToString()); // 1

public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));

        foreach (var stone in stones)
        {
            queue.Enqueue(stone, stone);
        }

        while (queue.Count > 1)
        {
            var diff = queue.Dequeue() - queue.Dequeue();
            if (diff > 0)
                queue.Enqueue(diff, diff);
        }

        return queue.Count == 0 ? 0 : queue.Dequeue();
    }
}