namespace mosh_ds_exercises;


public class LinkedList
{
    private class Node
    {
        public readonly int Value;
        public Node(int value)
        {
            Value = value;
        }
        public Node Next { get; set; }
    }
    
    private Node Head { get; set; }
    private Node Tail { get; set; }

    private bool IsEmpty()
    {
        return Head == null;
    }

    public void AddFirst(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
        {
            Head = node;
            Tail = node;
        }
        else
        {
            node.Next = Head;
            Head = node;
        }
    }

    public void AddLast(int item)
    {
        var node = new Node(item);
        if (IsEmpty())
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Tail.Next = node;
            Tail = node;
        }
    }
    
    public int IndexOf(int item)
    {
        var curr = Head;
        var index = 0;
        while (curr != null)
        {
            if (curr.Value == item) return index;
            curr = curr.Next;
            index++;
        }
        return -1;
    }
    
    public bool Contains(int value)
    {
        return IndexOf(value) >= 0;
    }
    
    public void DeleteFirst() {}
    public void DeleteLast() {}
    

    public void PrintItems()
    {
        Console.WriteLine($"Head: {Head.Value}");
        Console.WriteLine($"Tail: {Tail.Value}");
        
        var curr = Head;
        while (curr != null)
        {
            Console.WriteLine(curr.Value);
            curr = curr.Next;
        }
    }
}