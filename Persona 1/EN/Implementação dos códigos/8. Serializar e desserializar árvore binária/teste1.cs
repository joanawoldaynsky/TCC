using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Codec {
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if (root == null) {
            return "null";
        }
        var queue = new Queue<TreeNode>();
        var result = new List<string>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            var node = queue.Dequeue();
            if (node == null) {
                result.Add("null");
            } else {
                result.Add(node.val.ToString());
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
        }
        return string.Join(",", result);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if (data == "null") {
            return null;
        }
        var nodes = data.Split(',');
        var root = new TreeNode(int.Parse(nodes[0]));
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;
        while (queue.Count > 0) {
            var node = queue.Dequeue();
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
}
