namespace mosh_ds_exercises;

public class LinkedListQueue
{
    public LinkedListQueue(int size)
    {
        _size = size;
    }
    private readonly int _size;
    private int Count { get; set; }
    private class Node
    {
        public Node(int value)
        {
            Value = value;
        }
        public readonly int Value;
        public Node Next { get; set; }
    }
    private Node Head { get; set; }

    public void Enqueue(int item)
    {
        if(IsFull()) throw new Exception("Queue is full");

        var node = new Node(item);
        if (IsEmpty())
        {
            Head = node;
        }
        else
        {
            // 1 -> 2
            var curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }
            curr.Next = node;
        }
        Count++;
    }

    public int Dequeue()
    {
        if (IsEmpty()) throw new Exception("Queue is empty");
        
        Count--;
        var curr = Head;
        Head = curr.Next;
        return curr.Value;
    }

    public int Peek()
    {
        if (IsEmpty()) throw new Exception("Queue is empty");
        return Head.Value;
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }

    public bool IsFull()
    {
        return Count == _size;
    }
}