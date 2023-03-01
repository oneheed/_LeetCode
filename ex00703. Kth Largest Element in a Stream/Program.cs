// See https://aka.ms/new-console-template for more information

var root1 = new KthLargest(3, new int[] { 4, 5, 8, 2 });
Console.WriteLine(root1.Add(3));  // 4
Console.WriteLine(root1.Add(5));  // 5
Console.WriteLine(root1.Add(10)); // 5
Console.WriteLine(root1.Add(9));  // 8
Console.WriteLine(root1.Add(4));  // 8

public class KthLargest
{
    private int k;
    private PriorityQueue<int, int> queue;

    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        this.queue = new PriorityQueue<int, int>(k + 1);

        foreach (int num in nums)
        {
            this.Add(num);
        }
    }

    public int Add(int val)
    {
        this.queue.Enqueue(val, val);

        if (this.queue.Count > k)
        {
            this.queue.Dequeue();
        }

        return this.queue.Peek();
    }
}