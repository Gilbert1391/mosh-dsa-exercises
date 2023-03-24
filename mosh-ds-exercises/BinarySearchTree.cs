namespace mosh_ds_exercises;
using System;

public class BinarySearchTree
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

    public void DepthFirstPreOrderTraversal()
    {
        DepthFirstPreOrderTraversal(_root);
    }

    private void DepthFirstPreOrderTraversal(Node root)
    {
        if (root == null) return;
        Console.WriteLine(root.Value);
        DepthFirstPreOrderTraversal(root.Left);
        DepthFirstPreOrderTraversal(root.Right);
    }

    public void DepthFirstInOrderTraversal()
    {
        DepthFirstInOrderTraversal(_root);
    }

    private void DepthFirstInOrderTraversal(Node root)
    {
        if (root == null) return;
        DepthFirstInOrderTraversal(root.Left);
        Console.WriteLine(root.Value);
        DepthFirstInOrderTraversal(root.Right);

    }
    
    public void DepthFirstPostOrderTraversal()
    {
        DepthFirstPostOrderTraversal(_root);
    }

    private void DepthFirstPostOrderTraversal(Node root)
    {
        if (root == null) return;
        DepthFirstPostOrderTraversal(root.Left);
        DepthFirstPostOrderTraversal(root.Right);
        Console.WriteLine(root.Value);
    }

    public int Height()
    {
        return Height(_root);
    }

    private int Height(Node root)
    {
        if (root == null) return -1;
        if (root.Left == null && root.Right == null) return 0;
        return 1 + Math.Max(Height(root.Left), Height(root.Right));
    }

    public bool Equals(BinarySearchTree tree)
    {
        if (tree == null) return false; 
        return Equals(tree._root, _root);
    }

    private bool Equals(Node firstNode, Node secondNode)
    {
        if (firstNode == null && secondNode == null) return true;
        if (firstNode?.Value != secondNode?.Value) return false;
        var isLeftEqual = Equals(firstNode.Left, secondNode.Left);
        var isRightEqual = Equals(firstNode.Right, secondNode.Right);
        return isLeftEqual && isRightEqual;
    }

    public bool IsBinarySearchTree()
    {
        return IsBinarySearchTree(_root, Int32.MinValue, Int32.MaxValue);
    }

    private bool IsBinarySearchTree(Node node, int min, int max)
    {
        if (node == null) return true;
        if (node.Value < min || node.Value > max) return false;
        var isLeftValid = IsBinarySearchTree(node.Left, min, node.Value - 1);
        var isRightValid = IsBinarySearchTree(node.Right, node.Value + 1, max);
        return isLeftValid && isRightValid;
    }

    public void PrintNodesAtKDistance(int distance)
    {
        var nodes = new List<int>();
        PrintNodesAtKDistance(_root, distance, nodes);
        foreach (var n in nodes)
        {
         Console.WriteLine(n);   
        }
    }

    private void PrintNodesAtKDistance(Node root, int distance, List<int> list)
    {
        if (root == null) return;
        if (distance == 0 && root != null)
        {
            list.Add(root.Value);
            return;
        }
        PrintNodesAtKDistance(root.Left, distance - 1, list);
        PrintNodesAtKDistance(root.Right, distance - 1, list);  
    }

    public int CountLeaves()
    {
        if (_root == null) return 0;
        return CountLeaves(_root);
    }

    private int CountLeaves(Node root)
    {
        if (root.Left == null || root.Right == null) return 1;
        var leftResult = CountLeaves(root.Left);
        var rightResult = CountLeaves(root.Right);
        return leftResult + rightResult;
    }
}