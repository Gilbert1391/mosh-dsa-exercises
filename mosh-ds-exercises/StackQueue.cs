namespace mosh_ds_exercises;

public class StackQueue
{
    private readonly int _size;
    private readonly mosh_ds_exercises.Stack _stackQueue;
    private readonly mosh_ds_exercises.Stack _tempStack;
    private int _counter { get; set; }
    
    public StackQueue(int size)
    {
        _size = size;
        _stackQueue = new Stack(size);
        _tempStack = new Stack(size);
    }

    public void Enqueue(int item)
    {
        if (IsFull()) throw new Exception("Queue is full");
        
        if (_stackQueue.IsEmpty()) _stackQueue.Push(item);
        else
        {
            while (!_stackQueue.IsEmpty())
            {
               _tempStack.Push(_stackQueue.Pop());
            }
            _stackQueue.Push(item);
            
            while (!_tempStack.IsEmpty())
            {
                _stackQueue.Push(_tempStack.Pop());
            }
        }
        _counter++;
    }
    
    public int DeQueue()
    {
        if(IsEmpty()) throw new Exception("Queue is empty");
        _counter--;
        return _stackQueue.Pop();
    }

    public int Peek()
    {
        if(IsEmpty()) throw new Exception("Queue is empty");
        return _stackQueue.Peek();
    }

    public bool IsEmpty()
    {
        return _counter == 0;
    }
    
    public bool IsFull()
    {
        return _counter >= _size;
    }
}