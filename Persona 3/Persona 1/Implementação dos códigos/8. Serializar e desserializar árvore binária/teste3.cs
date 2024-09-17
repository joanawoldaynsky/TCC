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
    // Serializa uma árvore binária em uma string.
    public string Serialize(TreeNode root) {
        return SerializeHelper(root, new StringBuilder()).ToString();
    }

    private StringBuilder SerializeHelper(TreeNode root, StringBuilder sb) {
        if (root == null) {
            sb.Append("null,");
            return sb;
        }
        sb.Append(root.val).Append(",");
        SerializeHelper(root.left, sb);
        SerializeHelper(root.right, sb);
        return sb;
    }

    // Desserializa a string de volta em uma árvore binária.
    public TreeNode Deserialize(string data) {
        if (string.IsNullOrEmpty(data)) return null;
        Queue<string> nodes = new Queue<string>(data.Split(',', StringSplitOptions.RemoveEmptyEntries));
        return DeserializeHelper(nodes);
    }

    private TreeNode DeserializeHelper(Queue<string> nodes) {
        string val = nodes.Dequeue();
        if (val == "null") return null;
        TreeNode root = new TreeNode(int.Parse(val));
        root.left = DeserializeHelper(nodes);
        root.right = DeserializeHelper(nodes);
        return root;
    }

    public static void Main(string[] args) {
        Codec codec = new Codec();
        
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        string serialized = codec.Serialize(root);
        Console.WriteLine("Serialized: " + serialized);

        TreeNode deserialized = codec.Deserialize(serialized);
        Console.WriteLine("Deserialized Root: " + deserialized.val);
    }
}
