using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class BinaryTreeSerialization {

    // Serializa a árvore binária em uma string
    public string Serialize(TreeNode root) {
        if (root == null) {
            return "null";
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        List<string> res = new List<string>();

        while (queue.Count > 0) {
            TreeNode node = queue.Dequeue();
            if (node == null) {
                res.Add("null");
                continue;
            }
            res.Add(node.val.ToString());
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }

        return string.Join(",", res);
    }

    // Desserializa a string para a árvore binária
    public TreeNode Deserialize(string data) {
        if (data == "null") {
            return null;
        }

        string[] nodes = data.Split(',');
        TreeNode root = new TreeNode(int.Parse(nodes[0]));
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;

        while (queue.Count > 0) {
            TreeNode node = queue.Dequeue();
            if (nodes[i] != "null") {
                node.left = new TreeNode(int.Parse(nodes[i]));
                queue.Enqueue(node.left);
            }
            i++;
            if (nodes[i] != "null") {
                node.right = new TreeNode(int.Parse(nodes[i]));
                queue.Enqueue(node.right);
            }
            i++;
        }

        return root;
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
