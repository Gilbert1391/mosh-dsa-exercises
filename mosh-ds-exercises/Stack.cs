namespace mosh_ds_exercises;

public class Stack
{
    public Stack(int size)
    {
        _size = size;
        _stack = new int[size];
    }
    private int _count { get; set; }
    private readonly int _size;
    private int[] _stack { get; set; }

    public bool IsEmpty()
    {
        return _count == 0;
    }

    public void Push(int item) 
    {
        if (_count >= _size) throw new Exception("Stack overflow");
        _stack[_count++] = item;
    }

    public int Pop() 
    {
        if (IsEmpty()) throw new Exception("Stack underflow");
        _count--;
        var item = _stack[_count];
        _stack[_count] = 0;
        return item;
    }

    public int Peek()
    {
        if (IsEmpty()) throw new Exception("Stack underflow");
        _count--;
        return _stack[_count];
    }
}