using System;

public class BooleanBinaryTree
{
    public class Node
    {
        public bool Value;
        public Node Left, Right;

        public Node(bool value)
        {
            Value = value;
            Left = Right = null;
        }
    }

    public Node Root;

    public BooleanBinaryTree()
    {
        Root = null;
    }

    public void Add(bool value)
    {
        Root = AddRecursive(Root, value);
    }

    private Node AddRecursive(Node current, bool value)
    {
        if (current == null)
        {
            return new Node(value);
        }

        if (value)
        {
            current.Right = AddRecursive(current.Right, value);
        }
        else
        {
            current.Left = AddRecursive(current.Left, value);
        }

        return current;
    }

    public void InOrderTraversal(Node node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right);
        }
    }

    public static void Main(string[] args)
    {
        BooleanBinaryTree tree = new BooleanBinaryTree();
        tree.Add(true);
        tree.Add(false);
        tree.Add(true);
        tree.Add(false);

        tree.InOrderTraversal(tree.Root);  // Output: False False True True 
    }
}
