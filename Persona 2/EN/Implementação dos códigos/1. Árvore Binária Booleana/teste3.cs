using System;

public class BooleanBinaryTree {
    class Node {
        public bool Value;
        public Node Left, Right;

        public Node(bool item) {
            Value = item;
            Left = Right = null;
        }
    }

    Node root;

    public BooleanBinaryTree() {
        root = null;
    }

    // Insert a new boolean value into the tree
    public void Insert(bool value) {
        root = InsertRec(root, value);
    }

    Node InsertRec(Node root, bool value) {
        if (root == null) {
            root = new Node(value);
            return root;
        }

        if (value == false) {
            root.Left = InsertRec(root.Left, value);
        } else {
            root.Right = InsertRec(root.Right, value);
        }

        return root;
    }

    // Inorder traversal
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
        BooleanBinaryTree tree = new BooleanBinaryTree();

        tree.Insert(true);
        tree.Insert(false);
        tree.Insert(true);
        tree.Insert(false);
        tree.Insert(true);

        // Print inorder traversal of the Boolean Binary Tree
        tree.Inorder();
    }
}
