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
        if (root == null) return "X";
        string leftSerialized = serialize(root.left);
        string rightSerialized = serialize(root.right);
        return root.val + "," + leftSerialized + "," + rightSerialized;
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
