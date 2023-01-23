namespace mosh_ds_exercises;


public class LinkedList
{
    private class Node
    {
        public readonly int Value;
        public Node Next { get; set; }
        public Node(int value)
        {
            Value = value;
        }
    }
    
    private Node Head { get; set; }
    private Node Tail { get; set; }
    private int Count { get; set; }

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

        Count += 1;
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
        Count += 1;
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

    public void RemoveFirst()
    {
        if (IsEmpty()) throw new Exception();
        var prev = Head.Next;
        Head = prev;
        if (Head == null) Tail = null;
        Count -= 1;
    }

    public void RemoveLast()
    {
        if (IsEmpty()) throw new Exception();
        if (Head.Next == null)
        {
            Head = null;
            Tail = null;
            Count -= 1;
            return;
        }
        var curr = Head;
        while (curr != null && curr.Next != Tail)
        {
            curr = curr.Next;
        }
        curr.Next = null;
        Tail = curr;
        Count -= 1;
    }

    public int Size()
    {
        return Count;
    }

    public void Reverse()
    {
        if (IsEmpty()) return;
        
        var curr = Head;
        var arr = new int[Count];
        var counter = 0;
        while (curr != null)
        {
            arr[counter] = curr.Value;
            curr = curr.Next;
            counter++;
            RemoveFirst();
        }
        for (int i = 0; i < arr.Length; i++)
        {
            AddFirst(arr[i]);
        }
    }

    public void ReverseInPlace()
    {
        Node prev = null;
        var curr = Head;
        Tail = curr;
        while (curr != null)
        {
            var next = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = next;
        }
        Head = prev;
    }

    public int GetKthNodeFromTheEnd(int k)
    {
        if (IsEmpty()) throw new Exception();
            
        var counter = Count;
        var curr = Head;
        while (curr != null)
        {
            if (counter == k) return curr.Value;
            counter--;
            curr = curr.Next;
        }

        return -1;
    }

    public void PrintListMedian()
    {
        if (Head == null) throw new Exception();
        var curr = Head;
        var next = curr.Next;
        if (next == null)
        {
            Console.WriteLine(curr.Value);
        }
        else
        {
            var counter = 0;
            var items = new Dictionary<int, Node>();
            while (curr != null)
            {
                counter++;
                items.Add(counter, curr);
                curr = next;
                next = next?.Next;
            }
            //check if the number is even
            if (counter % 2 == 0)
            {
                var firstMedian = counter / 2;
                var secondMedian = (counter / 2) + 1;
                Console.WriteLine($"{items[firstMedian].Value},{items[secondMedian].Value}");
            }
            else
            {
                var median = (counter + 1) / 2;
                Console.WriteLine(items[median].Value);
            }
        }
    }
    public void PrintItems()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Empty");
            return;
        }
        
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