// See https://aka.ms/new-console-template for more information
MyQueue myQueue = new MyQueue();
myQueue.Push(1); // queue is: [1]
myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
Console.WriteLine(myQueue.Peek()); // return 1
Console.WriteLine(myQueue.Pop()); // return 1, queue is [2]
Console.WriteLine(myQueue.Empty()); // return false

public class MyQueue
{
    private Stack<int> _stack1;
    private Stack<int> _stack2;

    public MyQueue()
    {
        _stack1 = new Stack<int>();
        _stack2 = new Stack<int>();
    }

    public void Push(int x)
    {
        _stack1.Push(x);
    }

    public int Pop()
    {
        _ = Peek();
        return _stack2.Pop();
    }

    public int Peek()
    {
        if (!_stack2.Any())
        {
            while (_stack1.Count > 0)
            {
                _stack2.Push(_stack1.Pop());
            }
        }

        return _stack2.Peek();
    }

    public bool Empty()
    {
        return !_stack1.Any() && !_stack2.Any();
    }
}