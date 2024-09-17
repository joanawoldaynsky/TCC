using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int x) {
        val = x;
    }
}

public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        return serializeHelper(root, new System.Text.StringBuilder()).ToString();
    }

    private System.Text.StringBuilder serializeHelper(TreeNode node, System.Text.StringBuilder sb) {
        if (node == null) {
            sb.Append("null,");
        } else {
            sb.Append(node.val).Append(",");
            serializeHelper(node.left, sb);
            serializeHelper(node.right, sb);
        }
        return sb;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        Queue<string> nodes = new Queue<string>(data.Split(','));
        return deserializeHelper(nodes);
    }

    private TreeNode deserializeHelper(Queue<string> nodes) {
        string val = nodes.Dequeue();
        if (val == "null") {
            return null;
        } else {
            TreeNode node = new TreeNode(int.Parse(val));
            node.left = deserializeHelper(nodes);
            node.right = deserializeHelper(nodes);
            return node;
        }
    }
}

public class Test {
    public static void Main(string[] args) {
        Codec codec = new Codec();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);

        string serialized = codec.serialize(root);
        Console.WriteLine("Serialized: " + serialized);

        TreeNode deserializedRoot = codec.deserialize(serialized);
        string reserialized = codec.serialize(deserializedRoot);
        Console.WriteLine("Reserialized: " + reserialized);
    }
}
