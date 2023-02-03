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
    
    public void Reverse(int k)
    {
        if (IsEmpty()) return;
        
        mosh_ds_exercises.Stack stack = new Stack(k);
        for (int i = 0; i < k; i++)
        {
            stack.Push(_queue[i]);
        }

        var idx = 0;
        while (!stack.IsEmpty())
        {
            _queue[idx] = stack.Pop();
            idx++;
        }
        
    }
}