using System;

public class BinarySearchTree {
    private class Node {
        public bool Value;
        public Node Left, Right;

        public Node(bool value) {
            Value = value;
            Left = Right = null;
        }
    }

    private Node root;

    public void Add(bool value) {
        root = AddRecursive(root, value);
    }

    private Node AddRecursive(Node current, bool value) {
        if (current == null) {
            return new Node(value);
        }
        if (value == false) {
            current.Left = AddRecursive(current.Left, value);
        } else {
            current.Right = AddRecursive(current.Right, value);
        }
        return current;
    }

    public void TraverseInOrder() {
        TraverseInOrderRecursive(root);
    }

    private void TraverseInOrderRecursive(Node node) {
        if (node != null) {
            TraverseInOrderRecursive(node.Left);
            Console.Write(node.Value + " ");
            TraverseInOrderRecursive(node.Right);
        }
    }

    public static void Main(string[] args) {
        BinarySearchTree tree = new BinarySearchTree();
        tree.Add(true);
        tree.Add(false);
        tree.Add(true);
        tree.TraverseInOrder(); // Saída esperada: "False True True"
    }
}
