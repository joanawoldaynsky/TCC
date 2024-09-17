using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Codec {

    // Serializes a tree to a single string.
    public string serialize(TreeNode root) {
        StringBuilder sb = new StringBuilder();
        serializeHelper(root, sb);
        return sb.ToString();
    }

    private void serializeHelper(TreeNode node, StringBuilder sb) {
        if (node == null) {
            sb.Append("X,");
            return;
        }
        sb.Append(node.val).Append(",");
        serializeHelper(node.left, sb);
        serializeHelper(node.right, sb);
    }


    // Deserializes your encoded data to tree.
    public TreeNode deserialize(string data) {
        Queue<string> nodes = new Queue<string>(data.Split(','));
        return buildTree(nodes);
    }

    private TreeNode buildTree(Queue<string> nodes) {
        string val = nodes.Dequeue();
        if (val == "X") return null;
        TreeNode node = new TreeNode(int.Parse(val));
        node.left = buildTree(nodes);
        node.right = buildTree(nodes);
        return node;
    }
}
