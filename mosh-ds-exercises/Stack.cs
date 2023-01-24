namespace mosh_ds_exercises;

public class Stack
{
    private int _size { get; set; }
    private int[] _stack { get; set; } = new int[1];

    public bool IsEmpty()
    {
        return _size == 0;
    }

    public void Push(int item)
    {
        if (IsEmpty())
        {
            _size++;
            _stack[0] = item;
        }
        else
        {
            _size++;
            var arr = new int[_size];
            arr[0] = item;
            for (int i = 0; i < _stack.Length; i++)
            {
                arr[i + 1] = _stack[i];
            }
            _stack = arr;
        }
    }

    public void Pop() 
    {
        if (IsEmpty()) throw new Exception();
        
        _size--;
        var arr = new int[_size];
        if (_stack.Length == 1)
        {
            _stack = arr;
        }
        else
        { 
            for (int i = 1; i < _stack.Length; i++)
            {
                arr[i - 1] = _stack[i];
            }
            _stack = arr;
        }
    }

    public int Peek()
    {
        if (IsEmpty()) throw new Exception();
        return _stack[0];
    }
}