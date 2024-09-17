using System;
using System.Collections.Generic;
using System.Text;

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
        StringBuilder sb = new StringBuilder();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            TreeNode node = queue.Dequeue();
            if (node == null) {
                sb.Append("null,");
            } else {
                sb.Append(node.val).Append(",");
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
        }
        return sb.ToString().TrimEnd(',');
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if (string.IsNullOrEmpty(data)) return null;
        string[] values = data.Split(',');
        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode root = new TreeNode(int.Parse(values[0]));
        queue.Enqueue(root);
        for (int i = 1; i < values.Length; i++) {
            TreeNode parent = queue.Dequeue();
            if (values[i] != "null") {
                TreeNode left = new TreeNode(int.Parse(values[i]));
                parent.left = left;
                queue.Enqueue(left);
            }
            if (++i < values.Length && values[i] != "null") {
                TreeNode right = new TreeNode(int.Parse(values[i]));
                parent.right = right;
                queue.Enqueue(right);
            }
        }
        return root;
    }
}
