using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Codec {
    // Serialize a binary tree to a string
    public string serialize(TreeNode root) {
        if (root == null) {
            return "null,";
        }
        return root.val + "," + serialize(root.left) + serialize(root.right);
    }

    // Deserialize a string to a binary tree
    public TreeNode deserialize(string data) {
        Queue<string> nodes = new Queue<string>(data.Split(','));
        return deserializeHelper(nodes);
    }

    private TreeNode deserializeHelper(Queue<string> nodes) {
        string val = nodes.Dequeue();
        if (val == "null") {
            return null;
        }
        TreeNode node = new TreeNode(int.Parse(val));
        node.left = deserializeHelper(nodes);
        node.right = deserializeHelper(nodes);
        return node;
    }

    public static void Main(string[] args) {
        Codec codec = new Codec();
        TreeNode tree = new TreeNode(1);
        tree.left = new TreeNode(2);
        tree.right = new TreeNode(3);
        tree.right.left = new TreeNode(4);
        tree.right.right = new TreeNode(5);

        string serializedData = codec.serialize(tree);
        Console.WriteLine("Serialized: " + serializedData);

        TreeNode deserializedTree = codec.deserialize(serializedData);
        Console.WriteLine("Deserialized: " + codec.serialize(deserializedTree));  // should match serializedData
    }
}
