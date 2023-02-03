namespace mosh_ds_exercises;

public class ArrayPriorityQueue
{
    private readonly int _size;
    private readonly int[] _queue;
    private int _count { get; set; }
    private int _front { get; set; }
    private int _end { get; set; }

    public ArrayPriorityQueue(int size)
    {
        _size = size;
        _queue = new int[size];
    }

    public void Enqueue(int item)
    {
        if (IsFull()) throw new Exception("Queue is full");

        _end++;
        if (IsEmpty()) _queue[_count++] = item;
        else
        {
            _count++;
            var newItem = item;
            for (int i = 0; i < _count; i++)
            {
                var curr = _queue[i];
                if (newItem > curr)
                {
                    var isEndOfQueue = i + 1 == _count;
                    if (isEndOfQueue) _queue[i] = newItem;
                }
                else
                {
                    _queue[i] = newItem;
                    newItem = curr;
                }
            }
        }
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
    
    public int Peek()
    {
        if(IsEmpty()) throw new Exception("Queue is empty");
        return _queue[_front];
    }
    
    public bool IsFull()
    {
        return _count >= _size;
    }

    public bool IsEmpty()
    {
        return _count == 0;
    }
}