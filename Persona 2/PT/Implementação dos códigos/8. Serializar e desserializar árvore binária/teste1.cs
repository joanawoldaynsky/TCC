using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Codec {
    // Serialize a tree to a single string
    public string serialize(TreeNode root) {
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
            } else {
                res.Add(node.val.ToString());
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
        }
        
        return string.Join(",", res);
    }

    // Deserialize your encoded data to tree
    public TreeNode deserialize(string data) {
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
        Codec codec = new Codec();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);
        
        string serializedData = codec.serialize(root);
        Console.WriteLine("Serialized data: " + serializedData);
        
        TreeNode deserializedRoot = codec.deserialize(serializedData);
        Console.WriteLine("Deserialized tree root value: " + deserializedRoot.val);
    }
}
