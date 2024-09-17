// BooleanBinaryTree.cs
using System;

class Node {
    public bool value;
    public Node left, right;

    public Node(bool item) {
        value = item;
        left = right = null;
    }
}

class BooleanBinaryTree {
    Node root;

    public BooleanBinaryTree() {
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
            root.right = InsertRec(root.right, value);
        } else {
            root.left = InsertRec(root.left, value);
        }
        return root;
    }

    public void Inorder() {
        InorderRec(root);
    }

    void InorderRec(Node root) {
        if (root != null) {
            InorderRec(root.left);
            Console.Write(root.value + " ");
            InorderRec(root.right);
        }
    }

    public static void Main(String[] args) {
        BooleanBinaryTree tree = new BooleanBinaryTree();
