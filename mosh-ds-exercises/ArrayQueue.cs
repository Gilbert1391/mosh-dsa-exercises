namespace mosh_ds_exercises;

public class ArrayQueue
{
    private static readonly int _max = 5;
    private int[] _queue { get; set; } = new int[_max];
    private int _count { get; set; }
    private int _front { get; set; }
    // private int _end { get; set; }

    public void Enqueue(int item)
    {
        if (IsFull()) throw new Exception("Queue is full");
        _queue[_count++] = item;
        // _end = _count - 1;
    }

    public int DeQueue()
    {
        if(IsEmpty()) throw new Exception("Queue is empty");
        _count--;
        return _queue[_front++];
    }

    public bool IsEmpty()
    {
        return _count == 0;
    }

    public int Peek()
    {
        if(IsEmpty()) throw new Exception("Queue is empty");
        return _queue[_front];
    }

    public bool IsFull()
    {
        return _count >= _max;
    }
    
    public void Reverse()
    {
        // var stack = new Stack();
        //
        // while (queue.Count > 0)
        //     stack.Push(queue.Dequeue());
        //
        // while (!stack.IsEmpty())
        //     queue.Enqueue(stack.Pop());
        
    }
}