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
        StringBuilder sb = new StringBuilder();
        SerializeHelper(root, sb);
        return sb.ToString();
    }

    private void SerializeHelper(TreeNode root, StringBuilder sb) {
        if (root == null) {
            sb.Append("null,");
        } else {
            sb.Append(root.val).Append(",");
            SerializeHelper(root.left, sb);
            SerializeHelper(root.right, sb);
        }
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        string[] dataArray = data.Split(',');
        Queue<string> queue = new Queue<string>(dataArray);
        return DeserializeHelper(queue);
    }

    private TreeNode DeserializeHelper(Queue<string> queue) {
        string val = queue.Dequeue();
        if (val == "null") {
            return null;
        }
        TreeNode root = new TreeNode(int.Parse(val));
        root.left = DeserializeHelper(queue);
        root.right = DeserializeHelper(queue);
        return root;
    }
}
