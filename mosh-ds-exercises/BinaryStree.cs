namespace mosh_ds_exercises;

public class BinaryStree
{
    private Node _root;
    private class Node
    {
        public readonly int Value;
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value)
        {
            Value = value;
        }
    }

    public void Insert(int value)
    {
        var node = new Node(value);
        if (_root == null)
        {
            _root = node;
        }
        else
        {
            var curr = _root;
            while (curr != null)
            {
                if (value > curr.Value)
                {
                    if (curr.Right == null)
                    {
                        curr.Right = node;
                        break;
                    }
                    curr = curr.Right;
                }
                else
                {
                    if (curr.Left == null)
                    {
                        curr.Left = node;
                        break;
                    }
                    curr = curr.Left;
                }
            }
        }
    }

    public bool Find(int value)
    {
        var curr = _root;
        while (curr != null)
        {
            if (value == curr.Value) return true;
            curr = value > curr.Value ? curr.Right : curr.Left;
        }
        return false;
    }
}