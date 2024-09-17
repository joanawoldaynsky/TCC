using System;

class BooleanBinaryTreeNode
{
    public bool Value { get; set; }
    public BooleanBinaryTreeNode Left { get; set; }
    public BooleanBinaryTreeNode Right { get; set; }

    public BooleanBinaryTreeNode(bool value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

class BooleanBinaryTree
{
    private BooleanBinaryTreeNode root;

    public BooleanBinaryTree()
    {
        root = null;
    }

    public void Insert(bool value)
    {
        root = InsertRec(root, value);
    }

    private BooleanBinaryTreeNode InsertRec(BooleanBinaryTreeNode root, bool value)
    {
        if (root == null)
        {
            root = new BooleanBinaryTreeNode(value);
            return root;
        }

        if (value)
        {
            root.Right = InsertRec(root.Right, value);
        }
        else
        {
            root.Left = InsertRec(root.Left, value);
        }

        return root;
    }

    // Additional methods for traversal, search, etc., can be added here

    public static void Main(string[] args)
    {
        BooleanBinaryTree tree = new BooleanBinaryTree();
        tree.Insert(true);
        tree.Insert(false);
        tree.Insert(true);
        tree.Insert(false);
    }
}
