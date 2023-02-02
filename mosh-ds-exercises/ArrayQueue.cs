namespace mosh_ds_exercises;

public class ArrayQueue
{
    public ArrayQueue(int size)
    {
        _size = size;
        _queue = new int[size];
    }
    private readonly int _size;
    private int[] _queue { get; set; }
    private int _count { get; set; }
    private int _front { get; set; }
    private int _end { get; set; }


    public void Enqueue(int item)
    {
        if (IsFull()) throw new Exception("Queue is full");
        _queue[_end++] = item;
        _count++;
    }

    public int DeQueue()
    {
        if(IsEmpty()) throw new Exception("Queue is empty");
        var result = _queue[_front];
        Math.DivRem(_end, _count, out var remainder);
        _end = remainder;
        if (_front == _size - 1) _front = 0;
        else _front++;
        _count--;
        
        return result;
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
        return _count >= _size;
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