using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        List<string> list = new List<string>();
        serialize(root, list);
        return string.Join(",", list);
    }

    private void serialize(TreeNode root, List<string> list) {
        if (root == null) {
            list.Add("null");
            return;
        }
        list.Add(root.val.ToString());
        serialize(root.left, list);
        serialize(root.right, list);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        Queue<string> queue = new Queue<string>(data.Split(','));
        return deserialize(queue);
    }

    private TreeNode deserialize(Queue<string> queue) {
        string val = queue.Dequeue();
        if (val == "null") {
            return null;
        }
        TreeNode root = new TreeNode(int.Parse(val));
        root.left = deserialize(queue);
        root.right = deserialize(queue);
        return root;
    }
}
