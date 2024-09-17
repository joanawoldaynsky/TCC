using System;

public class BooleanBinaryTree
{
    public class Node
    {
        public bool Value;
        public Node Left;
        public Node Right;

        public Node(bool value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public Node Root;

    public BooleanBinaryTree()
    {
        Root = null;
    }

    public void Add(bool value)
    {
        if (Root == null)
        {
            Root = new Node(value);
        }
        else
        {
            AddRecursive(Root, value);
        }
    }

    private void AddRecursive(Node current, bool value)
    {
        if (current.Left == null)
        {
            current.Left = new Node(value);
        }
        else if (current.Right == null)
        {
            current.Right = new Node(value);
        }
        else
        {
            if (HasSpace(current.Left))
            {
                AddRecursive(current.Left, value);
            }
            else
            {
                AddRecursive(current.Right, value);
            }
        }
    }

    private bool HasSpace(Node node)
    {
        return node.Left == null || node.Right == null;
    }

    public static void Main(string[] args)
    {
        BooleanBinaryTree tree = new BooleanBinaryTree();
        tree.Add(true);
        tree.Add(false);
        tree.Add(true);
        // Additional operations can be performed here
    }
}
