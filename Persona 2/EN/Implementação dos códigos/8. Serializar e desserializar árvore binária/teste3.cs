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
    public string Serialize(TreeNode root) {
        if (root == null) return "";
        var queue = new Queue<TreeNode>();
        var sb = new System.Text.StringBuilder();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            var node = queue.Dequeue();
            if (node != null) {
                sb.Append(node.val).Append(",");
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            } else {
                sb.Append("null,");
            }
        }
        sb.Length--; // Remove last comma
        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if (string.IsNullOrEmpty(data)) return null;
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
