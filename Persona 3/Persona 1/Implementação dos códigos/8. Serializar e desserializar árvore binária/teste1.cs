using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class BinaryTreeSerialization {
    public string Serialize(TreeNode root) {
        if (root == null) return "null";
        return root.val + "," + Serialize(root.left) + "," + Serialize(root.right);
    }

    // Desserialização com DFS
    public TreeNode Deserialize(string data) {
        Queue<string> nodes = new Queue<string>(data.Split(','));
        return DeserializeHelper(nodes);
    }

    private TreeNode DeserializeHelper(Queue<string> nodes) {
        string val = nodes.Dequeue();
        if (val == "null") return null;
        TreeNode node = new TreeNode(int.Parse(val));
        node.left = DeserializeHelper(nodes);
        node.right = DeserializeHelper(nodes);
        return node;
    }


    public static void Main(string[] args) {
        BinaryTreeSerialization bts = new BinaryTreeSerialization();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);

        string serialized = bts.Serialize(root);
        Console.WriteLine("Serialized: " + serialized);

        TreeNode deserializedRoot = bts.Deserialize(serialized);
        string deserializedSerialized = bts.Serialize(deserializedRoot);
        Console.WriteLine("Deserialized and Serialized again: " + deserializedSerialized);
    }
}
