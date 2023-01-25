namespace mosh_ds_exercises;

public class Stack
{
    private int _size { get; set; }
    private static readonly int _max = 5;
    private int[] _stack { get; set; } = new int[_max];

    public bool IsEmpty()
    {
        return _size == 0;
    }

    public void Push(int item) 
    {
        if (_size >= _max) throw new Exception("Stack overflow");
        _stack[_size++] = item;
    }

    public int Pop() 
    {
        if (IsEmpty()) throw new Exception("Stack underflow");
        _size--;
        var item = _stack[_size];
        _stack[_size] = 0;
        return item;
    }

    public int Peek()
    {
        if (IsEmpty()) throw new Exception("Stack underflow");
        _size--;
        return _stack[_size];
    }
}