using System;

class Node {
    public bool Value;
    public Node Left, Right;

    public Node(bool item) {
        Value = item;
        Left = Right = null;
    }
}

class BinaryTree {
    Node root;

    public BinaryTree() {
        root = null;
    }

    public void Insert(bool value) {
        root = InsertRec(root, value);
    }

    Node InsertRec(Node root, bool value) {
        if (root == null) {
            root = new Node(value);
            return root;
        }

        if (value) {
            root.Right = InsertRec(root.Right, value);
        } else {
            root.Left = InsertRec(root.Left, value);
        }

        return root;
    }

    public void Inorder() {
        InorderRec(root);
    }

    void InorderRec(Node root) {
        if (root != null) {
            InorderRec(root.Left);
            Console.Write(root.Value + " ");
            InorderRec(root.Right);
        }
    }

    public static void Main(String[] args) {
        BinaryTree tree = new BinaryTree();
        tree.Insert(true);
        tree.Insert(false);
        tree.Insert(true);

        tree.Inorder();
    }
}
